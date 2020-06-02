using ProcP.UIelements;
using ProcP.WHobjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace ProcP
{
	public partial class iBlade : Form
	{
        Statistics stats;
        public static Warehouse wh;
        public static Bitmap DrawArea;
        public List<OrderControl> ListOfOrdersForms = new List<OrderControl>(); //List of OrderControls FORMS		
        public int counter = 0;
        public static Map map;
        public static bool Status = false;

        public iBlade()
		{
			InitializeComponent();
			wh = new Warehouse(pbMain.Size.Width, pbMain.Size.Height);
			DrawArea = new Bitmap(pbMain.Size.Width, pbMain.Size.Height);
            comboBox1.DataSource = ProductList.possibleProducts;
            comboBox1.DisplayMember = "FullName";
            stats = new Statistics();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);          
            map = new Map();

            // this.WindowState = FormWindowState.Maximized;  //the window starts maximized
        }

        /// <summary>
        /// This method is called when the "Stop Simulation" btn fires an event in the SimulationControlPanel.
        /// </summary>
        private void OnStopSimulation(UserControl uc)
        {
            TabControlSettings.SelectedTab = TabPageSettingsMain;
            AGVtimer.Enabled = false;
            TimeLineTimer.Enabled = false;
            StatisticsPage sp = new StatisticsPage(wh, stats);           
            TabPageStatistics.Controls.Add(sp);
        }


        /// <summary>
        /// Opens a small window to set the warehouse specifications
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWSchange_Click(object sender, EventArgs e)
        {
			pbMain.Image = null;
			var form = new WSpopup(wh, pbMain);
            form.Show(this);


        }


        /// <summary>
        /// Opens a File Explorer dialog box to upload .csv file with predefined order settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpload_Click(object sender, EventArgs e)
        {
            wh.Upload();
        }


        /// <summary>
        /// Opens the order settings panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSet_Click(object sender, EventArgs e)
        {
            foreach (OrderControl i in wh.SetOrders())
            {
                ListOfOrdersForms.Add(i);
                OrderListPanel.Controls.Add(i);
            }
            TabControlMain.SelectedTab = TabPageOrderSettings;
            
            

        }

        /// <summary>
        /// Calls the method that starts the simulation, changes the visible controls 
        /// on the left panel to controls relevant to the running simulation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartSim_Click(object sender, EventArgs e)
        {

            stats.st = DateTime.Now; // Records the date and time when the simulation started
            stats.realst = wh.ListOrders.Min(a => a.TimeStamp); //Stores the earliest order TimeStamp
            stats.NrAgv = wh.AGVList.Count;
            stats.NrOrders = wh.ListOrders.Count();
            DrawArea = new Bitmap(pbMain.Size.Width, pbMain.Size.Height);
            
            TabControlSettings.SelectedTab = TabPageDuringSimulation;
            //simControlPanel.OnStopSim += (s, ec) => OnStopSimulation(simControlPanel);

            wh.AGVList.ForEach(x => x.LoadImage());
            
            AGVtimer.Enabled = true;
            TimeLineTimer.Enabled = true;
            VisualizeElapsedTime();
            
            //wh.AGVList[0].ShortestPath(400, 500, "INBOUND");
            foreach (var order in wh.AGVList[0].OrderList)
            {
                foreach (var item in order.ItemsList)
                {
                    foreach (var x in wh.GetRackList())
                    {
                        if (x.Product != null)
                        {
                                        
                                            

                            if (item.productItem.ID == x.Product.ID )
                            {
                                ShortestPath(x.Position.X, x.Position.Y - 22);
                                if (order.Type == "Inbound")
                                {
                                    ShortestPath(150, 500);
                                }
                                else
                                {
                                    ShortestPath(550, 500);
                                }
                            }
                                            

                        }
                    }
                }
            }

        }

        /// <summary>
        /// Hides order settings panel without order creation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            TabControlMain.SelectedTab = TabPageSimulation;
        }


        /// <summary>
        /// Hides the order settings panel, creates orders from given data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveOrders_Click(object sender, EventArgs e)
        {

            //TabControlMain.SelectedTab = TabPageSimulation;
            wh.PopulateOrderList(ListOfOrdersForms);

           
                foreach (Order o in wh.ListOrders)
                
                
            {
               // listBoxOrders.Items.Add(o.ID);
               
                
                //foreach (OrderItem oi in o.ItemsList)

                //{
                //     listBoxOrders.Items.Add(oi.productItem.Name + oi.Quantity.ToString());

                //}

                   //Console.WriteLine(a.ID);
                   //Console.WriteLine(o.ID);

   
            }



            for(int i = 0; i < wh.AGVList.Count; i++)
            {
                wh.AGVList[i].OrderList.Add(wh.ListOrders[i]);
            }

            TabControlMain.SelectedTab = TabPageSimulation;


            /*OrdersFormPopup form = new OrdersFormPopup(wh.ListOrders, wh.AGVList, wh, pbMain);
            form.Show(this);*/

        }


        #region MenuItem definitions

        private void warehouseSpecificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new WSpopup(wh, pbMain);
            form.Show(this);
        }

        private void orderSimulationDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControlMain.SelectedTab = TabPageOrderSettings;
        }

        private void simulationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void historyDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControlMain.SelectedTab = TabPageStatistics;
        }

        #endregion

        // the timer checks the direction of the agv and can rotate it
        private void AGVtimer_Tick(object sender, EventArgs e)
        {
            pbMain.Invalidate();
        }


        double difference;
        int inc = 0;
        private void VisualizeElapsedTime()
        {
            TimeLineTimer.Tick += new EventHandler(TimeLineTimer_Tick);
            TimeLineTimer.Start();
            DateTime start = wh.ListOrders.Min(a => a.TimeStamp);
            DateTime end = wh.ListOrders.Max(a => a.TimeStamp).AddHours(1);
            difference = (end - start).TotalMinutes;
            Console.WriteLine(difference);

            Graphics g = pbTimeLine.CreateGraphics();
            Pen p = new Pen(Color.Green, 5);
            g.DrawLine(p, 5, 25, 1000, 25);
            Font drawFont = new Font("Microsoft Sans Serif", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            g.DrawString(start.ToShortTimeString(), drawFont, drawBrush, 0, 5);
            g.DrawString(end.ToShortTimeString(), drawFont, drawBrush, 990, 5);
        }

        private void TimeLineTimer_Tick(object sender, EventArgs e)
        {
            difference--;
            inc++;
            Graphics g = pbTimeLine.CreateGraphics();
            Pen p = new Pen(Color.Green, 5);
            g.DrawLine(p, inc, 10, inc, 30);
            //pbTimeLine.Refresh();
            if (difference == 0)
            {
                TimeLineTimer.Stop();
                TimeLineTimer.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // wh.AGVList[0].timerDraw(timer1);
        }

        
        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            wh.PopulateOrderList(ListOfOrdersForms);
            wh.SaveToFile();
        }

        private void pbMain_MouseUp(object sender, MouseEventArgs e)
        {
            Rack thisRack = wh.GetRack(e.X, e.Y);
            Line thisLine = wh.GetLine(e.X, e.Y);
            Area thisArea = wh.GetArea(e.X, e.Y);

            if (thisRack != null)
            {
                var ProductSetupForm = new ProductsSetup(wh, thisRack);
                ProductSetupForm.Show(this);
            }          
            else if (thisLine != null)
            {
                var LineSettings = new LineSettingsPopup(thisLine);
                LineSettings.Show(this);
            }
            else if (thisArea != null)
            {
                var AreaSettings = new AreaPopup(thisArea, wh, pbMain);
                AreaSettings.Show(this);
                foreach(Order o in wh.ListOrders)
                {
                    if(o.Type == "Outbound")
                    {
                        AreaSettings.listBox1.Items.Add(o.Type + " to be picked up at " + o.TimeStamp.ToString());
                    }
                }
            }
        }

        private void pbMain_Paint(object sender, PaintEventArgs e)
        {
            //foreach (AGV agv in wh.AGVList)
            // {
            if (wh.AGVList.Count != 0)
            {
                wh.AGVList[0].Move(pbMain, stats, e);
            }

           // }
            //wh.DrawAreas(); // draw the racks (shouldn't draw it at every tick)
        }


        public void ShortestPath(int x, int y)
        {
            Point point1 = new Point(wh.AGVList[0].PositionX, wh.AGVList[0].PositionY);
            Point point2 = new Point(x, y);
            //Map map = new Map();
            //map.CreateMap("map", iBlade.wh.Width, iBlade.wh.Height);
            PathCalculator path = new PathCalculator(iBlade.map.TilesArray);
            List<Tile> mylist = new List<Tile>();
            mylist = path.FindShortestPath(point1, point2);
            foreach (var item in mylist)
            {
                wh.AGVList[0].PointList.Add(item.Location);
            }
            wh.AGVList[0].PositionX = mylist[mylist.Count - 1].Location.X;
            wh.AGVList[0].PositionY = mylist[mylist.Count - 1].Location.Y;
            iBlade.Status = true;
        }
    }
}

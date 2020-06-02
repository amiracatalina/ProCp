using ProcP.UIelements;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcP
{
	public class Warehouse
	{
		public int Width { get; set; }
		public int Height { get; set; }
		public List<Line> LinesList { get; set; }
        public List<Area> AreaList { get; set; }
		public List<AGV> AGVList { get; set; }
        public List<OrderControl> ListOfOrdersForm;
        public List<Order> ListOrders = new List<Order>(); //List of saved orders
        public int counter = 0;
        public int count = 0;



        public Warehouse(int x, int y)
        {
            AGVList = new List<AGV>();
            LinesList = new List<Line>();
            AreaList = new List<Area>();
            Height = y;
            Width = x;
          
        }

        public Bitmap DrawAreas()
        {

            LinesList.ForEach(x => x.DrawLine());
            GetRackList().ForEach(x => x.DrawRack());

            Area inbound = new Area("INBOUND", new Size(150, 100), new Point(130, 500));
            Area outbound = new Area("OUTBOUND", new Size(150, 100), new Point(550, 500));
            this.AreaList.Add(inbound);
            this.AreaList.Add(outbound);

            AreaList.ForEach( x => x.DrawArea());

            return iBlade.DrawArea;
        }

        //public PictureBox PictureOutbound()
        //{
        //    PictureBox pictureOutbound = new PictureBox
        //    {
        //        Name = "pictureOutbound",
        //        Location = new Point(130, 550),
        //        Image = Properties.Resources.bound,
        //        SizeMode = PictureBoxSizeMode.CenterImage
        //    };

        //    return pictureOutbound;
        //}

        //public PictureBox PictureInbound()
        //{
        //    PictureBox pictureInbound = new PictureBox
        //    {
        //        Name = "pictureOutbound",
        //        Location = new Point(700, 550),
        //        Image = Properties.Resources.bound,
        //        SizeMode = PictureBoxSizeMode.CenterImage
        //    };

        //    return pictureInbound;
        //}

        /// <summary>
        /// According to the settings in WSpopup, creates lines and populates it with racks
        /// </summary>
        public void CreateLines(int noOfRacks, int noOfRacksperLine, PictureBox mainFormImage)
        {
            Point p = new Point(104, 167);
            char[] LineID = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };
            int numberOfLines = noOfRacks / noOfRacksperLine;
            if (noOfRacks % noOfRacksperLine >= 0)
                ++numberOfLines;

            int rackCounter = 0;
            for (int i = 0; i < numberOfLines; i++)
            {
                Line line = new Line(i);
                for (int j = 0; j < noOfRacksperLine; j++)
                {
                    if (rackCounter == noOfRacks) break;
                    string id = LineID[i].ToString() + "-" + j.ToString();
                    Rack r = new Rack(p, id);
                    line.RackList.Add(r);
                    rackCounter++;
                    p.X += 50;
                }
                this.LinesList.Add(line);

                if (rackCounter == noOfRacks) break;

                if (p.X >= mainFormImage.Size.Width / 2)
                {
                    p.X = 104;
                    p.Y += 100;
                }
                else
                {
                    p.X += 150;
                }
            }
        }

        /// <summary>
        /// If this warehouse has a rack that contains the point (xmouse,ymouse),
        /// then that rack is returned, else null is returned
        /// </summary>
        /// <param name="xmouse"></param>
        /// <param name="ymouse"></param>
        public Rack GetRack(int xmouse, int ymouse)
        {
            foreach (Line l in this.LinesList)
            {
                foreach (Rack r in l.RackList)
                {
                    if (r.ContainsPoint(xmouse, ymouse)) { return r; }
                }
            }
            return null; //to satisfy the compiler
        }

        /// <summary>
        /// If this warehouse has a line that contains the point (xmouse,ymouse),
        /// then that line is returned, else null is returned
        /// </summary>
        /// <param name="xmouse"></param>
        /// <param name="ymouse"></param>
        public Line GetLine(int xmouse, int ymouse)
        {

           foreach (Line l in LinesList)
           {
               if (l.ContainsPoint(xmouse, ymouse)) { return l; }
           }
            
            return null; //to satisfy the compiler
        }

        public Area GetArea(int xmouse, int ymouse)
        {

            foreach (Area a in AreaList)
            {
                if (a.ContainsPoint(xmouse, ymouse)) { return a; }
            }

            return null; //to satisfy the compiler
        }

        public List<Rack> GetRackList()
		{
            List<Rack> rackList = new List<Rack>();
			foreach (Line l in LinesList)
					rackList.AddRange(l.RackList);
			return rackList;
		}

        public void PopulateOrderList(List<OrderControl> ListOfOrdersForm)
        {
            foreach (OrderControl od in ListOfOrdersForm)
            {
                if (od.typeItem != "")
                {
                    Order newOrder;
                    List<OrderItem> itemslist = new List<OrderItem>();
                    foreach (OrderItemControl oc in od.ItemControlList)
                    {
                        if (oc.chosenItem != null && oc.quantityOfItem != 0)
                        {
                            itemslist.Add(new OrderItem(oc.chosenItem, oc.quantityOfItem));
                        }
                    }
                    newOrder = new Order(counter++, od.typeItem, od.StartTime, itemslist);
                    ListOrders.Add(newOrder);
                    
                }
            }
            
        }

        public void SaveOrdersToFile(string filename)
        {
            string delimiter = ",";
            List<string> outputDates = new List<string>();
            List<string> outputTypes = new List<string>();
            List<string> outputItemsPerOrder = new List<string>();
            string[] outputAllItems = new string[1000];
           
            foreach (Order o in ListOrders)
            {
                outputDates.Add(o.TimeStamp.ToString());
                outputTypes.Add(o.Type.ToString());
                foreach (OrderItem oi in o.GetListOrderItems())
                {
                    outputItemsPerOrder.Add(oi.ToString());
                    outputAllItems[count] = outputAllItems[count] + "Item name: " + oi.productItem.Name.ToString() + "; Quantity: " + oi.Quantity.ToString() + delimiter;
                }
                count++;
            }

            int length = outputDates.Count;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Join(delimiter, "Date", "Type", "Items"));
            for (int index = 0; index < length; index++)
            {
                sb.AppendLine(string.Join(delimiter, outputDates[index], outputTypes[index], outputAllItems[index]));
            }

            File.WriteAllText(filename, sb.ToString());

        }

        public void Upload()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Comma-separated files | *.csv"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
                {
                    // ...
                }
            }
        }


        public List<OrderControl> SetOrders()
        {
            ListOfOrdersForm = new List<OrderControl>();

            for (int i = 0; i < 5; i++)
            {
                OrderControl oc = new OrderControl(this);
                ListOfOrdersForm.Add(oc);
            }
            return ListOfOrdersForm;
        }

        

       public void SaveToFile()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV Files (*.csv*)|*.csv*";
                sfd.DefaultExt = "csv";
                sfd.AddExtension = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filename = sfd.FileName;
                    SaveOrdersToFile(filename);
                }
                else
                {
                    MessageBox.Show("You cancelled!");
                }
            }
        }

        
    }
}

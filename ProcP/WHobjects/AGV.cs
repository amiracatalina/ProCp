using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Windows.Forms;
using ProcP.WHobjects;

namespace ProcP
{
	public class AGV
	{
		public string ID { get; set; }
		public int Capacity { get; set; }
		public int PositionX	 { get; set; }
        public int PositionY { get; set; }
        public int  Speed { get; set; }
        public List<Order> OrderList = new List<Order>();

        int pictureBoxHeight, pictureBoxWidth;
        public List<Point> PointList = new List<Point>();
        //Bitmap DrawArea;
        Image imageAGV;
        public int rotateAngle = 0;
        static int rotated = 0;
        string rotateDirection = "";
        Bitmap AGVD;

 

        public AGV(int pbHeight, int pbWidth, int counter)
        {
            pictureBoxHeight = pbHeight;
            pictureBoxWidth = pbWidth;
            PositionX = 300;
            PositionY = 300;
            ID = "0" + counter.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
        }

        public AGV(string id)
        {
            ID = id;
        }

        public Bitmap DrawPoints(int x, int y, int rotatevalue, PaintEventArgs e)
        {
            PositionX = x;
            PositionY = y;
            rotated = rotatevalue;

            //iBlade.DrawArea = new Bitmap(pictureBoxWidth, pictureBoxHeight);
            //Graphics g;
            //g = Graphics.FromImage(iBlade.DrawArea);
            Pen mypen = new Pen(Color.Black);
            e.Graphics.TranslateTransform(x, y);

            e.Graphics.RotateTransform(rotatevalue);
            e.Graphics.TranslateTransform(-x, -y);


            e.Graphics.DrawImage(AGVD, new Point(x, y));
            //g.Save();
            //g.Dispose();
            //iBlade.DrawArea = AGVD;


            return iBlade.DrawArea;
        }

        public void LoadImage()
        {
            imageAGV = Properties.Resources.AVG;
            AGVD = ResizeImage(imageAGV, 40, 22);
           
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }



        public void changeDirection(string direction)
        {
            rotateDirection = direction;
            
        }


        public void Move(PictureBox pbMain, Statistics stats, PaintEventArgs e)
        {
            List<Point> PointList = new List<Point>();
            
            PointList = this.PointList;
            if (PointList.Count > 1)
            {
                pbMain.Image = this.DrawPoints(PointList[0].X, PointList[0].Y, this.rotateAngle, e);
                if (PointList.Count > 1)
                {
                    if (PointList[0].X < PointList[1].X && PointList[0].Y < PointList[1].Y) this.rotateAngle = 45;
                    else if (PointList[0].X == PointList[1].X && PointList[0].Y < PointList[1].Y) this.rotateAngle = 90;
                    else if (PointList[0].X == PointList[1].X && PointList[0].Y > PointList[1].Y) this.rotateAngle = -90;
                    else if (PointList[0].X > PointList[1].X && PointList[0].Y > PointList[1].Y) this.rotateAngle = -135;
                    else if (PointList[0].X < PointList[1].X && PointList[0].Y < PointList[1].Y) this.rotateAngle = -45;
                    else if (PointList[0].X < PointList[1].X && PointList[0].Y > PointList[1].Y) this.rotateAngle = -45;
                    else if (PointList[0].X > PointList[1].X && PointList[0].Y < PointList[1].Y) this.rotateAngle = 135;
                    else if (PointList[0].X < PointList[1].X && PointList[0].Y == PointList[1].Y) this.rotateAngle = 0;
                    else if (PointList[0].X > PointList[1].X && PointList[0].Y == PointList[1].Y) this.rotateAngle = 180;
                }

                PointList.RemoveAt(0);
                if (this.PositionX == 750 && this.PositionY == 520)
                {

                    stats.en = DateTime.Now;
                    TimeSpan t = stats.CalculateSimulationTime();
                    MessageBox.Show("Simulation has ended, total time: " + t.Seconds);

                }
            }
            else if(PointList.Count !=0)
            {
                pbMain.Image = this.DrawPoints(PointList[0].X, PointList[0].Y, this.rotateAngle, e);
                iBlade.Status = false;
            }

        }

        public void AddOrder(Order o)
        {
            OrderList.Add(o);
        }

        public void RemoveOrder(Order o)
        {
            OrderList.Remove(o);
        }

        public List<Order> GetAGVOrders()
        {
             return OrderList;
        }
        // this method uses the PathCalculator class to calculate the shortest path between 2 points and saves the path into a list
        // then put that list in the agv object


    }
}

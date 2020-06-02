using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace ProcP
{
	public class Line
	{
		public int ID { get; set; }
		public List<Rack> RackList { get; set; }
		public Point StartPoint { get; set; }
		public int Size { get; set; }
        public ProductType PriorityProduct { get; set; }
        public Point Position;


        public Line(int id)
        {
            ID = id;
            RackList = new List<Rack>();
            Position = new Point();
        }

        public Bitmap DrawLine()
        {
            Graphics g;
            g = Graphics.FromImage(iBlade.DrawArea);
            Pen myPen = new Pen(Color.Black, 2);
            SolidBrush fillColor = new SolidBrush(Color.Red);
            Position.X = RackList[0].Position.X - 30;
            Position.Y = RackList[0].Position.Y;
            Rectangle settingsEllipse = new Rectangle(Position.X, Position.Y , 25, 25);
            g.DrawEllipse(myPen, settingsEllipse);
            g.FillEllipse(fillColor, settingsEllipse);
            g.Dispose();
            return iBlade.DrawArea;
        }

        public bool ContainsPoint(int xmouse, int ymouse)
        {
            return (xmouse >= Position.X && xmouse <= (Position.X + 25) &&
                (ymouse >= Position.Y && ymouse <= (Position.Y + 25)));
        }
    }
}

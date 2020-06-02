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
	public class Rack
	{
		public string ID { get; set; }
        public Size RackSize { get; set; } = new Size( 50, 50 );
		public Point Position { get; set; }
		//public List<Product> ProductsList { get; set; }
		public Product Product { get; set; }

		

		public Rack(Point p, string id)
		{
			Position = p;
			ID = id;
        }


		public Bitmap DrawRack()
		{

			Graphics g;
			g = Graphics.FromImage(iBlade.DrawArea);
            Font drawFont = new Font("Microsoft Sans Serif", 14);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            SolidBrush fillBrush = new SolidBrush(Color.LightPink);

            Pen myPen = new Pen(Color.Black, 5);
            Rectangle rackRect = new Rectangle( new Point( Position.X, Position.Y ), RackSize );
            if (this.Product != null)
                g.FillRectangle(fillBrush, rackRect);
            g.DrawRectangle( myPen, rackRect );
            g.DrawString(ID.ToString(), drawFont, drawBrush, Position.X+3, Position.Y+10);
            
			g.Dispose();

			return iBlade.DrawArea;
		}

        /// <summary>
        /// checks if the point (xmouse,ymouse) is on this area.
        /// </summary>
        /// <param name="xmouse"></param>
        /// <param name="ymouse"></param>
        /// <returns></returns>
        public bool ContainsPoint(int xmouse, int ymouse)
        {
            return (xmouse >= Position.X && xmouse <= (Position.X + RackSize.Width) &&
                (ymouse >= Position.Y && ymouse <= (Position.Y + RackSize.Height)));
        }

      



    }
}

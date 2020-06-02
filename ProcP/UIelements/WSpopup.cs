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
using ProcP.WHobjects;

namespace ProcP
{
	public partial class WSpopup : Form
	{
		public Warehouse wh; // stores the warehouse object from Form1.cs
		public PictureBox mainFormImage;
		
        public int counter = 0;

        public WSpopup(Warehouse w, PictureBox img)
        {
            InitializeComponent();
			wh = w;
			mainFormImage = img;
        }

        private void btnWSsave_Click(object sender, EventArgs e)
        {

            int noOfRacks = Convert.ToInt32(numericUpDown3.Value);
            int noOfRacksperLine = Convert.ToInt32(numericUpDown4.Value);
            int noOfAgv = Convert.ToInt32(numericUpDown5.Value);

            wh.CreateLines(noOfRacks, noOfRacksperLine, mainFormImage);

            for(int i=0; i<noOfAgv; i++)
            {
                AGV agv = new AGV( 1197 , 789, ++counter );
                //agv.LoadImage();
                wh.AGVList.Add( agv );               
            }

            

            this.Close();
            mainFormImage.BackgroundImage = wh.DrawAreas();
            mainFormImage.Refresh();
           
            iBlade.map.CreateMap("map", iBlade.wh.Width, iBlade.wh.Height);
           // wh.AGVList[0].ShortestPath(300, 299, "");
            
        }

        private void btnWSupload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.csv"; // file types, that will be allowed to upload
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

    }
}

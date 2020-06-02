using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcP.UIelements
{
    public partial class SimulationControlPanel : UserControl
    {
        
        public event EventHandler OnStopSim;
        
        public SimulationControlPanel()
        {
            InitializeComponent();
            btnStopSimulation.Click += (s, e) => this.OnStopSim?.Invoke(this, e);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var ProductSetupForm = new ProductsSetup(iBlade.wh);
            //ProductSetupForm.Show(this);
        }

        public void AddRacks()
        {

            foreach (Rack r in iBlade.wh.GetRackList())
            {
                if (r.Product == null)
                    listBox1.Items.Add(r.ID);
            }

        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            AddRacks();
        }

        private void buttonChairs_Click(object sender, EventArgs e)
        {
            Product p = new Product("Chair", 20);
            foreach (var v in listBox1.SelectedItems)
            {
                foreach (Rack r in iBlade.wh.GetRackList())
                {
                    if (r.ID == v.ToString())
                    {
                        r.Product = p;

                    }
                }


            }
            listBox1.Items.Clear();
            AddRacks();
        }

        private void buttonTables_Click(object sender, EventArgs e)
        {
            Product p = new Product("Table", 10);
            foreach (var v in listBox1.SelectedItems)
            {
                foreach (Rack r in iBlade.wh.GetRackList())
                {
                    if (r.ID == v.ToString())
                    {
                        r.Product = p;

                    }
                }


            }
            listBox1.Items.Clear();
            AddRacks();
        }

        private void buttonSofas_Click(object sender, EventArgs e)
        {
            Product p = new Product("Sofa", 5);
            foreach (var v in listBox1.SelectedItems)
            {
                foreach (Rack r in iBlade.wh.GetRackList())
                {
                    if (r.ID == v.ToString())
                    {
                        r.Product = p;

                    }
                }


            }
            listBox1.Items.Clear();
            AddRacks();
        }
    }
}

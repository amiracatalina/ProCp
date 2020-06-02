using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcP.UIelements
{
	public partial class ProductsSetup : Form
	{
		public Warehouse wh;
        public Rack thisRack;

		public ProductsSetup(Warehouse w, Rack r)
		{
			InitializeComponent();
			wh = w;
            thisRack = r;
            CBpossibleProds.DataSource = ProductList.possibleProducts;
            CBpossibleProds.DisplayMember = "FullName";
            if (thisRack.Product != null)
                lblCurrentProd.Text = thisRack.Product.Name;
            else lblCurrentProd.Text = "This rack is empty.";
		}

        private void btnFillRack_Click(object sender, EventArgs e)
        {
            try
            {
                thisRack.Product = CBpossibleProds.SelectedItem as Product;
                thisRack.DrawRack();
                
                this.Close();
            }
            catch (NullReferenceException ne)
            {
                MessageBox.Show(ne.ToString() + ", please choose a product from the list");
            }
        }
    }
}

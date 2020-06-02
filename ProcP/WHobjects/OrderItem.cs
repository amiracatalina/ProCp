using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcP
{
	public class OrderItem
	{
		public int ID { get; set; }
		public Product productItem { get; set; }
        public int Quantity { get; set; }

        public OrderItem(Product item, int q)
        {
            productItem = item;
            Quantity = q;
        }
	}
}

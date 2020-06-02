using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcP
{
    public static class ProductList
    {
        public static List<Product> possibleProducts;
        static ProductList()
        {
            possibleProducts = new List<Product>
            {
                new Product("Amira", ProductType.Chair),
                new Product("Denisa", ProductType.Table),
                new Product("Emese", ProductType.Bed),
                new Product("Iana", ProductType.Cabinet),
                new Product("Bogdan", ProductType.Chair),
                new Product("Leo", ProductType.Table)
            };
        }
        
    }

    public enum ProductType
    {
        Chair, Table, Bed, Cabinet
    }

	public class Product
	{
		public int ID { get; set; }
		public int Size { get; set; }
		public int Weight { get; set; }
		public int Quantity { get; set; }
		public ProductType Type { get; set; }
		public string Name { get; set; }
		public string RackID { get; set; }
		public string LineID { get; set; }
        public string FullName {
            get {
                return Name + " (" + Type + ")";
            }
        }

        public Product(string name, ProductType pt)
        {
            Name = name;
            Type = pt;
        }

        public Product(string name, int q)
        {
            Name = name;
			Quantity = q; 
        }





	}
}

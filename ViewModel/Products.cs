using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspIndAssignment1.ViewModel
{
    public class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDetail { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

        public Products(int productID, string productName, float price,string productDetail)
        {
            ProductID = productID;
            ProductName = productName;
            ProductDetail = productDetail;
            Price = price; 
        }
        public Products(string name, int qty)
        {
            ProductName = name;
            Quantity = qty;
        }
        public Products() { }
    }
}
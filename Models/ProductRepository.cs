using System;
using AspIndAssignment1.ViewModel;

using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspIndAssignment1.ViewModel
{
     public class ProductRepository
    {
        public ProductRepository() { 
        }
        public List<Products> GetAllProducts() {
            List<Products> products = new List<Products>();
            products.Add(new Products("Gloves", 4));
            products.Add(new Products("Light", 1));
            return products;
        }
    }
}
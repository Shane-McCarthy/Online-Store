using System;
using AspIndAssignment1.ViewModel; 
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspIndAssignment1.Models
{
    public class AllProductRepository
    {
        public IEnumerable<Product> AllProduct()
        {
            store_sEntities3 context = new store_sEntities3();
            Product productDetails = new Product();
            IEnumerable<Product> product = context.Products;


            return product;
        }


        
        public Product AProduct(int productID)
        {
            store_sEntities3 context = new store_sEntities3();
           
            Product product = (from p in context.Products
                               where p.productID == productID
                               select p).FirstOrDefault(); 


            return product;
        }
    }

}
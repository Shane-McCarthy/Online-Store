using AspIndAssignment1.ViewModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspIndAssignment1.Models
{
    public class CartRepository
    {
        public CartRepository()
        {
        }
        public Cart GetCart()
        {
            Cart myCart = new Cart();
            ProductRepository productRepo = new ProductRepository();
            myCart.products = productRepo.GetAllProducts();
            myCart.SessionID = "asdfafasfasdfklj";
            return myCart;
        }
    }
}
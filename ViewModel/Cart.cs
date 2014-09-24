using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspIndAssignment1.ViewModel
{
    public class Cart
    {
        public string SessionID { get; set; }
        public List<Products> products { get; set; }

        public Cart()
        {
        }
    }
}
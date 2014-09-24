using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspIndAssignment1.ViewModel;
using AspIndAssignment1.Models;
using AspIndAssignment1.BusinessLogic; 


namespace AspIndAssignment1.Controllers
{
    public class HomeController : Controller
    {
        private store_sEntities3 db = new store_sEntities3(); 
        //
        // GET: /Home/

        public ActionResult Index()
        {
           
            AllProductRepository allproductrepository = new AllProductRepository();
            return View(allproductrepository.AllProduct());

        }
       [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Add(int productID) {
            AllProductRepository cartadd = new AllProductRepository();
            
            return View(cartadd.AProduct(productID));
        }

       public ActionResult ThankYou()
       {
          

           return View();
       }
       public ActionResult ViewCart()
       {


           return View();
       }

       [HttpGet]
       public ActionResult Email()
       {
           return View();
       }


       [HttpPost]
       public ActionResult Email(Email message)
       {
           EmailHelper emailRepo = new EmailHelper();
           string result = emailRepo.SendMessage(message);
           return RedirectToAction("Result", new { mailResult = result });
       }

       public ActionResult Result(string mailResult)
       {
           ViewBag.EmailResult = mailResult;
           return View();
       }
       //[HttpPost]
       //public ActionResult SetCookie(string txtName)
       //{
       //    CookieHelper cookieHelper = new CookieHelper();
       //    cookieHelper.SetUserName(txtName);
       //    return RedirectToAction("Index");
       //}

       //public ActionResult ClearCookie()
       //{
       //    CookieHelper cookieHelper = new CookieHelper();
       //    cookieHelper.ClearCookie();
       //    return RedirectToAction("Index");
       //}

      


    }
}

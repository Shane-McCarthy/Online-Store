using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspIndAssignment1.BusinessLogic
{
    public class CookieHelper
    {
        const string USER_NAME = "UserName";

        public void ClearCookie()
        {
            if (HttpContext.Current.Request.Cookies[USER_NAME] != null)
            {
                HttpCookie cookie = HttpContext.Current.Request.Cookies[USER_NAME];

                // Can't delete cookie so set expiry to past to clear it.
                cookie.Expires = DateTime.Now.AddDays(-1);

                // Send updated cookie back to client.
                HttpContext.Current.Response.SetCookie(cookie);
            }
        }
        public string GetUserName()
        {
            if (HttpContext.Current.Request.Cookies[USER_NAME] != null)
            {
                // Get cookie value if it exists.
                HttpCookie cookie = HttpContext.Current.Request.Cookies[USER_NAME];
                return cookie.Value;
            }
            return null;
        }
        public void SetUserName(string userName)
        {
            // Create a cookie.
            HttpCookie cookie = new HttpCookie(USER_NAME);

            // Store a value in the cookie and set it.
            cookie.Value = userName;
            cookie.Expires = DateTime.Now.AddYears(50);

            // Send cookie back to client.
            HttpContext.Current.Response.SetCookie(cookie);

        }
    }
}

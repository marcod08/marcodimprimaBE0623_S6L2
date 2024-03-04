using S6L1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace S6L1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Author author) 
        {
            var hasValidCredentials = false;

            // qui inserire la logica per controllare username e pass nel database
            hasValidCredentials = true;

            if (hasValidCredentials)
            {
                FormsAuthentication.SetAuthCookie(author.AuthorId.ToString(), true);
                return RedirectToAction("", ""); // collegamento alla pagina del pannello
            }
            return RedirectToAction("Index");

        }
        [Authorize]
        public ActionResult Home()
        {
            return View();
        }
    }
}
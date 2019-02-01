using DataLayer.Model;
using DataLayer.Services;
using DataLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SurveySite.Controllers
{
    public class AccountController : Controller
    {
        DatabaseRepo<Owner> ownerTable = new DatabaseRepo<Owner>();
        DatabaseRepo<Store> storeTable = new DatabaseRepo<Store>();
        // GET: Account
        [HttpPost]
        public JsonResult Signin(string username, string password, string rememberme)
        {
            if (ownerTable.FindRecord(item => item.Username == username && item.Password == password))
            {
                FormsAuthentication.SetAuthCookie(username, (rememberme == "on" ? true : false));
                //Session["Username"] = username;
                return Json(ownerTable.Read(item => item.Username == username), JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
        [Authorize]
        public ActionResult StoreProfile()
        {
            return View();
        }


    }
}
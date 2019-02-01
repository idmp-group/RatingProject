using DataLayer.Model;
using DataLayer.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace SurveySite.Controllers
{
    public class HomeController : Controller
    {
        DatabaseRepo<Owner> ownerTable = new DatabaseRepo<Owner>();
        DatabaseRepo<Store> StoreTable = new DatabaseRepo<Store>();
        DatabaseRepo<Category> CategoryTable = new DatabaseRepo<Category>();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        //public JsonResult DisplatAll()
        //{
        //    return Json();
        //}
        [HttpPost]
        public JsonResult CreateStoreOwner(Store storeRecord)
        {
            PersianCalendar ps = new PersianCalendar();
            //int rn = RandomNumber(1000, 2000);
            //if (!StoreTable.FindRecord(item => item.StoreCode == rn))
            //{
            //    storeRecord.StoreCode = rn;
            //}
            //else
            //{
            //    storeRecord.StoreCode = RandomNumber(1000, 2000);
            //}
            storeRecord.Date = ps.GetYear(DateTime.Now) + "/" + ps.GetMonth(DateTime.Now) + "/" + ps.GetDayOfMonth(DateTime.Now).ToString();
            //storeRecord.Owner.StoreCode = storeRecord.StoreCode;
            if (ModelState.IsValid)
            {
                StoreTable.Create(storeRecord);
                return Json(StoreTable.Save(), JsonRequestBehavior.AllowGet);
            }
            return Json(false, JsonRequestBehavior.AllowGet);
        }
        public JsonResult PopulateCategories()
        {
            var categories = CategoryTable.Read();
            return Json(categories, JsonRequestBehavior.AllowGet);
        }
        public ContentResult Search(string keyword, string category, string city)
        {
            var storeCode = Convert.ToInt32(keyword);
            if (StoreTable.FindRecord(item => item.Name == keyword||item.StoreCode== storeCode))
            {
                var list = JsonConvert.SerializeObject(StoreTable.Read(item => item.Name == keyword|| item.StoreCode== storeCode, "Images"),
                Formatting.None,
                new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                    });
                return Content(list, "application/json");
            }
            else
            {
                return Content("false", "application/json");
            }
        }
        public ActionResult AboutService()
        {
            return View();
        }
        public ActionResult ContactUs ()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        #region RandomPassword
        //public class RandomNumberGenerator
        //{
        // Generate a random number between two numbers    
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        // Generate a random string with a given size and case.   
        // If second parameter is true, the return string is lowercase  
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        public string RandomPassword(int size = 0)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }

        //}
        #endregion
    }
}
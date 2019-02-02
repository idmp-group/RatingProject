using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using Services;
using Models.DTO;
using System.Web.Http.Cors;
using Models;
using DataLayer.Model;
//using System.Web.Mvc;

namespace SurveySite.Controllers
{
    [EnableCors(origins: "http://localhost:3433/", headers: "*", methods: "*")]
    public class StoreController : ApiController
    {
        Services.DatabaseRepo<Store> StoreTable = new Services.DatabaseRepo<Store>();

        [HttpPost]
        public IHttpActionResult CreateStoreOwner(StoreDTO storeRecord)
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
            //storeRecord.Date = ps.GetYear(DateTime.Now) + "/" + ps.GetMonth(DateTime.Now) + "/" + ps.GetDayOfMonth(DateTime.Now).ToString();
            //storeRecord.Owner.StoreCode = storeRecord.StoreCode;
            //var code = new Random();
            Store store = new Store()
            {
                StoreCode = 123,
            Name = storeRecord.Name,
            Description = storeRecord.Description,
            Address = storeRecord.Address,
            Email = storeRecord.Email,
            Date = "10/02/98",
            Phonenumber = storeRecord.Phonenumber,
            Latitude = 10,
            Longitude = 10,
            CategoryCode = 1,
            Owner = storeRecord.Owner
        };
            StoreTable.Create(store);
            return Json(StoreTable.Save());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SurveySite.Controllers
{
    public class TestController : ApiController
    {

        [HttpGet]
        public bool Get()
        {
            return true;
        }

    }
}

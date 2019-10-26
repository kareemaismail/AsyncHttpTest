using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace WebApplication1
{
    public class TestController : ApiController
    {
        // GET api/<controller>
        public string Get()
        {
            return new MockDb().Save();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        [HttpGet]
        [Route("api/J3/Messaging/word")]

        public string Messaging(string word)
        {
            //calculate word length
            //after each letter takes 2 seconds of pause 
            //each press takes one second
            //
            return "Connected!";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        [HttpGet]
        [Route("api/J1/Menu/{no1}/{no2}/{no3}/{no4}")]
        public string Menu(int no1, int no2, int no3, int no4)
        {
            if (no1 < 1 || no1 > 4 || no2 < 1 || no2 > 4 || no3 < 1 || no3 > 4 || no4 < 1 || no4 > 4)
            {
                return "Please provide a proper input!";
            }
            int[] burger = { 461, 431, 420, 0 };
            int[] drink = { 130, 160, 118, 0 };
            int[] side = { 100, 57, 70, 0 };
            int[] dessert = { 167, 266, 75, 0 };
            int total = burger[no1 - 1] + drink[no2 - 1] + side[no3 - 1] + dessert[no4 - 1];
            string msg = "Your total calorie count is " + total.ToString();
            return msg;
        }
    }
}

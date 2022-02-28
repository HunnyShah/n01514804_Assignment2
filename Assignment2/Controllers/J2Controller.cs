using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        [HttpGet]
        [Route("api/J2/DiceGame/{dg1}/{dg2}")]
        public string DiceGame(int dg1, int dg2)
        {
            int n = 0;
            string msg;
            for (int i = 1; i <= dg1; i++)
            {
                for (int j = 1; j <= dg2; j++)
                {
                    int sum = i + j;
                    if (sum == 10)
                    {
                        n++;
                    }
                }
            }
            if (n == 1)
            {
                return msg = "There is " + n.ToString() + " way to get the sum 10.";
            }
            else
            {
                return msg = "There are " + n.ToString() + " ways to get the sum 10.";
            }
        }
    }
}

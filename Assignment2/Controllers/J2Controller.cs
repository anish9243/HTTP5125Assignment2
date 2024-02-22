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

        /// <summary>
        /// Counts the total ways to get the sum 10 with two dice of given sides.
        /// </summary>
        /// <param name="m">Number of sides on the first die.</param>
        /// <param name="n">Number of sides on the second die.</param>
        /// <returns>Total number of ways to get the sum 10.</returns>
        /// <example>
        /// GET Localhost:xx/api/J2/DiceGame/{m}/{n} -> "There are {count} total ways to get the sum 10."
        /// </example>

        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            int count = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i + j == 10)
                    {
                        count++;
                    }
                }
            }
            return "There are " + count + " total ways to get the sum 10.";
        }
    }
}



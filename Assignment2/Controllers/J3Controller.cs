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
        /// 2011 CCC J3: Sumac Sequences 
        /// <summary>
        /// Subtracts the first input (T1) from the second input (T2). That value becomes the
        /// the next input in the sequnce, will be subtracted from the previous number in the sequence. This loop will continue until
        /// until the last number in the sequnce is larger than the 2nd last.Then it will display the lenth of the number sequence.
        /// </summary>
        /// <param name="t1"></param> The input for the first number in the sequence
        /// <param name="t2"></param> The input for the second number in the sequence
        /// <returns>
        /// the lenth of the number sequence.
        /// </returns>
        /// <example>
        /// GET Localhost: xx/api/J3/numSequence/80/30 -> 3
        /// </example>

        [Route("api/J3/NumSequence/{T1}/{T2}")]
        [HttpGet]

        public int NumSequence(int t1 , int t2)
        {
            int count = 2; // Starting with two terms already
            while (t2 < t1)
            {
                int nextTerm = t1 - t2;
                t1 = t2;
                t2 = nextTerm;
                count++;
            }

            return count;

        }
    }
}

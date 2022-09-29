using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HTTP5112_Assignment_1.Controllers
{
    public class Assignment1Controller : Controller
    {
        /// <summary>
        /// Returns 10 more than the integer input
        /// </summary>
        /// <param name="id">The input number</param>
        /// <return>Returns 10 more than the integer input</return>
        /// <example>
        /// GET api/AddTen/21 -> 31
        /// GET api/AddTen/0 -> 10
        /// GET api/AddTen/-9 -> 1
        /// </example>
        [Route("api/AddTen/{id}")]
        [HttpGet("{id}")]
        public int AddTen(int id)
        {
            return id + 10;
        }

        /// <summary>
        /// Returns the square of the integer input
        /// </summary>
        /// <param name="id">The input number</param>
        /// <return>Returns the square of the integer input</return>
        /// <example>
        /// GET api/Square/2 -> 4
        /// GET api/Square/-2 -> 4
        /// GET api/Square/10 -> 100
        /// </example>
        [Route("api/Square/{id}")]
        [HttpGet("{id}")]
        public int Square(int id)
        {
            return id * id;
        }

        /// <summary>
        /// Returns the string "Hello World!"
        /// </summary>
        /// <param></param>
        /// <return>Returns the string "Hello World!"</return>
        /// <example>
        /// GET api/Greeting -> "Hello World!"
        /// </example>
        [Route("api/Greeting")]
        [HttpPost]
        public string Greeting()
        {
            return "Hello World!";
        }

        /// <summary>
        /// Returns the string "Greetings to {id} people!" where id is an integer value.
        /// </summary>
        /// <param name="id">The input number</param>
        /// <return>Returns the string "Greetings to {id} people!" where id is an integer value.</return>
        /// <example>
        /// GET api/Greeting/3 -> "Greetings to 3 people!"
        /// GET api/Greeting/6 -> "Greetings to 6 people!"
        /// GET api/Greeting/0 -> "Greetings to 0 people!"
        /// </example>
        [Route("api/Greeting/{id}")]
        [HttpGet("{id}")]
        public string Greeting(int id)
        {
            return "Greetings to " + id + " people!";
        }

        /// <summary>
        /// Returns zero for any integer input
        /// </summary>
        /// <param name="id">The input number</param>
        /// <return>Returns zero for any the integer input</return>
        /// <example>
        /// GET api/NumberMachine/10 -> "0"
        /// GET api/NumberMachine/-5 -> "0"
        /// GET api/NumberMachine/30 -> "0"
        /// </example>
        [Route("api/NumberMachine/{id}")]
        [HttpGet("{id}")]
        public double NumberMachine(int id)
        {
            return Math.Sqrt(id * id) * 2 % 2;
        }

        /// <summary>
        /// Calculates the hosting cost, tax and total hosting cost,
        /// where the hosting charges $5.50/FN and 13% HST.
        /// </summary>
        /// <param name="id">The input number</param>
        /// <return>Returns 3 strings which describe the total hosting cost</return>
        /// <example>
        /// GET api/HostingCost/0 -> [“1 fortnights at $5.50/FN = $5.50 CAD”,“HST 13% = $0.72 CAD”,“Total = $6.22 CAD”]
        /// GET api/HostingCost/14 -> [“2 fortnights at $5.50/FN = $11.00 CAD”,“HST 13% = $1.43 CAD”,“Total = $12.43 CAD”]
        /// GET api/HostingCost/15 -> [“2 fortnights at $5.50/FN = $11.00 CAD”,“HST 13% = $1.43 CAD”,“Total = $12.43 CAD”]
        /// GET api/HostingCost/21 -> [“2 fortnights at $5.50/FN = $11.00 CAD”,“HST 13% = $1.43 CAD”,“Total = $12.43 CAD”]
        /// GET api/HostingCost/28 -> [“3 fortnights at $5.50/FN = $16.50 CAD”,“HST 13% = $2.14 CAD”,“Total = $18.64 CAD”]
        /// </example>
        [Route("api/HostingCost/{id}")]
        [HttpGet("{id}")]
        public IEnumerable<string> HostingCost(int id)
        {
            const double fortnightCharge = 5.5;
            const double taxRate = 0.13;

            int numOfFortnight = id / 14 + 1;
            double hostingCost = numOfFortnight * fortnightCharge;
            double tax = Math.Round(hostingCost * taxRate, 2);
            double totalCost = hostingCost + tax;

            string firstStr = numOfFortnight + " fortnights at $" + fortnightCharge.ToString("0.00") + "/FN = $" + hostingCost.ToString("0.00") + " CAD";
            string secondStr = "HST 13% = $" + tax.ToString("0.00") + " CAD";
            string thirdStr = "Total = $" + totalCost.ToString("0.00") + " CAD";
            string[] outputStr = { firstStr, secondStr, thirdStr };

            return outputStr;
        }
    }
}
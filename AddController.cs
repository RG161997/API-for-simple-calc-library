using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Calculator.Controllers;
using Calculator.Models;

namespace Calculator.Controllers
{
    public class AddController : ApiController
    {
        [HttpGet]
        public decimal GetNumber([FromQuery] SimpleCalc simpleCalc)
        {
            decimal sum = simpleCalc.OperatorSwitch("Add", simpleCalc.number1, simpleCalc.number2);
            return sum;
        }
        [HttpPost]
        public decimal Add([FromForm]SimpleCalc simpleCalc)
        {
            decimal sum = simpleCalc.OperatorSwitch("Add", simpleCalc.number1, simpleCalc.number2);
            return sum;
        }
    }
}

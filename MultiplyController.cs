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
    public class MultiplyController : ApiController
    {
        [HttpGet]
        public decimal GetNumber([FromQuery] SimpleCalc simpleCalc)
        {
            decimal mul = simpleCalc.OperatorSwitch("Multiply", simpleCalc.number1, simpleCalc.number2);
            return mul;
        }
        [HttpPost]
        public decimal Mult([FromForm]SimpleCalc simpleCalc)
        {
            decimal mul = simpleCalc.OperatorSwitch("Multiply", simpleCalc.number1, simpleCalc.number2);
            return mul;
        }
    }
}

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
    public class SubController : ApiController
    {
        [HttpGet]
        public decimal GetNumber([FromQuery] SimpleCalc simpleCalc)
        {
            decimal sub = simpleCalc.OperatorSwitch("Subtract", simpleCalc.number1, simpleCalc.number2);
            return sum;
        }
        [HttpPost]
        public decimal Sub([FromForm]SimpleCalc simpleCalc)
        {
            decimal sub = simpleCalc.OperatorSwitch("Subtract", simpleCalc.number1, simpleCalc.number2);
            return sub;
        }
    }
}

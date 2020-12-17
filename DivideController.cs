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
    public class DivideController : ApiController
    {
        [HttpGet]
        public decimal GetNumber([FromQuery] SimpleCalc simpleCalc)
        {
            decimal div = simpleCalc.OperatorSwitch("Divide", simpleCalc.number1, simpleCalc.number2);
            return div;
        }
        [HttpPost]
        public decimal Div([FromForm]SimpleCalc simpleCalc)
        {
            decimal div = simpleCalc.OperatorSwitch("Divide", simpleCalc.number1, simpleCalc.number2);
            return div;
        }

    }
}

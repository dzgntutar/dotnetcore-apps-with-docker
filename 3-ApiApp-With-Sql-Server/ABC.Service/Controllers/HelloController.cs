using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ABC.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public Hello Get()
        {
            var hello = new Hello();
            hello.Message = "Hi";
            hello.Message2 = "How are you";
            return  hello;
        }
    }
}

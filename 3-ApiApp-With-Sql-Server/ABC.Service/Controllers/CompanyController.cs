using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABC.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ttar.DAL.Concrete;

namespace ABC.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : ControllerBase
    {
        public CompanyController()
        {
        }

        [HttpGet]
        public ActionResult<Company> Get()
        {
            return Ok("company");
        }
    }
}

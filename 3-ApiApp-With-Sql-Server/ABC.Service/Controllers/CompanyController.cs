using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABC.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ABC.Entity.Dto;

namespace ABC.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : ControllerBase
    {
        ICompanyManager companyManager;

        public CompanyController(ICompanyManager companyManager)
        {
            this.companyManager = companyManager;
        }

        [HttpGet]
        public ActionResult Get()
        {
            companyManager.AddCompany(new CompanyDto() { Name = "AA", Address = "BB" });
            return Ok("Company");
        }
    }
}

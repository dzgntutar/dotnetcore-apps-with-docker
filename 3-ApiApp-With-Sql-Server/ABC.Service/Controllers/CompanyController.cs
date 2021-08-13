using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABC.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ABC.Entity.Dto;

namespace ABC.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : ControllerBase
    {
        ICompanyService companyManager;

        public CompanyController(ICompanyService companyManager)
        {
            this.companyManager = companyManager;
        }

        [HttpGet]
        public ActionResult Get(CompanyDto companyDto)
        {
            var company = companyManager.AddCompany(companyDto);
            return Created("www", companyDto);
        }
        [HttpGet]
        public ActionResult Get(int id)
        {
            return null;
        }

        [HttpPost]
        public ActionResult Post(CompanyDto company)
        {
            return Created("","abc");
        }

        [HttpPut]
        public ActionResult Update(CompanyDto company)
        {
            return NoContent();
        }

    }
}

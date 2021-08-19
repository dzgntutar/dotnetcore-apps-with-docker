using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABC.Core.Service;
using ABC.Entity.Concrete;
using ABC.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ABC.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompaniesController : ControllerBase
    {
        IService<Company> service;

        public CompaniesController(ICompanyService companyService)
        {
            this.service = companyService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(service.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var company = service.GetSingle(id);
            if (company == null)
                return NotFound();
            else
                return Ok(company);
        }

        [HttpPost]
        public ActionResult Post(Company company)
        {
            service.Add(company);
            return Created("www", company);
        }

        [HttpPut]
        public ActionResult Update(Company company)
        {
            try
            {
                service.Update(company);
                return Ok(company);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public ActionResult Delete(Company company )
        {
            try
            {
                service.Delete(company);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}

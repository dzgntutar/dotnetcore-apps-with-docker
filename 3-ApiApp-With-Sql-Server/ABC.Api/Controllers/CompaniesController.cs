using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABC.Core.Service;
using ABC.Entity.Dto;
using ABC.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ABC.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompaniesController : ControllerBase
    {
        IService<CompanyDto> service;

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
        public ActionResult Post(CompanyDto company)
        {
            var addedCompany = service.Add(company);
            return Created("www", addedCompany);
        }

        [HttpPut]
        public ActionResult Update(CompanyDto company)
        {
            try
            {
                var companyUpdate = service.Update(company);


                return Ok(companyUpdate);
            }
            catch (Exception)
            {
                return BadRequest();
            }
            
        }

        [HttpDelete]
        public ActionResult Delete(CompanyDto company )
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

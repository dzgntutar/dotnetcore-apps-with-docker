﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        ICompanyService companyService;

        public CompaniesController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(companyService.GetAllCompany());
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var company = companyService.GetSingleCompany(id);
            if (company == null)
                return NotFound();
            else
                return Ok(company);
        }

        [HttpPost]
        public ActionResult Post(CompanyDto company)
        {
            var addedCompany = companyService.AddCompany(company);
            return Created("www", addedCompany);
        }

        [HttpPut]
        public ActionResult Update(CompanyDto company)
        {
            try
            {
                var companyUpdate = companyService.UpdateCompany(company);


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
                companyService.DeleteCompany(company);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}

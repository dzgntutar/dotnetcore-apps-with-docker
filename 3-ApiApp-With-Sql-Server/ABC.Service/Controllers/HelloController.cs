using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABC.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ttar.DAL.Concrete;

namespace ABC.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        private readonly EfContext _dbContext;
        public HelloController(EfContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<Company>> Get()
        {
            Company company = new();
            //company.Id = 1;
            company.Name = "selam";
            _dbContext.Companies.Add(company);
            _dbContext.SaveChanges();

            return  Ok(company);
        }
    }
}

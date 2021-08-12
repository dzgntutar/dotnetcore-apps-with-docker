using ABC.Core.DAL.EntityFramework;
using ABC.DAL.Abstract;
using ABC.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ttar.DAL.Concrete;

namespace ABC.DAL.EF.Concrete
{
    public  class CompanyDal : EfRepository<Company,EfContext>
    {
    }
}

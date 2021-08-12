using ABC.Core.DAL;
using ABC.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.DAL.Abstract
{
    public interface ICompanyDal : IRepository<Company>
    {
    }
}

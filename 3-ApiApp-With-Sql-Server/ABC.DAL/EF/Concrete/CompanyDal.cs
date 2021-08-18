using ABC.Core.DAL.EntityFramework;
using ABC.DAL.Abstract;
using ABC.Entity.Concrete;
using Ttar.DAL.Concrete;

namespace ABC.DAL.EF.Concrete
{
    public  class CompanyDal : EfRepository<Company,EfContext>,ICompanyDal
    {
        
    }
}

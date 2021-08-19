using ABC.Core.DAL;
using ABC.DAL.Abstract;
using ABC.Entity.Concrete;
using Ttar.DAL.Concrete;

namespace ABC.DAL.Concrete
{
    public  class CompanyDal : Repository<Company,DbContext>,ICompanyDal
    {
        
    }
}

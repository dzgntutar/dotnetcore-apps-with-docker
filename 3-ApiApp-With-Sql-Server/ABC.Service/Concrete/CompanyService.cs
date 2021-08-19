using System.Collections.Generic;
using ABC.DAL.Abstract;
using ABC.Entity.Concrete;
using ABC.Service.Abstract;
using System.Linq;
using ABC.Core.Service;


namespace ABC.Service.Concrete
{
    public class CompanyService : IService<Company>, ICompanyService
    {
        ICompanyDal companyDal;

        public CompanyService(ICompanyDal _companyDal)
        {
            companyDal = _companyDal;
        }

        public Company Add(Company entity)
        {
            return companyDal.Add(entity);
        }

        public void Delete(Company entity)
        {
            companyDal.Delete(entity);
        }

        public List<Company> GetAll()
        {
            return companyDal.GetList();
        }

        public Company GetSingle(int id)
        {
            return companyDal.Get(x => x.Id == id);
        }

        public Company Update(Company company)
        {
            return companyDal.Update(company);
        }
    }
}

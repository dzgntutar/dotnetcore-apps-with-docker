using ABC.Business.Abstract;
using ABC.Entity.Dto;
using System.Collections.Generic;
using ABC.DAL.Abstract;
using ABC.Entity.Concrete;

namespace ABC.Business.Concrete
{
    public class CompanyManager : ICompanyManager
    {
        ICompanyDal companyDal;

        public CompanyManager(ICompanyDal _companyDal)
        {
            companyDal = _companyDal;
        }

        public CompanyDto AddCompany(CompanyDto company)
        {
            Company newCompany = new Company { Name = company.Name, Address = company.Address };
            var addedCompany = companyDal.Add(newCompany);

            return new CompanyDto() { Id = addedCompany.Id };
        }

        public bool DeleteCompany(CompanyDto company)
        {
            throw new System.NotImplementedException();
        }

        public List<CompanyDto> GetAllCompany()
        {
            throw new System.NotImplementedException();
        }

        public CompanyDto GetSingleCompany(int id)
        {
            throw new System.NotImplementedException();
        }

        public CompanyDto UpdateCompany(CompanyDto company)
        {
            throw new System.NotImplementedException();
        }
    }
}

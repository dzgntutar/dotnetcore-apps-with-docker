using ABC.Entity.Dto;
using System.Collections.Generic;
using ABC.DAL.Abstract;
using ABC.Entity.Concrete;
using ABC.Service.Abstract;
using System.Linq;
using ABC.Core.Service;


namespace ABC.Service.Concrete
{
    public class CompanyService : IService<CompanyDto>, ICompanyService
    {
        ICompanyDal companyDal;

        public CompanyService(ICompanyDal _companyDal)
        {
            companyDal = _companyDal;
        }

        public CompanyDto Add(CompanyDto entity)
        {
            Company newCompany = new Company { Name = entity.Name, Address = entity.Address };
            var addedCompany = companyDal.Add(newCompany);

            return new CompanyDto() { Id = addedCompany.Id };
        }

        public void Delete(CompanyDto entity)
        {
            companyDal.Delete(new Company { Id = entity.Id, Name = entity.Name, Address = entity.Address });
        }

        public List<CompanyDto> GetAll()
        {
            var companies = companyDal.GetList();
            return companies.Select(x => new CompanyDto
            {
                Id = x.Id,
                Name = x.Name,
                Address = x.Address
            }).ToList();
        }

        public CompanyDto GetSingle(int id)
        {
            var company = companyDal.Get(x => x.Id == id);
            if (company == null)
                return null;
            return new CompanyDto() { Id = company.Id, Name = company.Name, Address = company.Address };
        }

        public CompanyDto Update(CompanyDto company)
        {
            var updatedCompany = companyDal.Update(new Company { Id = company.Id, Name = company.Name, Address = company.Address });

            return new CompanyDto
            {
                Id = updatedCompany.Id,
                Name = updatedCompany.Name,
                Address = updatedCompany.Address
            };
        }

    }

}

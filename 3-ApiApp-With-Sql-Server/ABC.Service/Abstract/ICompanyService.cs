using System;
using System.Collections.Generic;
using ABC.Entity.Dto;

namespace ABC.Service.Abstract
{
    public interface ICompanyService
    {
        List<CompanyDto> GetAllCompany();

        void DeleteCompany(CompanyDto company);

        CompanyDto AddCompany(CompanyDto company);

        CompanyDto GetSingleCompany(int id);

        CompanyDto UpdateCompany(CompanyDto company);
    }
}

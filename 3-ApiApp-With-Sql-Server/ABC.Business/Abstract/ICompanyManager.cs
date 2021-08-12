using System;
using System.Collections.Generic;
using ABC.Entity.Dto;

namespace ABC.Business.Abstract
{
    public interface ICompanyManager
    {
        List<CompanyDto> GetAllCompany();

        bool DeleteCompany(CompanyDto company);

        CompanyDto AddCompany(CompanyDto company);

        CompanyDto GetSingleCompany(int id);

        CompanyDto UpdateCompany(CompanyDto company);
    }
}

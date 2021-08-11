using System;
using System.Collections.Generic;
using ABC.Entity.Dto;

namespace ABC.Business.Abstract
{
    public interface ICompanyManager
    {
        List<CompanyDto> GetAllCategory();

        bool DeleteCategory(CompanyDto category);

        CompanyDto AddCategory(CompanyDto category);

        CompanyDto GetSingleCategory(int id);

        CompanyDto UpdateCategory(CompanyDto category);
    }
}

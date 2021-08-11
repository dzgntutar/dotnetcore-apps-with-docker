using ABC.Business.Abstract;
using ABC.Entity.Dto;
using System.Collections.Generic;

namespace ABC.Business.Concrete
{
    public class CompanyManager : ICompanyManager
    {
        public CompanyDto AddCategory(CompanyDto category)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteCategory(CompanyDto category)
        {
            throw new System.NotImplementedException();
        }

        public List<CompanyDto> GetAllCategory()
        {
            throw new System.NotImplementedException();
        }

        public CompanyDto GetSingleCategory(int id)
        {
            throw new System.NotImplementedException();
        }

        public CompanyDto UpdateCategory(CompanyDto category)
        {
            throw new System.NotImplementedException();
        }
    }
}

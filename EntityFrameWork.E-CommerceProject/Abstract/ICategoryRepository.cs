using Domain.ECommerceProject.Data.Categorys;
using EntityFrameWork.E_CommerceProject.InfrastructureBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.E_CommerceProject.Abstract
{
    public interface ICategoryRepository:IGenericRepositoryAsync<Category>
    {
         public Task<List<Category>> GetCategoryListAsync();
 
    }
}

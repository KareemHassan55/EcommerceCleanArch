using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.ECommerceProject.Data.Categorys;

namespace ApplicationService.E_CommerceProject.Abstract
{
    public interface ICategoryAppservice
    {
        public Task<List<Category>> GetCategoryListAsync();
        public Task<Category> GetCategoryBYIDAsync(int id);
        public Task<string> CreateAsync(Category category);
        public Task<string> EditAsync(Category category);
        public Task<string> DeleteAsync(Category student);

    }
}

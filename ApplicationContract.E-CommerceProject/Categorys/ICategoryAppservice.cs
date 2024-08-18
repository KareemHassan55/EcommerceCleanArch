using Domain.ECommerceProject.Categorys;
using Domain.ECommerceProject.Data.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationContract.E_CommerceProject.Categorys
{
    public interface ICategoryAppservice
    {
        //Task <List<CategoryDto>> GetListAsync(GetCategoryInput input);

        //Task<CategoryDto> GetAsync(int id);

        //Task DeleteAsync(int id);

        //Task<CategoryDto> CreateAsync(CategoryDto input);

        //Task<CategoryDto> UpdateAsync(int id, CategoryDto input);
        public Task<List<Category>> GetStudentsListAsync();
        public Task<Category> GetStudentByIDWithIncludeAsync(int id);
        public Task<Category> GetByIDAsync(int id);
        public Task<string> AddAsync(Category category);
        public Task<bool> IsNameArExist(string nameAr);
        public Task<bool> IsNameEnExist(string nameEn);
        public Task<bool> IsNameArExistExcludeSelf(string nameAr, int id);
        public Task<bool> IsNameEnExistExcludeSelf(string nameEn, int id);
        public Task<string> EditAsync(Category category);
        public Task<string> DeleteAsync(Category category);
        public IQueryable<Category> GetStudentsQuerable();
        public IQueryable<Category> GetStudentsByDepartmentIDQuerable(int DID);
     }
}

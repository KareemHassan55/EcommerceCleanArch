using ApplicationService.E_CommerceProject.Abstract;
using Domain.ECommerceProject.Data.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameWork.E_CommerceProject.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace ApplicationService.E_CommerceProject.Implementation
{
    public class CategoryAppservice : ICategoryAppservice
    {
        #region Fields
        private readonly ICategoryRepository _categoryRepository;
        #endregion
        #region Constructor
        public CategoryAppservice(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        #endregion

        #region Handle Function
        public async Task<List<Category>> GetCategoryListAsync()
        {
            return await _categoryRepository.GetCategoryListAsync();
        }


        public async Task<Category> GetCategoryBYIDAsync(int id)
        {
            var category = await _categoryRepository.GetTableNoTracking()
                                                     .Where(x => x.Id == id)
                                                     .FirstOrDefaultAsync();
            return category;
        }


        public async Task<string> CreateAsync(Category category)
        {
            //Check if name exist or not
            
            var checkCategory = _categoryRepository.GetTableNoTracking().Where(x => x.Name == category.Name).FirstOrDefault();
            if (checkCategory == null)
                goto Add;   
            if (category.Name == null || category.Name == checkCategory.Name)
            {
                return "The name already Exist";
            }
             Add:
            await _categoryRepository.AddAsync(category);
            return "Success";

            

        }

        public async Task<string> EditAsync(Category category)
        {
            await _categoryRepository.UpdateAsync(category);
            return "Success Editing";
        }

        public async Task<string> DeleteAsync(Category student)
        {
            var trans = _categoryRepository.BeginTransaction();
            try
            {
                await _categoryRepository.DeleteAsync(student);
                await trans.CommitAsync();
                return "Success";
            }
            catch (Exception ex)
            {
                await trans.RollbackAsync();
                 return "Falied";
            }
        }

        #endregion

    }
}

using Domain.ECommerceProject.Data.Categorys;
using EntityFrameWork.E_CommerceProject.Abstract;
using EntityFrameWork.E_CommerceProject.DbContextECommerceProject;
using EntityFrameWork.E_CommerceProject.InfrastructureBases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.E_CommerceProject.Repository
{
    public class CategoryRepository : GenericRepositoryAsync<Category>, ICategoryRepository
    {
        #region Fields
        private readonly DbSet<Category> _categories;
        #endregion

        #region Constractor

        public CategoryRepository(ApplicationDbContext dbContext):base (dbContext)
        {
            _categories = dbContext.Set<Category>();
        }
        #endregion

        #region Handle Function 

        public async Task<List<Category>> GetCategoryListAsync()
        {
            return await _categories.ToListAsync();
        }
        
        #endregion

    }
}

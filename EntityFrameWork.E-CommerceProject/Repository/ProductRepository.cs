using Domain.ECommerceProject.Data.Categorys;
using Domain.ECommerceProject.Data.Products;
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
    public class ProductRepository : GenericRepositoryAsync<Product>, IProductRepository
    {
        #region Fields
        private readonly DbSet<Product> _products;
        #endregion

        #region Constractor

        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _products = dbContext.Set<Product>();
        }
        #endregion

        #region Handle Function 

        public async Task<List<Product>> GetProductListAsync()
        {
            return await _products.Include(x => x.Category).ToListAsync();
         }

        #endregion
    }
}

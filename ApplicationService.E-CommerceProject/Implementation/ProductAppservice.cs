using ApplicationService.E_CommerceProject.Abstract;
using Domain.ECommerceProject.Data.Categorys;
using Domain.ECommerceProject.Data.Products;
using EntityFrameWork.E_CommerceProject.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.E_CommerceProject.Implementation
{
    public class ProductAppservice : IProductAppservice
    {
        #region Fields
        private readonly IProductRepository _productRepository;
        #endregion
        #region Constructor
        public ProductAppservice(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        #endregion

        #region Handle Function
        public async Task<List<Product>> GetProductListAsync()
        {
            return await _productRepository.GetProductListAsync();
        }


        public async Task<Product> GetProductBYIDAsync(int id)
        {
            var product = await _productRepository.GetTableNoTracking()
                                                     .Where(x => x.Id == id)
                                                     .FirstOrDefaultAsync();
            return product;
        }


        public async Task<string> CreateAsync(Product product)
        {
            //Check if name exist or not

            var checkCategory = _productRepository.GetTableNoTracking().Where(x => x.Name == product.Name).FirstOrDefault();
            if (checkCategory == null)
                goto Add;
            if (product.Name == null || product.Name == checkCategory.Name)
            {
                return "The name already Exist";
            }
        Add:
            await _productRepository.AddAsync(product);
            return "Success";



        }

        public async Task<string> EditAsync(Product product)
        {
            await _productRepository.UpdateAsync(product);
            return "Success Editing";
        }

        public async Task<string> DeleteAsync(Product product)
        {
            var trans = _productRepository.BeginTransaction();
            try
            {
                await _productRepository.DeleteAsync(product);
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

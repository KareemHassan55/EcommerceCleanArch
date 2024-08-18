using Domain.ECommerceProject.Data.Categorys;
using Domain.ECommerceProject.Data.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.E_CommerceProject.Abstract
{
    public interface IProductAppservice
    {
        public Task<List<Product>> GetProductListAsync();
        public Task<Product> GetProductBYIDAsync(int id);
        public Task<string> CreateAsync(Product product);
        public Task<string> EditAsync(Product product);
        public Task<string> DeleteAsync(Product product);
    }
}

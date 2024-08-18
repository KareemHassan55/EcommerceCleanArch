using ApplicationContract.E_CommerceProject.Categorys;
using Domain.ECommerceProject.Categorys;
using Domain.ECommerceProject.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationContract.E_CommerceProject.Products
{
    public interface IProduct
    {
        Task<List<ProductDto>> GetListAsync(GetProductInput input);

        Task<ProductDto> GetAsync(int id);

        Task DeleteAsync(int id);

        Task<ProductDto> CreateAsync(ProductDto input);

        Task<ProductDto> UpdateAsync(int id, ProductDto input);
    }
}

 using ApplicationContract.E_CommerceProject.Products;
 using Domain.ECommerceProject.Products;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Controller.E_CommerceProject.Products
{
    [ApiController]
    [Route("api/[Product]")]
    public class ProductController : ControllerBase, IProduct
    {
        private readonly IProduct _product;
        public ProductController(IProduct product)
        {
            _product = product;
        }
        [HttpPost]
        public Task<ProductDto> CreateAsync(ProductDto input)
        {
            return _product.CreateAsync(input);
        }
        [HttpDelete]
        [Route("{id}")]
        public Task DeleteAsync(int id)
        {
            return _product.DeleteAsync(id);
        }
        [HttpGet]
        [Route("{id}")]
        public Task<ProductDto> GetAsync(int id)
        {
            return _product.GetAsync(id);
        }
        [HttpGet]
        public Task<List<ProductDto>> GetListAsync(GetProductInput input)
        {
            return _product.GetListAsync(input);
        }
        [HttpPut]
        [Route("{id}")]
        public Task<ProductDto> UpdateAsync(int id, ProductDto input)
        {
            return _product.UpdateAsync(id, input);
        }
    }
}

using ApplicationContract.E_CommerceProject.Categorys;
using Domain.ECommerceProject.Categorys;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Controller.E_CommerceProject.Categorys
{
     [Route("api/[Category]")]
    [ApiController]
    public class CategoryController : ControllerBase, ICategory
    {
        private readonly ICategory _category;
        public CategoryController(ICategory category)
        {
             _category = category;
        }
        [HttpPost]
        [Route("Create")]

        public Task<CategoryDto> CreateAsync(CategoryDto input)
        {
            return _category.CreateAsync(input);
        }
        [HttpDelete]
        [Route("{id}")]
        public Task DeleteAsync(int id)
        {
            return _category.DeleteAsync(id);
        }
        [HttpGet]
        [Route("{id}")]
        public Task<CategoryDto> GetAsync(int id)
        {
            return _category.GetAsync(id);
        }
        [HttpGet]
        [Route("GetListAsync")]

        public Task<List<CategoryDto>> GetListAsync(GetCategoryInput input)
        {
            return _category.GetListAsync(input);
        }
        [HttpPut]
        [Route("{id}")]
        public Task<CategoryDto> UpdateAsync(int id, CategoryDto input)
        {
            return _category.UpdateAsync(id, input);
        }
    }
}

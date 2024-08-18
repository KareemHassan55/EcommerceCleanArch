using ApplicationService.E_CommerceProject.Abstract;
using EcommerceProject.Core.Features.Categorys.Commands.Models;
using EcommerceProject.Core.Features.Categorys.Queries.Models;
using ECommerceProject.Data.AppMetaData;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
     [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ICategoryAppservice _categoryAppservice;
        public CategoriesController(IMediator mediator, ICategoryAppservice categoryAppservice)
        {
            _mediator = mediator;
            _categoryAppservice = categoryAppservice;
        }
        [HttpGet(Router.CategoryRouting.List)]
        public async Task<IActionResult> GetCategoryList() 
        {
            var response =await _mediator.Send(new GetCategoryListQuery());
            return Ok(response);
        }
        [HttpGet(Router.CategoryRouting.GetByID)]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var response = await _mediator.Send(new GetCategoryByIdQuery() { Id=id});
             if (response == null)
            {
                return NotFound(); 
            }
            return Ok(response);
        }

        [HttpPost(Router.CategoryRouting.Create)]
        public async Task<IActionResult> Create(AddCategoryCommand command)
        {
            var response = await _mediator.Send(command);
           
            return Ok(response);
        }

        [HttpPut(Router.CategoryRouting.Edit)]
        public async Task<IActionResult> Edit(EditCategoryCommand command)
        {
            var response = await _mediator.Send(command);

            return Ok(response);
        }
         [HttpDelete(Router.CategoryRouting.Delete)]
        public async Task<IActionResult> Delete(int id)
        {
            var isDeleted = await _mediator.Send(new DeleteCategoryCommand { Id = id });

           
                return Ok("Category deleted successfully.");
            
          
        }
    }
}

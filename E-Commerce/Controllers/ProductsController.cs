using ApplicationService.E_CommerceProject.Abstract;
using EcommerceProject.Core.Features.Products.Commands.Models;
using EcommerceProject.Core.Features.Products.Queries.Models;
using ECommerceProject.Data.AppMetaData;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
     [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IProductAppservice _productAppservice;
        public ProductsController(IMediator mediator, IProductAppservice productAppservice)
        {
            _mediator = mediator;
            _productAppservice = productAppservice;
        }

        [HttpGet(Router.ProductRouting.List)]
        public async Task<IActionResult> GetProductList()
        {
            var response = await _mediator.Send(new GetProductListQuery());
            return Ok(response);
        }
        [HttpGet(Router.ProductRouting.GetByID)]
        public async Task<IActionResult> GetProductById(int id)
        {
            var response = await _mediator.Send(new GetProductByIdQuery() { Id = id });
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpPost(Router.ProductRouting.Create)]
        public async Task<IActionResult> Create(AddProductCommand command)
        {
            var response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpPut(Router.ProductRouting.Edit)]
        public async Task<IActionResult> Edit(EditProductCommand command)
        {
            var response = await _mediator.Send(command);

            return Ok(response);
        }
        [HttpDelete(Router.ProductRouting.Delete)]
        public async Task<IActionResult> Delete(int id)
        {
            var isDeleted = await _mediator.Send(new DeleteProductCommand { Id = id });


            return Ok("Product deleted successfully.");


        }
    }
}

using ApplicationService.E_CommerceProject.Abstract;
using AutoMapper;
 using Domain.ECommerceProject.Data.Products;
 using EcommerceProject.Core.Features.Products.Commands.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Core.Features.Products.Commands.Handlers
{
    public class ProductCommandHandler : IRequestHandler<AddProductCommand, string>,
                                          IRequestHandler<EditProductCommand, string>,
                                          IRequestHandler<DeleteProductCommand, string>
    {
        #region Fields
        private readonly IProductAppservice _productAppservice;
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public ProductCommandHandler(IProductAppservice productAppservice, IMapper mapper)
        {
            _productAppservice = productAppservice;
            _mapper = mapper;
        }
        #endregion
        #region Handle Function
        public async Task<string> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var categoryMap = _mapper.Map<Product>(request);
            var result = await _productAppservice.CreateAsync(categoryMap);
            if (result == "Its Already Exist") return "It's Exixst Change the Name";
            else if (result == "Success") return "Added Sucessfully";
            else return "Please Try Again";

        }

        public async Task<string> Handle(EditProductCommand request, CancellationToken cancellationToken)
        {
            var category = _productAppservice.GetProductBYIDAsync(request.Id);
            if (category == null) return "Product Not Exist";

            var categoryMap = _mapper.Map<Product>(request);
            var result = await _productAppservice.EditAsync(categoryMap);
            return result;

        }

        public async Task<string> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            //Check if the Id is Exist Or not
            var student = await _productAppservice.GetProductBYIDAsync(request.Id);
            //return NotFound
            if (student == null) return "Not Found Object";
            //Call service that make Delete
            var result = await _productAppservice.DeleteAsync(student);
            if (result == "Success") return "Success Dleletd";
            else return "Bad Request";
        }
        #endregion
    }
}

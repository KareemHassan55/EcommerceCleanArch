using ApplicationService.E_CommerceProject.Abstract;
using AutoMapper;
using Domain.ECommerceProject.Data.Categorys;
using EcommerceProject.Core.Features.Categorys.Commands.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Core.Features.Categorys.Commands.Handlers
{
    public class CategoryCommandHandler : IRequestHandler<AddCategoryCommand, string>,
                                          IRequestHandler<EditCategoryCommand, string>,
                                          IRequestHandler<DeleteCategoryCommand, string>
    {
        #region Fields
        private readonly ICategoryAppservice _categoryAppservice;
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public CategoryCommandHandler(ICategoryAppservice categoryAppservice, IMapper mapper)
        {
            _categoryAppservice = categoryAppservice;
            _mapper = mapper;
        }
        #endregion
        #region Handle Function
        public async Task<string> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            var categoryMap = _mapper.Map<Category>(request);
            var result = await _categoryAppservice.CreateAsync(categoryMap);
            if (result == "Its Already Exist") return "It's Exixst Change the Name";
            else if (result == "Success") return "Added Sucessfully";
            else return "Please Try Again";
             
        }

        public async Task<string> Handle(EditCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = _categoryAppservice.GetCategoryBYIDAsync(request.Id);
            if (category == null) return "Category Not Exist";
            
              var categoryMap = _mapper.Map<Category>(request);
                var result = await _categoryAppservice.EditAsync(categoryMap);
            return result;

        }

        public async Task<string> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            //Check if the Id is Exist Or not
            var student = await _categoryAppservice.GetCategoryBYIDAsync(request.Id);
            //return NotFound
            if (student == null) return "Not Found Object";
            //Call service that make Delete
            var result = await _categoryAppservice.DeleteAsync(student);
            if (result == "Success") return "Success Dleletd";
            else return "Bad Request";
        }
        #endregion

    }
}

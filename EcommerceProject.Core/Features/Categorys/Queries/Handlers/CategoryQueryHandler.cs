using ApplicationService.E_CommerceProject.Abstract;
using AutoMapper;
using Domain.ECommerceProject.Data.Categorys;
using EcommerceProject.Core.Bases;
using EcommerceProject.Core.Features.Categorys.Queries.Models;
using EcommerceProject.Core.Features.Categorys.Queries.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace EcommerceProject.Core.Features.Categorys.Queries.Handlers
{
    public class CategoryQueryHandler : 
                                        IRequestHandler<GetCategoryListQuery, List<GetCategoryListResponse>>,
                                        IRequestHandler<GetCategoryByIdQuery,GetSingleCategoryResponse>
    {

        #region Fields
        private readonly ICategoryAppservice _categoryAppservice;
        private readonly IMapper _mapper;
          #endregion
        #region Constructor
        public CategoryQueryHandler(ICategoryAppservice categoryAppservice, IMapper mapper )
        {

            _categoryAppservice = categoryAppservice;
            _mapper = mapper;
        }
        #endregion

        #region Handle Function

        public async Task<List<GetCategoryListResponse>> Handle(GetCategoryListQuery request, CancellationToken cancellationToken)
        {
            var categoryList = await _categoryAppservice.GetCategoryListAsync();
            var result = _mapper.Map<List<GetCategoryListResponse>>(categoryList);
            return result;
        }

        public async Task<GetSingleCategoryResponse> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryAppservice.GetCategoryBYIDAsync(request.Id);
            if (category == null)
            {
                return null;  
            }
            var result = _mapper.Map<GetSingleCategoryResponse>(category);
            return result;
        }

        #endregion
    }
}

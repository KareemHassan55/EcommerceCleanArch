using ApplicationService.E_CommerceProject.Abstract;
using AutoMapper;
using EcommerceProject.Core.Features.Categorys.Queries.Models;
using EcommerceProject.Core.Features.Categorys.Queries.Results;
using EcommerceProject.Core.Features.Products.Queries.Models;
using EcommerceProject.Core.Features.Products.Queries.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Core.Features.Products.Queries.Handlers
{
    public class ProductQueryHandler :
                                        IRequestHandler<GetProductListQuery, List<GetProductListResponse>>,
                                        IRequestHandler<GetProductByIdQuery, GetSingleProductResponse>
    {
        #region Fields
        private readonly IProductAppservice _productAppservice;
        private readonly IMapper _mapper;
         #endregion
        #region Constructor
        public ProductQueryHandler(IProductAppservice productAppservice, IMapper mapper)
        {

            _productAppservice = productAppservice;
            _mapper = mapper;
        }
        #endregion

        #region Handle Function

        public async Task<List<GetProductListResponse>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {
            var categoryList = await _productAppservice.GetProductListAsync();

            var result = _mapper.Map<List<GetProductListResponse>>(categoryList);
            return result;
        }

        public async Task<GetSingleProductResponse> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _productAppservice.GetProductBYIDAsync(request.Id);
            if (category == null)
            {
                return null;
            }
            var result = _mapper.Map<GetSingleProductResponse>(category);
            return result;
        }

        #endregion
    }
}

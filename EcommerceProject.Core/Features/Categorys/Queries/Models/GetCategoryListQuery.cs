using Azure;
using Domain.ECommerceProject.Data.Categorys;
using EcommerceProject.Core.Features.Categorys.Queries.Results;
using MediatR;


namespace EcommerceProject.Core.Features.Categorys.Queries.Models
{
    public class GetCategoryListQuery : IRequest<List<GetCategoryListResponse>>
    {

    }
}

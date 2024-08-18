using Azure;
using Domain.ECommerceProject.Data.Categorys;
using EcommerceProject.Core.Features.Categorys.Queries.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Core.Features.Categorys.Queries.Models
{
    public class GetCategoryByIdQuery:IRequest<GetSingleCategoryResponse>
    {
        public int Id { get; set; }
        
    }
}

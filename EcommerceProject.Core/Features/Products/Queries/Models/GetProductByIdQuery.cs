using EcommerceProject.Core.Features.Products.Queries.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Core.Features.Products.Queries.Models
{
    public class GetProductByIdQuery:IRequest<GetSingleProductResponse>
    {
        public int Id { get; set; }
    }
}

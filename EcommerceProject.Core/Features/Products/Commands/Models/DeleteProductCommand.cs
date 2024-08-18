using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Core.Features.Products.Commands.Models
{
    public class DeleteProductCommand : IRequest<string>
    {
        public int Id { get; set; }

    }
}

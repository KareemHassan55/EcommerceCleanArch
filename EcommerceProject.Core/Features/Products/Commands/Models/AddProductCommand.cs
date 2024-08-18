using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace EcommerceProject.Core.Features.Products.Commands.Models
{
    public class AddProductCommand : IRequest<string>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public byte[] Img { get; set; }

        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}

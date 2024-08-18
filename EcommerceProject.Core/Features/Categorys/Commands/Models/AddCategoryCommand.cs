using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Core.Features.Categorys.Commands.Models
{
    public class AddCategoryCommand:IRequest<string>
    {
        [Required]
         public string? Name { get; set; }
        public string? Description { get; set; }
    }
}

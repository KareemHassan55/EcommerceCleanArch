using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Core.Features.Categorys.Commands.Models
{
    public class DeleteCategoryCommand : IRequest<string>
    {
        public int Id { get; set; }
    }
}

using Domain.ECommerceProject.Data.Categorys;
using Domain.ECommerceProject.Data.Products;
using EcommerceProject.Core.Features.Categorys.Commands.Models;
using EcommerceProject.Core.Features.Products.Commands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Core.Mapping.Products
{
    public partial class ProductProfile
    {
        public void GetEditObjectMapping()
        {
            CreateMap<EditProductCommand, Product>();
        }
    }
}

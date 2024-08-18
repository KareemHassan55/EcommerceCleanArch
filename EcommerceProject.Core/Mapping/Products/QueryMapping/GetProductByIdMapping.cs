using Domain.ECommerceProject.Data.Categorys;
using Domain.ECommerceProject.Data.Products;
using EcommerceProject.Core.Features.Categorys.Queries.Results;
using EcommerceProject.Core.Features.Products.Queries.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Core.Mapping.Products
{
    public partial class ProductProfile
    {
        public void GetProductByIDMapping()
        {
            CreateMap<Product, GetSingleProductResponse>();

        }
    }
}

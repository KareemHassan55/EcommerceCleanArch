using Domain.ECommerceProject.Data.Categorys;
using EcommerceProject.Core.Features.Categorys.Queries.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Core.Mapping.Categorys
{
    public partial class CategoryProfile
    {
        public void GetCategoryMapping() 
        {
            CreateMap<Category, GetCategoryListResponse>();

        }
    }
}

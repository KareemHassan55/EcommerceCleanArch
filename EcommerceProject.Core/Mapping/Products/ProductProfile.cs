using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Core.Mapping.Products
{
    public partial class ProductProfile : Profile
    {
        public ProductProfile()
        {
            GetProductObjectMapping();
            GetDeletedObjectMapping();
            GetEditObjectMapping();
            GetProductByIDMapping();
            GetProductMapping();
       
        }
    }
}

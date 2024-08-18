using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Core.Features.Products.Queries.Results
{
    public class GetProductListResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public byte[] Img { get; set; }

        public decimal Price { get; set; }
        public string  Categoryname { get; set; }
    }
}

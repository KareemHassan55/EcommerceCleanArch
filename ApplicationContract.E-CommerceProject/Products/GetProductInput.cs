using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ECommerceProject.Products
{
    public class GetProductInput
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
 
        public string? Img { get; set; }

         public decimal Price { get; set; }
    }
}

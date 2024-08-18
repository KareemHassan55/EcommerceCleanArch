using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationContract.E_CommerceProject.Products
{
    public class ProductDto
    {
        public int? Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }

        [DisplayName("Image")]
        //[ValidateNever]
        public string? Img { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [DisplayName("Category")]
        public int? CategoryId { get; set; }
    }
}

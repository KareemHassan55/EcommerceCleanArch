﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Core.Features.Categorys.Queries.Results
{
    public class GetSingleCategoryResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Description { get; set; }
    }
}

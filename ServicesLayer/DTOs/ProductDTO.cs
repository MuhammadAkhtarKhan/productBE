﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.DTOs
{
    public class ProductDTO
    {
        public string Name { get; set; } = string.Empty;       
        public string Description { get; set; } = string.Empty;       
        public Nullable<bool> IsActive { get; set; } = true;
        public int? ProductCategoryId { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class CreateRequestCategoryDto
    {
        public required string Name { get; set; }

        //public DateTime CreatedAt { get; set; }
        public string? Description { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class UpdateCategoryDto
    {
        public int Id { get; set; }
        public DateTime UpdatedAt { get; set; }

        public string? Description { get; set; }
    }
}

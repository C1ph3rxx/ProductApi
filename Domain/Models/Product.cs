using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Product : BaseModel
    {
        public string Description { get; set; }

        public int? Quantity { get; set; }

        public int Price { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        //Navigation Property
        [ForeignKey("CategoryId")]
        //public Category category { get; set; }
        public int CategoryId { get; set; }
    }
}

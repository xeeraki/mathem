using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Products
    {
        public string? productId { get; set; }
        public string? productName { get; set; }
        public List<string>? deliveryDays { get; set; }
        public string? productType { get; set; }
        public int? daysInAdvance { get; set; }

        public decimal price { get; set; }
        public decimal quantity { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Interfaces;

namespace Entities.Models
{
    public class Delivery
    {
        public int postalCode { get; set; }
        public DateTimeOffset? deliveryDate { get; set; }
        public bool isGreenDelivery { get; set; }
    }
}

using Entities.Interfaces;
using Entities.Models;
namespace Repositories
{
    public class DeliveryRepository : IDeliveryDates
    {
        public List<Delivery>? GetDelivery()
        {
            var deliveryDates = new List<Delivery>()
            {
                new Delivery
                {
                    postalCode = 13756,
                    isGreenDelivery = false,
                    deliveryDate = DateTimeOffset.Now,
                },

                new Delivery
                {
                    postalCode = 13757,
                    isGreenDelivery = false,
                    deliveryDate = DateTimeOffset.Now
                }
            };
            return deliveryDates;
        }
    }
}

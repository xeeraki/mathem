using Entities.Models;

namespace Entities.Interfaces
{
    public interface IDeliveryDates
    {
        List<Delivery>? GetDelivery();
    }
}
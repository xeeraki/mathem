
using Entities.Interfaces;
using Entities.Models;
using Mathem;
using Repositories;
using System.Text.Json;

ProductsRepository repo = new ProductsRepository();
List<Products> products = repo.GetProductsAsync();

DeliveryDatesViewModel deliveryDates = new DeliveryDatesViewModel();
int postalCode = 13756;
//var queue = new PriorityQueue<DateTimeOffset, int>();

var dictionary = new Dictionary<DateTimeOffset, bool>();

var startDate = DateTimeOffset.Now;
var endDate = startDate.AddDays(3);

var validDeliveryDates = deliveryDates.CheckDeliveryDates(postalCode,products);


foreach (var datesList in validDeliveryDates.Values)
{
    foreach (var date in datesList)
    {
        // Wednesday is GreenDelivery
        if (date.DayOfWeek.ToString() == (DayOfWeek.Wednesday.ToString()))
        {
            //if GreenDelivery exist within 3 days
            if (startDate <= date && date <= endDate)
            {
                if (dictionary.ContainsKey(date))
                {
                    dictionary[date] = true;

                }
                else
                    dictionary.Add(date, true);

            }

            if (dictionary.ContainsKey(date))
            {
                dictionary[date] = true;

            }
            else
                dictionary.Add(date, true);
 
        }
        else if (dictionary.ContainsKey(date))
        {
            dictionary[date] = false;

        }
        else
            dictionary.Add(date, false);
   
    }
}
//var order = dictionary.OrderBy(key => key.Value == true && startDate <= key.Key && key.Key <= endDate);
foreach (var date in dictionary.OrderByDescending(key => key.Value == true &&
        (startDate <= key.Key && key.Key <= endDate)))
{
    //queue.TryDequeue(out DateTimeOffset item, out int priority);
    var obj = new Delivery
    {
        postalCode = postalCode,
        deliveryDate = date.Key,
        isGreenDelivery = date.Value,
    };

    //var obj2 = new List<Delivery>()
    //obj2.Add(obj);


    var options = new JsonSerializerOptions { WriteIndented = true, AllowTrailingCommas = true };
    var jsonString = JsonSerializer.Serialize(obj, options);
    Console.WriteLine(jsonString);
}









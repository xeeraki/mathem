using Entities.Models;
namespace Mathem
{
    public class DeliveryDatesViewModel
    {
        public Dictionary<int,List<DateTimeOffset>> CheckDeliveryDates(int postalCode, List<Products> products)
        {
            var dictionary = new Dictionary<int,List<DateTimeOffset>>();
            var startDate = DateTimeOffset.Now;
            //for normal product
            var endDate = startDate.AddDays(14);
            //for external product
            var startDate2 =startDate.AddDays(5);
            //check current week for temporary products
            int startOfweek = (int)startDate.DayOfWeek;
            int currentWeek = startOfweek - (int)DayOfWeek.Monday;
            //returns start of current week
            var startDate3 = startDate.AddDays(-currentWeek);
            //end of current week
            var endDate3 = startDate3.AddDays(6);


            foreach (var product in products)
            {
                if(product.productType == "external")
                {
                    var date = Enumerable.Range(0, 1 + endDate.Subtract(startDate2).Days)
                    .Select(offset => startDate2.AddDays(offset))
                    .ToList();

                    if (dictionary.ContainsKey(postalCode))
                    {
                        dictionary[postalCode] = date;
                    }else

                    dictionary.Add(postalCode, date);
                }

                if(product.productType == "normal")
                {
                    var date = Enumerable.Range(0, 1 + endDate.Subtract(startDate).Days)
                    .Select(offset => startDate.AddDays(offset))
                    .ToList();
                    if (dictionary.ContainsKey(postalCode))
                    {
                        dictionary[postalCode] = date;
                    }
                    else
                    dictionary.Add(postalCode, date);
                }

                if (product.productType == "temporary")
                {
                    var date = Enumerable.Range(0, 1 + endDate3.Subtract(startDate3).Days)
                    .Select(offset => startDate3.AddDays(offset))
                    .ToList();
                    if (dictionary.ContainsKey(postalCode))
                    {
                        dictionary[postalCode] = date;
                    }
                    else
                        dictionary.Add(postalCode, date);
                }
            }            
            return dictionary;
        }
    }
}

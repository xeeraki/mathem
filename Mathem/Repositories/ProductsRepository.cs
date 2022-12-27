using Entities.Interfaces;
using Entities.Models;

namespace Repositories
{
    public class ProductsRepository : IProductRepository
    {
        public List<Products> GetProductsAsync()
        {

            var products = new List<Products> {

                    new Products{ productId = "1",
                    productName = "apple",
                    productType = "temporary",
                    deliveryDays = new List<string>{"Monday","Tuseday", "Wednesday","Thurseday",
                        "Friday","Sutreday", "Sunday"},
                    daysInAdvance = 0,
                    price = 3,
                    quantity = 1,
                    },

                    new Products{ productId = "4",
                    productName = "coffee",
                    productType = "normal",
                    deliveryDays = new List<string>{"Monday","Tuseday", "Wednesday","Thurseday",
                        "Friday","Sutreday", "Sunday"},
                    daysInAdvance = 0,
                    price = 3,
                    quantity = 1,
                    },

                    new Products{ productId = "2",                                    
                    productName = "orange",
                    productType = "temporary",
                    deliveryDays = new List<string>{"Monday","Tuseday", "Wednesday","Thurseday", 
                        "Friday","Sutreday", "Sunday"},
                    daysInAdvance = 0,
                    price = 3,
                    quantity = 1,
                    },

                    new Products{ productId = "3",
                    productName = "milk",
                    productType = "external",
                    deliveryDays = new List<string>{"Monday","Tuseday", "Wednesday","Thurseday",
                        "Friday","Sutreday", "Sunday"},
                    daysInAdvance = 5,
                    price = 3,
                    quantity = 1,
                    },

                    new Products{ productId = "5",
                    productName = "Meet",
                    productType = "external",
                    deliveryDays = new List<string>{"Monday","Tuseday", "Wednesday","Thurseday",
                        "Friday","Sutreday", "Sunday"},
                    daysInAdvance = 5,
                    price = 3,
                    quantity = 1,
                    },

            };
       
            return products;
        }
        public Products GetProductAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
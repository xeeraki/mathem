
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IProductRepository
    {
       List<Products>GetProductsAsync();
       Products GetProductAsync(string id);
    }
}

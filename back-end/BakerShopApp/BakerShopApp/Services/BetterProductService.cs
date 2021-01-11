using BakerShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakerShopApp.Services
{
    public class BetterProductService : IProductService
    {
        public List<ProductViewModel> getAll()
        {
            return new List<ProductViewModel>
            {
                new ProductViewModel {Id = 1, Name = "Television" },
                new ProductViewModel {Id = 2, Name = "Refrigerator" },
                new ProductViewModel {Id = 3, Name = "IPhone" },
                new ProductViewModel {Id = 4, Name = "Laptop" },
            };
        }
    }
}

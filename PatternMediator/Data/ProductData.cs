using System.Collections.Generic;
using PatternMediator.Common.Models;

namespace PatternMediator.Data
{
    internal class ProductData
    {
        internal List<ProductDTO> GetProductData()
        {
            return new List<ProductDTO>
            {
                new ProductDTO { Id = 234, Name = "Tv", Price = 500 },
                new ProductDTO { Id = 315, Name = "Tv", Price = 500 },
                new ProductDTO { Id = 581, Name = "Tv", Price = 500 },
                new ProductDTO { Id = 699, Name = "Tv", Price = 500 },
                new ProductDTO { Id = 862, Name = "Tv", Price = 500 },
                new ProductDTO { Id = 660, Name = "Tv", Price = 500 }
            };
        }
    }
}

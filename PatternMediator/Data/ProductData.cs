using PatternMediator.Common.Models;
using System.Collections.Generic;

namespace PatternMediator.Data
{
    internal class ProductData
    {
        internal Dictionary<int, ProductDTO> GetProductData()
        {
            return new Dictionary<int, ProductDTO>
            {
                { 0, new ProductDTO { Id = 234, Name = "Tv", Price = 500 } },
                { 1, new ProductDTO { Id = 315, Name = "Tv", Price = 500 } },
                { 2, new ProductDTO { Id = 581, Name = "Tv", Price = 500 } },
                { 3, new ProductDTO { Id = 699, Name = "Tv", Price = 500 } },
                { 4, new ProductDTO { Id = 862, Name = "Tv", Price = 500 } },
                { 5, new ProductDTO { Id = 660, Name = "Tv", Price = 500 } }
            };
        }
    }
}

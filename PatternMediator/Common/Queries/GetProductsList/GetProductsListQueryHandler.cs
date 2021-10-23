using PatternMediator.Common.Models;
using PatternMediator.MediatorImplementation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMediator.Common.Queries.GetProductsList
{
    public class GetProductsListQueryHandler : IRequestHandler<GetProductsListQuery, IEnumerable<ProductDTO>>
    {
        private Dictionary<int, ProductDTO> products = new Dictionary<int, ProductDTO>();
        public GetProductsListQueryHandler()
        {
            products.Add(0, new ProductDTO { Id = 234, Name = "Tv", Price = 500 });
            products.Add(1, new ProductDTO { Id = 315, Name = "Tv", Price = 500 });
            products.Add(2, new ProductDTO { Id = 581, Name = "Tv", Price = 500 });
            products.Add(3, new ProductDTO { Id = 699, Name = "Tv", Price = 500 });
            products.Add(4, new ProductDTO { Id = 862, Name = "Tv", Price = 500 });
            products.Add(5, new ProductDTO { Id = 660, Name = "Tv", Price = 500 });
        }

        public IEnumerable<ProductDTO> Handler(GetProductsListQuery source)
        {
            var list = new List<ProductDTO>();
            foreach (var item in products)
            {
                list.Add(item.Value);
            }

            return list;
        }
    }
}

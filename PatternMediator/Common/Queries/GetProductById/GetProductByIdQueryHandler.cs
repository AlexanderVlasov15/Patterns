using PatternMediator.Common.Models;
using PatternMediator.MediatorImplementation.Interfaces;
using System.Collections.Generic;

namespace PatternMediator.Common.Queries.GetProductById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductDTO>
    {
        private Dictionary<int, ProductDTO> products = new Dictionary<int, ProductDTO>();
        public GetProductByIdQueryHandler()
        {
            products.Add(0, new ProductDTO { Id = 234, Name = "Tv", Price = 500 });
            products.Add(1, new ProductDTO { Id = 315, Name = "Tv", Price = 500 });
            products.Add(2, new ProductDTO { Id = 581, Name = "Tv", Price = 500 });
            products.Add(3, new ProductDTO { Id = 699, Name = "Tv", Price = 500 });
            products.Add(4, new ProductDTO { Id = 862, Name = "Tv", Price = 500 });
            products.Add(5, new ProductDTO { Id = 660, Name = "Tv", Price = 500 });
        }

        public ProductDTO Handler(GetProductByIdQuery source)
        {
            return products[source.Id];
        }
    }
}

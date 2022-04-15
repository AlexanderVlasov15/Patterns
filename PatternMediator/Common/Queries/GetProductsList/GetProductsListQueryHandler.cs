using PatternMediator.Common.Models;
using PatternMediator.Data;
using PatternMediator.MediatorImplementation.Interfaces;
using System.Collections.Generic;

namespace PatternMediator.Common.Queries.GetProductsList
{
    public class GetProductsListQueryHandler : IRequestHandler<GetProductsListQuery, IEnumerable<ProductDTO>>
    {
        private readonly ProductData _data;

        public GetProductsListQueryHandler()
            => _data = new ProductData();

        public IEnumerable<ProductDTO> Handler(GetProductsListQuery source)
        {
            var list = new List<ProductDTO>();
            foreach (var item in _data.GetProductData())
            {
                list.Add(item.Value);
            }

            return list;
        }
    }
}

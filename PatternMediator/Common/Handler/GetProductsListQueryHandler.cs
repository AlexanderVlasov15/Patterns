using PatternMediator.Data;
using System.Collections.Generic;
using PatternMediator.Common.Models;
using PatternMediator.Common.Queries;
using PatternMediator.MediatorImplementation.Interfaces;

namespace PatternMediator.Common.Handler
{
    public class GetProductsListQueryHandler : IRequestHandler<GetProductsListQuery, IEnumerable<ProductDTO>>
    {
        private readonly ProductData _data;

        public GetProductsListQueryHandler()
        {
            _data = new ProductData();
        }

        public IEnumerable<ProductDTO> Handler(GetProductsListQuery source)
        {
            return _data.GetProductData();
        }
    }
}

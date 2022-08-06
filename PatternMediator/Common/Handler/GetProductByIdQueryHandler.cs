using System.Linq;
using PatternMediator.Data;
using PatternMediator.Common.Models;
using PatternMediator.Common.Queries;
using PatternMediator.MediatorImplementation.Interfaces;

namespace PatternMediator.Common.Handler
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductDTO>
    {
        private readonly ProductData _data;

        public GetProductByIdQueryHandler()
        {
            _data = new ProductData();
        }

        public ProductDTO Handler(GetProductByIdQuery query)
        {
            return _data.GetProductData().FirstOrDefault(x => x.Id == query.Id);
        }
    }
}

using System.Collections.Generic;
using PatternMediator.Common.Models;
using PatternMediator.MediatorImplementation.Interfaces;

namespace PatternMediator.Common.Queries
{
    public class GetProductsListQuery : IRequest<IEnumerable<ProductDTO>>
    {
    }
}

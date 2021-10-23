using PatternMediator.Common.Models;
using PatternMediator.MediatorImplementation.Interfaces;
using System.Collections.Generic;

namespace PatternMediator.Common.Queries.GetProductsList
{
    public class GetProductsListQuery : IRequest<IEnumerable<ProductDTO>>
    {
    }
}

using PatternMediator.Common.Models;
using PatternMediator.MediatorImplementation.Interfaces;

namespace PatternMediator.Common.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<ProductDTO>
    {
        public int Id { get; set; }
        public GetProductByIdQuery(int id)
            => Id = id;
    }
}

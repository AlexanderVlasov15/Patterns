using System;
using System.Reflection;
using PatternMediator.Common.Queries;
using PatternMediator.MediatorImplementation;
using PatternMediator.MediatorImplementation.Interfaces;

namespace PatternMediator
{
    class Program
    {
        static void Main(string[] args)
        {
            IMediator _mediator = new Mediator(Assembly.GetExecutingAssembly());

            var prod = _mediator.Send(new GetProductByIdQuery(581));
            Console.WriteLine($"Id: {prod.Id}  Name: {prod.Name}  Price: {prod.Price}");
            Console.WriteLine();

            var prodList = _mediator.Send(new GetProductsListQuery());
            foreach (var product in prodList)
            {
                Console.WriteLine($"Id: {product.Id}  Name: {product.Name}  Price: {product.Price}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

using PatternMediator.Common.Queries.GetProductById;
using PatternMediator.Common.Queries.GetProductsList;
using PatternMediator.MediatorImplementation;
using PatternMediator.MediatorImplementation.Interfaces;
using System;
using System.Reflection;

namespace PatternMediator
{
    class Program
    {
        static void Main(string[] args)
        {
            IMediator _mediator = new Mediator(Assembly.GetExecutingAssembly());

            var prod = _mediator.Send(new GetProductByIdQuery(5));
            var prodList = _mediator.Send(new GetProductsListQuery());

            Console.WriteLine($"Id: {prod.Id }");
            Console.WriteLine($"Name: {prod.Name }");
            Console.WriteLine($"Price: {prod.Price }");

            foreach (var product in prodList)
            { 
                Console.WriteLine($"Id: {product.Id }");
                Console.WriteLine($"Name: {product.Name }");
                Console.WriteLine($"Price: {product.Price }");
            }

            Console.ReadKey();

        }
    }
}

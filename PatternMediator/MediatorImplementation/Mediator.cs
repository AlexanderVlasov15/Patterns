using PatternMediator.MediatorImplementation.Interfaces;
using System.Reflection;
using System;

namespace PatternMediator.MediatorImplementation
{
    public class Mediator : IMediator
    {
        private Assembly _assembly;
        public Mediator(Assembly assembly) 
            => _assembly = assembly;

        public TResponse Send<TResponse>(IRequest<TResponse> request)
        {
            object result = null;
            foreach (var item in _assembly.GetTypes())
            {
                var baseIRequestHandler = typeof(IRequestHandler);

                var interfaces = item.GetInterface(baseIRequestHandler.Name);
                if (interfaces != null && interfaces == baseIRequestHandler && item.IsClass)
                {
                    var methodHandler = item.GetMethod("Handler");
                    foreach (var param in methodHandler.GetParameters())
                    {
                        if(param.ParameterType == request.GetType())
                        {
                            var classHandler = Activator.CreateInstance(item);
                            result = methodHandler.Invoke(classHandler, new object[] { request });
                            break;
                        }
                    }     
                }
                if (result != null)
                    break;
            }
            return (TResponse)result;
        }
    }

}

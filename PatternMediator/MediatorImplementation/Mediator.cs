using System;
using System.Reflection;
using PatternMediator.MediatorImplementation.Interfaces;

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

                //Знаходимо клас який реалізує IRequestHandler
                if (item.GetInterface(baseIRequestHandler.Name) == baseIRequestHandler && item.IsClass)
                {
                    //Отримуємо у цьому класі метод Handler
                    var methodHandler = item.GetMethod("Handler");
                    foreach (var param in methodHandler.GetParameters())
                    {
                        //Дивимось чи відповідає параметр який ми передали в метод Send
                        if (param.ParameterType == request.GetType())
                        {
                            var classHandler = Activator.CreateInstance(item);
                            //Викликаємо метод Handler і передаемо йому параметр і отримуємо результат
                            result = methodHandler.Invoke(classHandler, new object[] { request });
                            break;
                        }
                    }     
                }
                if (result != null)
                {
                    break;
                }
            }
            return (TResponse)result;
        }
    }

}

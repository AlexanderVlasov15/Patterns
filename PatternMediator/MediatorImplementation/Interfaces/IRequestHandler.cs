namespace PatternMediator.MediatorImplementation.Interfaces
{
    public interface IRequestHandler { }
    public interface IRequestHandler<in TIn, out TOut> : IRequestHandler where TIn : IRequest<TOut> 
    {
        TOut Handler(TIn source);
    }
}

namespace PatternMediator.MediatorImplementation.Interfaces
{
    public interface ISend
    {
        TResponse Send<TResponse>(IRequest<TResponse> request);
    }
}

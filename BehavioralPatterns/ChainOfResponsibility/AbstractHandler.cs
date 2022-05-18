abstract class AbstractHandler : IHandler
{
    private IHandler _nextHandler;

    public IHandler SetNext(IHandler handler)
    {
        _nextHandler = handler;

        return handler;
    }

    public virtual object Handle(object request)
    {
        if(_nextHandler != null)
        {
            return _nextHandler.Handle(request);
        }
        else
        {
            return null;
        }
    }
}
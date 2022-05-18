class MonkeyHandler: AbstractHandler
{
    public override object Handle(object request)
    {
        if((request as string).ToLower() == "banana")
            return $"Monkey: I'll eat the {request.ToString()}.\n";
        
        return base.Handle(request);
    }
}
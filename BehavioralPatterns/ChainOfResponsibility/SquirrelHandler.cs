class SquirrelHandler: AbstractHandler
{
    public override object Handle(object request)
    {
        if((request as string).ToLower() == "nut")
            return $"Squirrel: I'll eat the {request.ToString()}.\n";
        
        return base.Handle(request);
    }
}
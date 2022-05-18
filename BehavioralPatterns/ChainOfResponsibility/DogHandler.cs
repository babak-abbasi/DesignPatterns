class DogHandler: AbstractHandler
{
    public override object Handle(object request)
    {
        if((request as string).ToLower() == "meatball")
            return $"Dog: I'll eat the {request.ToString()}.\n";
        
        return base.Handle(request);
    }
}
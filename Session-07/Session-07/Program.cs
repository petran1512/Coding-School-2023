using Session_07;


   
ActionRequest request = new ActionRequest()
{
    Input="Peter",
    Action = Action.Enum.Reverse
}

    ActionResponse response = new ActionResponse();

    ActionResolver resolver = new ActionResolver();

    response = resolver.Execute(request);

    resolver.Logger.ReadAll();

    Console.ReadLine();


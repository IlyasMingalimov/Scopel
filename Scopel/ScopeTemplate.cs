namespace Scopel;
public class ScopeTemplate
{
    private readonly List<ScopeTemplate> internalScopes = new();
    private readonly List<ObjectTemplate> objects = new();
    private readonly List<IMessageTemplate> messages = new();

    public bool IsRun { get; private set; }

    public async Task AddObject<T>(T template) where T : ObjectTemplate 
    { 
        objects.Add(template);
    } 

    public async Task SetupMessage<T>(MessageTemplate<T> message) 
    {
        messages.Add(message);
    }

    public async Task Run() 
    { 
        IsRun = true;

        foreach (var obj in objects) 
        {
            var message = messages.First();
            await obj.Do(message as MessageTemplate<string>);
        }

        foreach(var internalScope in internalScopes) 
        { 
            if(!internalScope.IsRun)
            await internalScope.Run();
        }
    }
}

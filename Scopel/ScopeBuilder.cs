namespace Scopel;
public class ScopeBuilder<Scope> where Scope : ScopeTemplate, new()
{
    private readonly Scope scope = new();

    public void RunScope(List<MessageTemplate> messages, List<ObjectTemplate> objects) 
    {
        foreach (var obj in objects)
        {
            scope.AddObject(obj);
        }

        foreach (var message in messages) 
        {
            scope.AddMessage(message);
        }
    }
}

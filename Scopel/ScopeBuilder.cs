namespace Scopel;
public class ScopeBuilder<Scope> where Scope : ScopeTemplate, new()
{
    private readonly Scope scope = new();
    public void BuildScope(List<ObjectTemplate> objects) 
    {
        foreach (var obj in objects)
            scope.AddObject(obj);
    }
}

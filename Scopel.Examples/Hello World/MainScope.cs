namespace Scopel.Examples.HelloWorld;
public class MainScope : ScopeTemplate
{
	public MainScope(IEnumerable<ObjectTemplate> objs) : base(objs){}
	public override void Dispose(){}
}

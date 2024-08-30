namespace Scopel.Examples.HelloWorld;
public class MainScope : ScopeTemplate
{
	public MainScope(IEnumerable<IObjectTemplate> objs) : base(objs){}
	public override void Dispose(){}
}

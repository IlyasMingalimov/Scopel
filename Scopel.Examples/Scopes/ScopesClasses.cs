namespace Scopel.Examples.Scopes;
public class MasterScope : ScopeTemplate
{
	public MasterScope(IEnumerable<IObjectTemplate> objs) : base(objs){}
	public override void Dispose() { }
	public void EmitChildScope() 
	{ 
		var objs = new List<IObjectTemplate>();
		var childScope = new ChildScope(objs);
		Emit(childScope);
	}
}
public class ChildScope : ScopeTemplate
{
	public ChildScope(IEnumerable<IObjectTemplate> objs) : base(objs){}
	public override void Dispose() { }
}

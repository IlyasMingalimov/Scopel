namespace Scopel;

public abstract class ObjectEmitterTemplate : IObjectTemplate
{
	internal Action<IObjectTemplate>? EmitObject;
	protected void Emit(IObjectTemplate obj) => EmitObject?.Invoke(obj);
}
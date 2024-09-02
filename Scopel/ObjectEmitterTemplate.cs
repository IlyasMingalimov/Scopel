namespace Scopel;

public abstract class ObjectEmitterTemplate : IObjectTemplate
{
	internal Action<IObjectTemplate>? EmitObject;
	public void Emit(IObjectTemplate obj) => EmitObject?.Invoke(obj);
}
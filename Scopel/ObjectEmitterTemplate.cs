namespace Scopel;

public abstract class ObjectEmitterTemplate : ObjectSenderTemplate
{
	internal Action<IObjectTemplate>? EmitObject;
	protected void Emit(IObjectTemplate obj) => EmitObject?.Invoke(obj);
}
namespace Scopel;
public interface IObjectRecipientTemplate : IObjectTemplate
{
	void Receive(IMessageTemplate message);
}

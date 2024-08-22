namespace Scopel;
public class ObjectTemplate
{
    public async Task Do<Message>(Message message) where Message : MessageTemplate<string>
    {
        Console.WriteLine(message.Value);
    }
}

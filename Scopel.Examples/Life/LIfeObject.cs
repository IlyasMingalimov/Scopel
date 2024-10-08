using Scopel.Examples.Life.Messages;

namespace Scopel.Examples.Life;
public class LIfeObject : ObjectSenderTemplate, IObjectRecipientTemplate
{
    public enum LifeState 
    { 
        Life,
        Dead
    }

    public readonly Guid guid;
    public readonly string name;
    public readonly DateTime birthDate;
    private LifeState state;
    private static readonly Lazy<Random> random = new();
    public Tuple<int, int> NewLifeRandom = new (370, 465);
    public Tuple<int, int> DeadRandom = new(1000, 1500);
    public LIfeObject() 
    {
        state = LifeState.Life;
        guid = Guid.NewGuid();
        name = NameGenerator.GenerateRandomName();
        birthDate = DateTime.Now;
        Task.Delay(random.Value.Next(NewLifeRandom.Item1, NewLifeRandom.Item2)).ContinueWith(t => CreateNewLife());
        Task.Delay(random.Value.Next(DeadRandom.Item1, DeadRandom.Item2)).ContinueWith(t => Dead());
        Eat();
    }

    public void Receive(IMessageTemplate message)
    {
        if(message is EatAproveMessage aproveMessage) 
        {
            if(aproveMessage.Guid == guid && !aproveMessage.ok)
                state = LifeState.Dead;
        }
    }

    private async void Dead() 
    {
        state = LifeState.Dead;
        Send(new DeadMessage(this));
    }

    private async void CreateNewLife() 
    {
        if (state == LifeState.Dead)
            return;

        var chance = random.Value.Next(0, 2);

        if(chance != 0)
            Send(new CreateLifeMessage());

        _ = Task.Delay(random.Value.Next(NewLifeRandom.Item1, NewLifeRandom.Item2)).ContinueWith(t => CreateNewLife());
    }

    private void Eat() 
    {
        if (state == LifeState.Dead)
            return;

        Send(new EatMessage(guid));
        Task.Delay(1200).ContinueWith(t => Eat());
    }
}
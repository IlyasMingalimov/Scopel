namespace Scopel.Examples.Life.Messages;
public record struct LogMessage(string message) : IMessageTemplate;
public record struct DeadMessage(LIfeObject obj) : IMessageTemplate;
public record struct CreateLifeMessage() : IMessageTemplate;
public record struct EatMessage(Guid guid) : IMessageTemplate;
public record struct EatAproveMessage(bool ok, Guid Guid) : IMessageTemplate;
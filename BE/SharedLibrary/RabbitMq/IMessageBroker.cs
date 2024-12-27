namespace SharedLibrary.RabbitMq
{
    public interface IMessageBroker
    {
        void Publish(string queueName, string message);
        void Subscribe(string queueName, Action<string> onMessageReceived);
    }
}

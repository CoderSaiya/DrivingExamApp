using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace SharedLibrary.RabbitMq
{
    public class MessageBroker : IMessageBroker
    {
        private readonly IConnection connection;
        private readonly IModel channel;

        public MessageBroker(IConnection connection, IModel channel)
        {
            this.connection = connection;
            this.channel = channel;
        }

        public void Publish(string queueName, string message)
        {
            throw new NotImplementedException();
        }

        public void Subscribe(string queueName, Action<string> onMessageReceived)
        {
            throw new NotImplementedException();
        }
    }
}

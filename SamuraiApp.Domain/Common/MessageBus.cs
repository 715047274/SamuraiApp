using SamuraiApp.Domain.Interface;

namespace SamuraiApp.Domain.Common
{
    public class MessageBus
    {
        private readonly IBus _bus;

        public MessageBus(IBus bus)
        {
            _bus = bus;
        }

        public void SendEmailChangedMessage()
        {
            _bus.Send("event trigger");
        }
        

    }
}
using System;
using System.Collections.Generic;
using SamuraiApp.Domain.Interface;

namespace SamuraiApp.Domain.Common
{
    public sealed class EventDispatcher
    {
        private readonly MessageBus _messageBus;

        public EventDispatcher(MessageBus messageBus)
        {
            _messageBus = messageBus;
        }

        public void Dispatch(IEnumerable
        <IDomainEvent> events)
        {
            foreach (IDomainEvent ev in events)
            {
                Dispatch(ev);
            }
        }

        private void Dispatch(IDomainEvent ev)
        {
            switch (ev)
            {
                case StudentEmailChangedEvent emailChangedEvent:
                    _messageBus.SendEmailChangedMessage();
                    break;

                // new domain events go here

                default:
                    throw new Exception($"Unknown event type: '{ev.GetType()}'");
            }
        }
        
    }
}
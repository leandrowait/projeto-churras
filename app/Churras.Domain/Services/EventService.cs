using Churras.Domain.Contracts.Repositories;
using Churras.Domain.Contracts.Services;
using Churras.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Churras.Domain.Services
{
    public class EventService : ServiceBase<Event>, IEventService 
    {
        private readonly IEventRepository eventRepository;

        public EventService(IEventRepository eventRepository) 
            : base(eventRepository)
        {
            this.eventRepository = eventRepository;
        }
    }
}

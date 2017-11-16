using Churras.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Churras.Domain.Contracts.Services
{
    public interface IEventService : IServiceBase<Event>
    {
    }
}

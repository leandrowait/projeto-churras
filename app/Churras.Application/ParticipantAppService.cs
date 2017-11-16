using Churras.Application.Contracts;
using Churras.Domain.Contracts.Services;
using Churras.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Churras.Application
{
    public class ParticipantAppService : AppServiceBase<Participant>, IParticipantAppService
    {
        private readonly IParticipantService service;

        public ParticipantAppService(IParticipantService service) : base(service)
        {
            this.service = service;
        }
    }
}

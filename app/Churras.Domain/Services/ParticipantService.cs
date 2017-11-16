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
    public class ParticipantService : ServiceBase<Participant>, IParticipantService
    {
        private readonly IParticipantRepository participantRepository;

        public ParticipantService(IParticipantRepository participantRepository) 
            : base(participantRepository)
        {
            this.participantRepository = participantRepository;
        }
    }
}

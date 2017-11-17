using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Churras.Domain.Events
{
    public class Participant
    {
        public int ParticipantId { get; set; }

        public int EventId { get; set; }

        public string Name { get; set; }

        public bool WithDrink { get; set; } = false;

        public bool Paid { get; set; } = false;

        public decimal Contribuition { get; set; }

        public string Observation { get; set; }              

        public virtual Event Event { get; set; }
    }
}

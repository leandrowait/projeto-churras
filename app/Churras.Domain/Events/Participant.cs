using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Churras.Domain.Events
{
    public enum DrinkOption
    {
        WithDrink = 1,
        WithoutDrink = 1,
    }

    public class Participant
    {
        public int ParticipantId { get; set; }

        public string Name { get; set; }

        public bool Paid { get; set; } = false;

        public decimal Contribuition { get; set; }

        public DrinkOption DrinkOption { get; set; }

        public virtual Event Event { get; set; }
    }
}

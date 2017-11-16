using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Churras.Domain.Events
{
    public class Event
    {
        public int EventId { get; set; }

        public DateTime Data { get; set; }

        public string Description { get; set; }

        public string Observation { get; set; }

        public decimal ValueWithDrink { get; set; }

        public decimal ValueWithoutDrink { get; set; }

        public virtual ICollection<Participant> Participants { get; set; }

        public int TotalParticipants
        {
            get
            {
                return Participants?.Count() ?? 0;
            }
        }

        public int TotalWithDrinkParticipants
        {
            get
            {
                return this.CountParticipants(DrinkOption.WithDrink);
            }
        }

        public int TotalWithoutDrinkParticipants
        {
            get
            {
                return this.CountParticipants(DrinkOption.WithoutDrink);
            }
        }

        public decimal TotalCollection
        {
            get
            {
                if (Participants == null) return 0;

                return Participants
                    .Where(x => x.Paid = true)
                    .Sum(x => x.Contribuition);
            }
        }

        public decimal TotalTargetCollection
        {
            get
            {
                return (TotalWithDrinkParticipants * ValueWithDrink)
                    + (TotalWithoutDrinkParticipants * ValueWithoutDrink); 
            }
        }

        private int CountParticipants(DrinkOption drinkOption)
        {
            if (Participants == null) return 0;

            return Participants
                .Where(x => x.DrinkOption == drinkOption)
                .Count();
        }
    }
}

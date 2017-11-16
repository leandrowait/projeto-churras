using Churras.Domain.Events;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Churras.Data.EntityConfig
{
    internal class EventConfig : EntityTypeConfiguration<Event>
    {
        public EventConfig()
        {
            Property(x => x.Data)
                .IsRequired()
                .HasColumnType("date");

            Property(x => x.Description)
                .IsRequired();

            Property(x => x.Observation)
                 .HasMaxLength(500);
        }
    }
}

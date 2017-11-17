using Churras.Domain.Events;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Churras.Data.EntityConfig
{
    internal class ParticipantConfig : EntityTypeConfiguration<Participant>
    {
        public ParticipantConfig()
        {
            Property(x => x.Contribuition)
                .IsOptional();

            Property(x => x.Paid)
                .IsOptional();

            Property(x => x.Observation)
                .IsOptional();

            HasRequired(c => c.Event)
                .WithMany(p => p.Participants)
                .HasForeignKey(p => p.EventId)
                .WillCascadeOnDelete(true);
        }
    }
}

using Churras.Data.EntityConfig;
using Churras.Domain.Events;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Churras.Data.Context
{
    public class ChurrasContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public DbSet<Participant> Participants { get; set; }

        public ChurrasContext() :
            base("ProjetoChurras")
        {
#if DEBUG
            Database.Log = (x => {
                Debug.WriteLine(x);
            });
#endif
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new EventConfig());
            modelBuilder.Configurations.Add(new ParticipantConfig());
        }
    }
}

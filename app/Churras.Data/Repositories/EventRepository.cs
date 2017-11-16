using Churras.Domain.Contracts.Repositories;
using Churras.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Churras.Data.Repositories
{
    public class EventRepository : RepositoryBase<Event>, IEventRepository
    {
        public EventRepository(DbContext db) : base(db)
        {
        }

        public override Event GetBayId(int id)
        {
            var @event = db.Set<Event>()
                .Include("Participants")
                .FirstOrDefault(x => x.EventId == id);
            return @event;
        }

        public override IEnumerable<Event> GetAll()
        {
            var @event = db.Set<Event>()
               .Include("Participants")
               .ToList();
            return @event;
        }
    }
}

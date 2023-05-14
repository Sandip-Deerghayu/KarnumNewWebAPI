using KranumDataAccess.Model;
using KranumDataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace KranumDataAccess.Repository
{
    public class EventRepository : KranumBaseRepository<Event, RelyfyDotNetStagingContext>
    {
        public EventRepository(RelyfyDotNetStagingContext context) : base(context)
        {
        }
    }
}
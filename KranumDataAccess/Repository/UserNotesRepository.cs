using KranumDataAccess.Model;
using KranumDataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace KranumDataAccess.Repository
{
    public class UserNotesRepository : KranumBaseRepository<UserNotes, RelyfyDotNetStagingContext>
    {
        public UserNotesRepository(RelyfyDotNetStagingContext context) : base(context)
        {
        }
    }
}
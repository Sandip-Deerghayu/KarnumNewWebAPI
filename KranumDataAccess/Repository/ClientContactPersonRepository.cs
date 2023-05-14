using KranumDataAccess.Model;
using KranumDataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace KranumDataAccess.Repository
{
    public class ClientContactPersonRepository : KranumBaseRepository<ClientContactPerson, RelyfyDotNetStagingContext>
    {
        public ClientContactPersonRepository(RelyfyDotNetStagingContext context) : base(context)
        {
        }
    }
}
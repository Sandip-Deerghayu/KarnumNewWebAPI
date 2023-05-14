using KranumDataAccess.Model;
using KranumDataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace KranumDataAccess.Repository
{
    public class ExceptionLogRepository : KranumBaseRepository<ExceptionLog, RelyfyDotNetStagingContext>
    {
        public ExceptionLogRepository(RelyfyDotNetStagingContext context) : base(context)
        {
        }
    }
}
    
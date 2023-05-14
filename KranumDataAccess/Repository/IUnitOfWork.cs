using System;

namespace KranumDataAccess.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        void SaveChanges();

        EventRepository GetEventRepository();
        UserNotesRepository GetUserNotesRepository();

        ClientContactPersonRepository GetClientContactPersonRepository();

        ExceptionLogRepository GetExceptionLogRepository();

    }
}
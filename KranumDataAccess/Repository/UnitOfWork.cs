using KranumDataAccess.Model;
using KranumDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KranumDataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public RelyfyDotNetStagingContext _context { get; }

        public UnitOfWork(RelyfyDotNetStagingContext context)
        {
            _context = context;
            //context.Database.BeginTransaction();
        }

        public void Dispose()
        {
            _context.DisposeAsync();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
            //Context.Database.CommitTransaction();
        }

        public EventRepository GetEventRepository()
        {
            return new EventRepository(_context);
        }

        public UserNotesRepository GetUserNotesRepository()
        {
            return new UserNotesRepository(_context);
        }

        public ClientContactPersonRepository GetClientContactPersonRepository()
        {
            return new ClientContactPersonRepository(_context);
        }

        public ExceptionLogRepository GetExceptionLogRepository()
        {
            return new ExceptionLogRepository(_context);
        }
    }
}

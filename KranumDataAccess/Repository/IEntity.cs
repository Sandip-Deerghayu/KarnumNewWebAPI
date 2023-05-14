using System;
using System.Collections.Generic;
using System.Text;

namespace KranumDataAccess.Repository
{
    public interface IEntity
    {
        int Id { get; set; }
        //string Uuid { get; set; }
    }
}

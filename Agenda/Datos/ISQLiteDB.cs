using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Agenda.Datos
{
    public interface ISQLiteDB
    {
        SQLiteAsyncConnection GetConnection();
    }
}

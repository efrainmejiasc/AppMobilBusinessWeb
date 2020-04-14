using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessApp.Engine.Interfaces
{
    public interface IEngineDb
    {
        SQLiteConnection CreateDbAndCnx();
    }
}

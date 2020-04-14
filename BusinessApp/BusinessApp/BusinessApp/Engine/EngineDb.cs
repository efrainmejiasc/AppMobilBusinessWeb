using BusinessApp.Engine.Interfaces;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessApp.Engine
{
    public class EngineDb :IEngineDb
    {
        public SQLiteConnection CreateDbAndCnx()
        {
            SQLiteConnection db = new SQLiteConnection(EngineData.PathDb);
            return db;
        }
    }
}

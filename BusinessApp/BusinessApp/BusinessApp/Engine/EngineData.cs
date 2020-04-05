using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessApp.Engine
{
    public class EngineData
    {
        private static EngineData valor;
        public static EngineData Instance()
        {
            if ((valor == null))
            {
                valor = new EngineData();
            }
            return valor;
        }

        public static string NombreBaseDatos = "AppBusiness.db";
        public static string Folder = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        public static string PathDb = System.IO.Path.Combine(Folder, NombreBaseDatos);
    }
}

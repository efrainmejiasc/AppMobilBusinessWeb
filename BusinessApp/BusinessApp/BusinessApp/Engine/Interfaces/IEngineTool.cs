using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessApp.Engine.Interfaces
{
    public interface IEngineTool
    {
        bool TestInternet();

        bool EmailEsValido(string email);

        string ConvertirBase64(string cadena);

        bool CompareString(string a, string b);

        string DecodeBase64(string base64EncodedData);
    }
}

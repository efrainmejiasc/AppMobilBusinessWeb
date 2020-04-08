using BusinessApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Engine.Interfaces
{
    public interface IEngineProcesor
    {
        Task<bool> CreateUserApi(string jsonUserApi, IEngineHttp FuncionHttp);
        Task<TicketAcceso> GetTicketAccesoAsync(string jsonUserApi, IEngineHttp FuncionHttp);
        Task<bool> RegisterDevice(string jsonData, string accessToken, IEngineHttp FuncionHttp);
    }
}

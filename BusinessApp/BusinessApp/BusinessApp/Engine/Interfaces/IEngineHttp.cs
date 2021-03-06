﻿using BusinessApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Engine.Interfaces
{
    public interface IEngineHttp
    {
        Task<bool> CreateUserApi(string jsonData);
        Task<TicketAcceso> GetAccessToken(string jsonData);
        Task<bool> RegisterDevice(string jsonData, string strToken);
    }
}

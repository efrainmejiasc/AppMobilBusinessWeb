﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessApp.Models
{
    public class UserApi
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public int IdCompany { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
        public int IdTypeUser { get; set; }
        public string Password2 { get; set; }
        public string Company { get; set; }
    }
}

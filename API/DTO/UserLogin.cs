﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.DTO
{
    public class UserLogin
    {
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string age { get; set; }
        public string mobile { get; set; }
    }
}
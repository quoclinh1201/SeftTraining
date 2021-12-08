﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeftTraining.Business.ResponseObjects.UserAccountResponses
{
    public class LoginResponse
    {
        public string FullName { get; set; }
        public string Role { get; set; }
        public string AccessToken { get; set; }
    }
}

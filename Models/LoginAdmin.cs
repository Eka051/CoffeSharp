﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFE_SHARP.Models
{
    internal class LoginAdmin
    {
        private string username { get; set; }
        private string password { get; set; }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public LoginAdmin(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}

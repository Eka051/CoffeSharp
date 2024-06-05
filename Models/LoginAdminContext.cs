﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Threading.Tasks;

namespace COFFE_SHARP.Models
{
    internal class LoginAdminContext
    {
        private readonly string connStr;
        public LoginAdminContext()
        {
            connStr = "Server=localhost;Port=5432;Username=postgres;Password=123;Database=CoffeSharp;CommandTimeout=10";
        }
        public LoginAdmin Validate(string username, string password)
        {
            LoginAdmin loginAdmin = null;
            string query = "SELECT * FROM admin WHERE username_admin = @username AND password_admin = @password";
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            loginAdmin = new LoginAdmin(username, password);
                            loginAdmin.Username = (string)reader["username_admin"];
                            loginAdmin.Password = (string)reader["password_admin"];
                        }
                    }
                }
            }
            return loginAdmin;
        }
    }
}

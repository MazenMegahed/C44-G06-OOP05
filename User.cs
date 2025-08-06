using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP_5
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Roles { get; set; }

        public User(string username, string password, string[] roles)
        {
            Username = username;
            Password = password;
            Roles = roles;
        }
        public User() { }
    }
}

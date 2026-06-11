using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model
{
    class User
    {
        public User()
        {
            
        }

        public User(string username, string email)
        {
            Username = username;
            Email = email;
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
  


        public User( string name, string surname,string username, string password,string email)
        {
            Username = username.Trim().ToLower();
            Password = password;
            Email = email.Trim().ToUpper();
            Name = name.Trim().ToUpper();
            Surname = surname.Trim().ToUpper();

        }
       
    }
}

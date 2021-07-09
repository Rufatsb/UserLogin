using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class UserInfo
    {
        public List<User> Users { get; set; }
        public UserInfo()
        {
            Users = new List<User>();
        }


        public User FindUser(string username, string password)
        {
            foreach (User user in Users)
            {
                if (user.Name == username && user.Password == password)
                {
                    
                    return user;
                }
            }
            Console.WriteLine("Ugurla daxil oldunuz.");
            return null;
        }
       
            public void CreateAccount(string name, string surname, string username, string password, string email)
            {
                User User = FindUser(username,password);
                if (username != null && password != null && email != null && name != null && surname != null)
                {

                    if (email.Contains('@'))
                    {
                        User user = new User(name, surname, username, password, email);
                        List<User> Users = new List<User>();
                       

                        Users.Add(user);
                        




                    }
                    else
                    {

                        Console.WriteLine("Email adresini duzgun daxil edin meselen: exclusive@gmail.com");

                    }
                }
                else
                {
                    throw new NullReferenceException("Name,Surname,Username,Password,Email xanalari bos buraxila bilmez.");
                }

               
            }


        }
    }

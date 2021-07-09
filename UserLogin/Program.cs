using System;

namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInfo uinfo = new UserInfo();
            string answer;

            do
            {
                Console.WriteLine("\n-------------------------------------------\n");


                Console.WriteLine("1.1 - Hesab yaradin");
                
                Console.WriteLine("1.2 - Hesabiniza daxil olun.");
                Console.WriteLine("2 - Cixis");

                Console.WriteLine("\nIcra etmek istediyiniz emeliyyati secin:");
                answer = Console.ReadLine();


                Console.WriteLine("\n-------------------------------------------\n");


                switch (answer)
                {
                    case "1.1":
                        CreateAccount(uinfo);

                        break;
                   case "1.2":
                        UserLogin(uinfo);
                        break;

                    default:
                        if (answer != "2")
                        {
                            Console.WriteLine("Duzgun deyer daxil edilmedi");
                        }
                        break;

                }

            } while (answer != "2");
        }
        static void CreateAccount(UserInfo uinfo)
        {
            Console.WriteLine("Adinizi daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadinizi daxil edin");
            string surname = Console.ReadLine();
            Console.WriteLine("Istifadeci adinizi daxil edin");
            string username = Console.ReadLine();
            Console.WriteLine("Emailinizi daxil edin");
            string email = Console.ReadLine();
            Console.WriteLine("Sifrenizi daxil edin");
            string password = Console.ReadLine();
            if (name.Length>=2 && surname.Length>=2 && username.Length>=3 && password.Length>=6)
            {
                uinfo.CreateAccount(name, surname, username, password, email);
            }
            else
            {
                Console.WriteLine("Iki herfden kicik ad daxil edile bilmez,iki herfden kicik soyad daxil edile bilmez,username minimum 3 herf,reqemden ibaret olmalidir,sifre  minimum 6 herf,reqemden ibaret olmalidir");
            }


           
        }
        static void UserLogin(UserInfo uinfo)
        {
            Console.WriteLine("Hesabiniza daxil olmaq ucun istifadeci adi ve sifrenizi daxil edin.");
            Console.WriteLine("Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Sifre:");
            string password = Console.ReadLine();
            uinfo.FindUser(username, password);
           
        }
    }
    }


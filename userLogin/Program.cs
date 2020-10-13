using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace userLogin
{
     public class Program
    {

        public static void error(string errorMsg)
        {
            Console.WriteLine(errorMsg);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("insert username and password");
            string name;
            string pass;



            name = Console.ReadLine();
            pass = Console.ReadLine();

            User user = new User();

            LoginValidation log1 = new LoginValidation(name, pass, error);

            if (log1.ValidateUserInput(ref user) == true )
            {
                Console.WriteLine(user.name + " " + user.pass + " " + user.number + " " + user.role + " " + user.Created);
                Console.ReadLine();
                UserRoles ur = LoginValidation.currentUserRole;
                switch (ur)
                {
                    case UserRoles.ANONYMOUS:
                        Console.WriteLine("you are anonymous");
                        break;
                    case UserRoles.ADMIN:
                        Console.WriteLine("you are admin");
                        break;
                    case UserRoles.INSPECTOR:
                        Console.WriteLine("you are inspector");
                        break;
                    case UserRoles.PROFESSOR:
                        Console.WriteLine("you are profesor");
                        break;
                    case UserRoles.STUDENT:
                        Console.WriteLine("you are student");
                        break;
                    default:
                        Console.WriteLine("no role");
                        break;
                }

                if (user.role == 1)
                {
                    Console.WriteLine("choose option");
                    Console.WriteLine("0: exit");
                    Console.WriteLine("1: change user role");
                    Console.WriteLine("2: change user active date");
                    Console.WriteLine("3: list all users");
                    Console.WriteLine("4: show log file");
                    Console.WriteLine("5: show current activity");
                    int a = Convert.ToInt32(Console.ReadLine());
                    switch (a)
                    {
                        case 0:
                            break;
                        case 1:
                            Console.WriteLine("please enter username");
                            string username = Console.ReadLine();
                            Console.WriteLine("please enter role");
                            int role = Console.Read();
                            UserData.AssignUserRole(username, role);
                            break;
                        case 2:
                            Console.WriteLine("please enter username");
                            string username2 = Console.ReadLine();
                            Console.WriteLine("please enter date");
                            string date = Console.ReadLine();
                            DateTime dt = Convert.ToDateTime(date);
                            UserData.SetUserActiveTo(username2, dt);
                            break;
                        case 3:
                            Console.WriteLine("list all users");

                            break;
                        case 4:
                            StreamReader sr = new StreamReader("Text.txt");
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                            sr.Close();
                            break;
                        case 5:
                            Console.WriteLine(Logger.CurrentSessionActivities);
                            break;
                    }
                }
                //Console.WriteLine(LoginValidation.currentUserRole.GetType());
                //Console.ReadLine();


            }

            Console.ReadLine();
        }
    }
}

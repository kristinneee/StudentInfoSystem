using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace userLogin
{
     public class UserData
    {
       static private List<User> testUser = new List<User>();
        static public List<User> TestUsers
        {
            get
            {
                ResetTestUserData();
                return testUser;
            }
            set { testUser = value; }
        }

        static public void SetUserActiveTo(string username, DateTime newDate)
        {
           
            UserContext context = new UserContext();
            User usr = (from u in UserData.TestUsers where u.name == username select u).First();
            usr.activeUntil = newDate;
            Logger.LogActivity("change activity of " + username);
            context.SaveChanges();

        }

        static public void AssignUserRole(string username, int newRole)
        {
            
            UserContext context = new UserContext();
            User usr = (from u in UserData.TestUsers where u.name == username select u).First();
            usr.role = newRole;
            Logger.LogActivity("change role of" + username);
            context.SaveChanges();


        }


        static private void ResetTestUserData()
        { //testUser.Add(null);


            if (testUser.Count == 0)
            {
                User u1 = new User

                {
                    name = "krisi",
                    pass = "44434",
                    number = 121217051,
                    role = 1,
                    Created = DateTime.Now,
                    activeUntil = DateTime.MaxValue
                };
                testUser.Add(u1);




                User u2 = new User
                {
                    name = "Kristine",
                    pass = "44424",
                    number = 121217017,
                    role = 4,
                    Created = DateTime.Now,
                    activeUntil = DateTime.MaxValue
                };
                testUser.Add(u2);




                User u3 = new User
                {
                    name = "hrisi",
                    pass = "44454",
                    number = 121217045,
                    role = 4,
                    Created=DateTime.Parse("22.12.2004"),
                    activeUntil=DateTime.Parse("22.12.2008")
                 
                   // Created = DateTime.Now,
                    //activeUntil = DateTime.MaxValue
                };
                testUser.Add(u3);
            }
        
        }
        static public User isUserPassCorrect(string username, string pass)
        {
            UserContext context = new UserContext();
            User result = (from u in UserData.TestUsers where u.name == username && u.pass == pass select u).First();
            return result;
                
        }
       
    }
}


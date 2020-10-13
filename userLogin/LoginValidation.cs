using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace userLogin
{
   public class LoginValidation
    {
        private string username;
        private string password;
        private string errorMsg;

        public delegate void ActionOnError(string errorMsg);
        private ActionOnError ac;

        public ActionOnError Ac
        {
            get { return ac; }
            set { ac = value; }
        }

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
        public string ErrorMsg
        {
            get { return errorMsg; }
            set { errorMsg = value; }
        }

        public LoginValidation(string username, string password, ActionOnError ac)
        {
            Username = username;
            Password = password;
            Ac = ac;
        }

        static public UserRoles currentUserRole
        {
            get;
            private set;
        }

        public Boolean ValidateUserInput(ref User user)
        {

            // user = UserData.isUserPassCorrect(Username, Password);
            Boolean emptyUserName;
            emptyUserName = Username.Equals(String.Empty);
            if (emptyUserName == true)
            {
                ErrorMsg = "Не е посочено потребителско име";
                Ac(ErrorMsg);
                return false;
            }

            Boolean emptyPassword;
            emptyPassword = Password.Equals(String.Empty);
            if (emptyPassword == true)
            {
                ErrorMsg = "Не е посочена парола";
                Ac(ErrorMsg);
                return false;
            }

            if (Username.Length < 5 || Password.Length < 5)
            {
                ErrorMsg = "Too short";
                Console.WriteLine(ErrorMsg);
                Ac(ErrorMsg);
                return false;

            }
            if (UserData.isUserPassCorrect(Username, Password) != null)
            {
                user = UserData.isUserPassCorrect(Username, Password);
                currentUserRole = (UserRoles)user.role;
                if (!(user.activeUntil.Equals(DateTime.MaxValue)))
                {
                    {
                        if (File.Exists("Text.txt") == true)
                        {

                            string s = "not active";
                            File.AppendAllText("Text.txt", s);
                            Console.WriteLine(s);
                            Console.ReadLine();
                        }


                    }

                }
            }
            
            else
            {
                ErrorMsg = "do not exist";
                currentUserRole = UserRoles.ANONYMOUS;
                Ac(ErrorMsg);
                return false;
            };
            Logger.LogActivity("succesful login");

            return true;

        }
    }
}

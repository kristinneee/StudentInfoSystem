using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace userLogin
{
    static public class Logger
    {
        static private List<string> currentSessionActivities = new List<string>();
        static public List<string> CurrentSessionActivities
        {
            get
            {
                return currentSessionActivities;
            }
            set { currentSessionActivities = value; }
        }

        static public void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + ";"
                //+ LoginValidation.currentUserUsername + ";"
                + LoginValidation.currentUserRole + ";"
                + activity;

            if (File.Exists("Text.txt") == true)
            {
                File.AppendAllText("Text.txt", activityLine);
            }
            currentSessionActivities.Add(activityLine);

        }

    }
}

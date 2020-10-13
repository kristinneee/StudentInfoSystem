using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using userLogin;
namespace StudentInfoSystem
{
    public class StudentData
    {

        private List<Student> testStudents = new List<Student>();

        public  List<Student> TestStudents
        {
            get {
                Add();
                return testStudents; }
            set { testStudents = value; }
        }
       public void  Add() {
            Student student1 = new Student()

            {  name = "Kristine",
                secondName = "Petkova",
                thirdName = "Ivanova",
                faculty = "FKSU",
                spec = "KSI",
                stepen = "Bakalavyr",
                status = "Zaveril",
                number = 121217017,
                kurs = "3",
                potok = "9",
                grupa = "40"

            };
            testStudents.Add(student1);
           

        }
       
        //StudentInfoContext context = new StudentInfoContext();
        public bool TestStudentsIfEmpty()
        {
            StudentInfoContext context = new StudentInfoContext();
            IEnumerable<Student> quertyStudents = context.Students;
            int? countStudents = quertyStudents.Count();

            if (quertyStudents == null)
            {
                return true;
            }
            else { return false; }
            
                 
        }
        User user1 = new User();
        StudentInfoContext context = new StudentInfoContext();
       

        public void CopyTestStudents()
        {
           // StudentInfoContext context = new StudentInfoContext();
            foreach (Student st in TestStudents)
            {
                context.Students.Add(st);
            }
            context.SaveChanges();
            if (TestStudentsIfEmpty())
                CopyTestStudents();


           

        }
        public void CopyTestUsers()
        {
            UserContext context = new UserContext();
            StudentData studentdata = new StudentData();
            foreach (User user in UserData.TestUsers)
            {
                context.Users.Add(user);
            }
            context.SaveChanges();
        }

        public  Student IsThereStudent()
        {
            User user1 = new User();
            StudentInfoContext context = new StudentInfoContext();
            

                Student result = (from st in context.Students where st.number == user1.number select st).First();
            

                return result;
            
        }
    }
}

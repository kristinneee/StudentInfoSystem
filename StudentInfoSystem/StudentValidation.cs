using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using userLogin;
namespace StudentInfoSystem
{
   public class StudentValidation
    {
        public  Student GetStudentDataByUser(User user1) {
            Student student = new Student();
            {
                if (user1.number == 0 || user1.number != student.number)
            
                Console.WriteLine("Incorrect number");
            }
            return student;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using userLogin;
namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow1.xaml
    /// </summary>
    public partial class MainWindow1 : Window
    {
        public MainWindow1()
        {
            InitializeComponent();
         
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
          

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            LoginValidation loginValidation = new LoginValidation(txt1.Text, txt2.Text, Program.error);
            User user= null;
            if (loginValidation.ValidateUserInput(ref user) && user.role == 4)
            {

                MainWindow mainWindow = new MainWindow();
                mainWindow.GetStudent(user.number);
                mainWindow.Show();
                this.Close();


            }
            else {
                MessageBox.Show("Error");
            }
            





            /*foreach (User user in UserData.TestUsers)
            {
                if (txt1.Text.Equals(user.name) && (txt2.Text.Equals(user.pass)) && (user.role == 4))
                {
                    //MainWindow mainWindow = new MainWindow();
                    StudentData studentData = new StudentData();
                    foreach (Student student in studentData.TestStudents)
                    {
                        if (student.number == user.number)
                        {
                            MainWindow mainWindow = new MainWindow();
                            mainWindow.GetStudent();
                            mainWindow.Show();
                            this.Close();
                        }
                    }

                }
                else { continue; }
            }*/

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("IF YOU HAVE ANY PROBLEMS WITH LOGIN, READ THE FOLLOWING  REQUIREMENTS ABOUT THE USER NAME AND PASSWORD\n" +
                "1.You must be a Student\n" +
                "2.Your user name should be at least 5 characters long\n" +
                "3.Your password should be at least 5 characters long");
           

        }
    }
}

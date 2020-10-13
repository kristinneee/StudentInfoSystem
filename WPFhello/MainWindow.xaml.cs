using StudentInfoSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFhello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string s;

        public MainWindow()
        {
            InitializeComponent();
            ListBoxItem james = new ListBoxItem();
            james.Content = "James";
            peopleListBox.Items.Add(james);
            ListBoxItem david = new ListBoxItem();
            david.Content = "David";
            peopleListBox.Items.Add(david);
            peopleListBox.SelectedItem = james;
        }

        private void bthHello_Click(object sender, RoutedEventArgs e)
        {  foreach (var item in MainGrid.Children) {
            
                if (item is TextBox) {
                    s = s + ((TextBox)item).Text;
                    s = s + "\n";

                }

            }
            if (txtName.Text.Length >= 2)
            {
                MessageBox.Show("Здрасти" + txtName.Text + "!!!\nТова е твоята първа програма на VS!");
            }
            else {
                MessageBox.Show("Не достатъчно дълго име!");
            }



        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Form1_FormClosing(object sender,System.ComponentModel.CancelEventArgs e)
        {

            const string message = "Are you sure?";
            const string caption = "Form closing";
            var result = MessageBox.Show(message, caption, MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.No)
            
            {
                e.Cancel = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyMessage anotherWindow = new MyMessage();
            anotherWindow.Show();
            MessageBox.Show("This is Windows Presentation Foundation");
            textBlock1.Text = DateTime.Now.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string greetingMsg;
            greetingMsg = (peopleListBox.SelectedItem as ListBoxItem).Content.ToString();
            MessageBox.Show("Hi " + greetingMsg);
        }
    }

    internal class DialogResult
    {
        public static explicit operator DialogResult(MessageBoxResult v)
        {
            throw new NotImplementedException();
            
        }
    }

}

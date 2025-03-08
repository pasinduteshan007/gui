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

namespace AutoCarePro
{
  
    public partial class signuppage : Window
    {
        public signuppage()
        {
            InitializeComponent();
        }
        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
           
            string name = NameTextBox.Text;
            string email = EmailTextBox.Text;
            string contactNumber = ContactNumberTextBox.Text;
            string address = AddressTextBox.Text;
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

           
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(contactNumber) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields are required. Please fill them out.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

           
            MessageBox.Show("Sign-up successful! Welcome to AutoCare Pro.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

           
            this.Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {

            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}

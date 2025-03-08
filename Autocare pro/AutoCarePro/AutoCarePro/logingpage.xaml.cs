using System.Windows;
using System.Windows.Controls;

namespace AutoCarePro
{
    public partial class LoginPage : Window 
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text; 
            string password = PasswordBox.Password; 

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            MessageBox.Show("Login successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}

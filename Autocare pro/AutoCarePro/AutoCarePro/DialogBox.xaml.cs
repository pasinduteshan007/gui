using System.ComponentModel.Design.Serialization;
using System.Windows;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AutoCarePro
{
    public partial class DialogBox : Window
    {
        
        public string IssueType { get; private set; }
        public string vehicalbrand { get; private set; }
        public string branch { get; private set; }

        public DialogBox(Product existing = null)
        {
            InitializeComponent();

            if (existing != null)
            {
                txtName.Text = existing.IssueType;
                txtField2.Text = existing.vehicalbrand;
                txtbranch.Text = existing.branch;
            }
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) &&
                !string.IsNullOrWhiteSpace(txtField2.Text) &&
                !string.IsNullOrWhiteSpace(txtbranch.Text))
            {
                IssueType = txtName.Text;
                vehicalbrand = txtField2.Text;
                 branch = txtbranch.Text;
                DialogResult = true;
            }
            else
            {
                MessageBox.Show("Please enter valid details.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    



    }
}

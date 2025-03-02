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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoginApplication
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void OnLoginButtonClicked(object sender, RoutedEventArgs e)
        {
            string password = LoginPasswordBox.Password;
            string? envPw = Environment.GetEnvironmentVariable("InvoiceManagement");
            if (envPw != null)
            {
                if (password == envPw)
                {
                    MessageBox.Show("Entered correct Password");
                }
                else
                {
                    MessageBox.Show("Entered wrong password");
                }
            }
            else
            {
                MessageBox.Show("Environment variable not found");
            }
        }

        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(LoginPasswordBox.Password))
            {
                LoginButton.IsEnabled = true;
            }
            else
            {
                LoginButton.IsEnabled = false;
            }
        }
    }
}

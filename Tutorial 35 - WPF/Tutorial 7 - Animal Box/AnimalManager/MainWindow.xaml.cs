using System.Configuration;
using System.Windows;

namespace AnimalManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["AnimalManager.Properties.Settings.animalsConnectionString"].ConnectionString;
        }
    }
}

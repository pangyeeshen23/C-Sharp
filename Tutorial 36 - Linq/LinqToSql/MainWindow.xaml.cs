using System.Configuration;
using System.Windows;

namespace LinqToSql
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSqlDataClassesDataContext dataContext;
        public MainWindow()
        {
            string connectionString = ConfigurationManager
                .ConnectionStrings["LinqToSql.Properties.Settings.universityConnectionString"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);
            InitializeComponent();
        }
    }
}

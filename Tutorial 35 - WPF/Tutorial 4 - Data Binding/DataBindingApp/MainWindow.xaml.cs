using DataBindingApp.Data;
using System.Windows;

namespace DataBindingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person = new Person()
        {
            Name = "Ethan",
            Age = 23
        };

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string personData = person.Name + " is " + person.Age + " years old";
            MessageBox.Show(personData);
        }
    }
}
using DataBindingApp.Data;
using System.Windows;

namespace DataBindingApp
{
    /// <summary>
    /// Interaction logic for ListWindow.xaml
    /// </summary>
    public partial class ListWindow : Window
    {
        private List<Person> People = new List<Person>()
        {
            new Person()
            {
                Name = "Ethan",
                Age = 25
            },
            new Person()
            {
                Name = "Daniel",
                Age = 40
            },
            new Person()
            {
                Name = "Jonny",
                Age = 35
            },
            new Person()
            {
                Name = "Lucas",
                Age = 45
            }
        };

        public ListWindow()
        {
            InitializeComponent();
            ListBoxPeople.ItemsSource = People;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            var people = ListBoxPeople.SelectedItems;
            foreach (Person person in people)
            {
                MessageBox.Show("Name :" + person.Name + ", Age :" + person.Age);
            }
        }
    }
}

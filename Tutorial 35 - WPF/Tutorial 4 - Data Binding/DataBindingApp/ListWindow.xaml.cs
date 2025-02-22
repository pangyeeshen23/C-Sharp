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
            }
        };

        public ListWindow()
        {
            InitializeComponent();
            ListBoxPeople.ItemsSource = People;
        }
    }
}

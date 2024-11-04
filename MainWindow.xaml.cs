using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace powtorzenie;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        Person.People.Add(new Person("Kamil", 25));
        Person.People.Add(new Person("Adam", 30));
        Person.People.Add(new Person("Ewa", 20));
        
        dataGrid.ItemsSource = Person.People;
    }

    private void add(object sender, RoutedEventArgs e)
    {
        addWindow addWindow = new addWindow();
        addWindow.ShowDialog();

        int age;
        int.TryParse(addWindow.ageBox.Text, out age);
        if(age != 0)
        {
            Person.People.Add(new Person(addWindow.nameBox.Text, age));
            dataGrid.Items.Refresh();
        }
    }

    private void edit(object sender, RoutedEventArgs e)
    {
        var person = (Person)dataGrid.SelectedItem;
        if(person != null)
        {
            editWindow editWindow = new editWindow();
            editWindow.nameBox.Text = person.Name;
            editWindow.ageBox.Text = person.Age.ToString();
            editWindow.ShowDialog();
            
            int age;
            int.TryParse(editWindow.ageBox.Text, out age);
            if(age != 0)
            {
                person.Name = editWindow.nameBox.Text;
                person.Age = age;
                dataGrid.Items.Refresh();
            }
        }
    }

    private void delete(object sender, RoutedEventArgs e)
    {
        var person = (Person)dataGrid.SelectedItem;
        if (person != null)
        {
            var result = MessageBox.Show("Czy napwno chcesz usunąć obiekt?",
                "Delete", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                Person.People.Remove(person);
                dataGrid.Items.Refresh();
            }
        }
    }
}
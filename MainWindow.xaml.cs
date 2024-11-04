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
        
        Person.People.Add(new Person { Id = 1, Name = "John", Age = 25 });
        Person.People.Add(new Person { Id = 2, Name = "Jane", Age = 30 });
        Person.People.Add(new Person { Id = 3, Name = "Joe", Age = 35 });
        
        dataGrid.ItemsSource = Person.People;
    }

    private void add(object sender, RoutedEventArgs e)
    {
        addWindow addWindow = new addWindow();
        addWindow.ShowDialog();
    }

    private void edit(object sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void delete(object sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }
}
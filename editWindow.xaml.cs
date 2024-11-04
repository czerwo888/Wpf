using System.Windows;

namespace powtorzenie;

public partial class editWindow : Window
{
    public editWindow()
    {
        InitializeComponent();
    }

    private void edit(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
}
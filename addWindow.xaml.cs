using System.Windows;

namespace powtorzenie;

public partial class addWindow : Window
{
    public addWindow()
    {
        InitializeComponent();
    }

    private void add(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
}
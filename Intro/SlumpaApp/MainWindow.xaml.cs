using System.IO;
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

namespace SlumpaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void slumpafunktion(object sender, RoutedEventArgs e)
    {
        if (int.TryParse(gränsvärde.Text, out int userInput))
        {
        int slumptal = Random.Shared.Next(1, userInput);
        Resultat.Text = slumptal.ToString();
        }
        else{
            int slumptal2 = Random.Shared.Next(1, 100);
            Resultat.Text = slumptal2.ToString();

            Slut.Text = "Du gav in ogiltigt tal, slumpar standard 1-100";
        }

    }
}
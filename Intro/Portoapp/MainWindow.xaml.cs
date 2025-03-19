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

namespace Portoapp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Räkna(object sender, RoutedEventArgs e)
    {
        if (int.TryParse(Vikt.Text, out int vikt))
        {
            string output = BeraknaPorto(vikt);
            Resultat.Content = output;
        }
        else
        {
            Resultat.Content = "ogiltig vikt.";
        }
    }

    private string BeraknaPorto(int vikt)
    {
        if (vikt <= 50)
        {
            return $"Brev som väger {vikt} kostar 22 sek(1 frimärke)";
        }
        else if (vikt <= 100)
        {
            return $"Brev som väger {vikt} kostar 44 sek(2 frimärke)";
        }
        else if (vikt <= 250)
        {
            return $"Brev som väger {vikt} kostar 66 sek(3 frimärke)";
        }
        else if (vikt <= 500)
        {
            return $"Brev som väger {vikt} kostar 88 sek(4 frimärke)";
        }
        else if (vikt <= 1000)
        {
            return $"Brev som väger {vikt} kostar 132 sek(6 frimärke)";
        }
        else if (vikt <= 2000)
        {
            return $"Brev som väger {vikt} kostar 154 sek(7 frimärke)";
        }
        else
        {
            return $"Vikten överstiger maximala tillåtna";
        }
    }
}
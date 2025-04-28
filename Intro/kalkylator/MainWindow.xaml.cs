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

namespace kalkylator;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickPlus(object sender, RoutedEventArgs e)
    {
        string tal1 = txbTal1.Text;
        string tal2 = txbTal2.Text;
        
        double.TryParse(tal1, out double tal1int);
        double.TryParse(tal2, out double tal2int);

        double resultat = tal1int + tal2int;
        txbResult.Text = $"{tal1int} + {tal2int} = {resultat}";
        //txbResult.Text = $"{resultat}";
    }

    private void KlickMinus(object sender, RoutedEventArgs e)
    {
        string tal1 = txbTal1.Text;
        string tal2 = txbTal2.Text;
        
        double.TryParse(tal1, out double tal1int);
        double.TryParse(tal2, out double tal2int);

        double resultat = tal1int - tal2int;
        txbResult.Text = $"{tal1int} - {tal2int} = {resultat}";
    }

    private void KlickGånger(object sender, RoutedEventArgs e)
    {
        string tal1 = txbTal1.Text;
        string tal2 = txbTal2.Text;
        
        double.TryParse(tal1, out double tal1int);
        double.TryParse(tal2, out double tal2int);

        double resultat = tal1int * tal2int;
        txbResult.Text = $"{tal1int} * {tal2int} = {resultat}";
    }

    private void KlickDela(object sender, RoutedEventArgs e)
    {
        string tal1 = txbTal1.Text;
        string tal2 = txbTal2.Text;
        
        double.TryParse(tal1, out double tal1int);
        double.TryParse(tal2, out double tal2int);

        double resultat = tal1int / tal2int;
        txbResult.Text = $"{tal1int} / {tal2int} = {resultat}";
    }
}
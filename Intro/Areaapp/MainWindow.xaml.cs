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

namespace Areaapp;

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
        //int bredd = int.Parse(Bredd.Text);
        //int höjd = int.Parse(Höjd.Text);

        if (!int.TryParse(Bredd.Text, out int bredd))
        {
            Resultat.Text = "Fel på bredd, du måste ange ett heltal!";
            return;
        }

        if (!int.TryParse(Höjd.Text, out int höjd))
        {
            Resultat.Text = "Fel på höjd, du måste ange ett heltal!";
            return;
        }

        int area = bredd * höjd;

        Resultat.Text = area.ToString();
    }

    private void rensa(object sender, RoutedEventArgs e)
    {
        Bredd.Clear();
        Höjd.Clear();
        Resultat.Clear();
    }
}
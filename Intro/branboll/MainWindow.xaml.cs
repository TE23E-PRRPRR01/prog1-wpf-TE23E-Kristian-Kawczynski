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

namespace branboll;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
        int poängInne = 0;
        int poängUte = 0;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickFriVarv(object sender, RoutedEventArgs e)
    {

        poängInne += 5;

        txbInne.Text = $"{poängInne}";

        DateTime nu= DateTime.Now;

        txbHistorik.Text = $"{nu.ToString("HH:mm:ss")}\nLag inne +5, totalt: {poängInne}";
    }

    private void KlickBränning(object sender, RoutedEventArgs e)
    {
        poängUte += 2;

        txbUte.Text = $"{poängUte}";

        DateTime nu= DateTime.Now;

        txbHistorik.Text = $"{nu.ToString("HH:mm:ss")}\nLag ute +2, totalt: {poängUte}";
    }

    private void KlickLyra(object sender, RoutedEventArgs e)
    {
         poängUte += 3;

         txbUte.Text = $"{poängUte}";

         DateTime nu= DateTime.Now;

          txbHistorik.Text = $"{nu.ToString("HH:mm:ss")}\nLag ute +3, totalt: {poängUte}";
    }

    private void KlickVarv(object sender, RoutedEventArgs e)
    {
        poängInne += 1;

        txbInne.Text = $"{poängInne}";

        DateTime nu= DateTime.Now;

         txbHistorik.Text = $"{nu.ToString("HH:mm:ss")}\nLag inne +1, totalt: {poängInne}";
    }

}
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
using System.Net.Http;
using System.Net.Http.Json;

namespace Chatai;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    HttpClient klient = new HttpClient();
    string url = "http://10.151.168.5:11343/api/generate";

    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickSkicka(object sender, RoutedEventArgs e)
    {
        string prompt = txbPrompt.Text;

        object data = new
        {
            model = "phi4:latest",
            prompt = prompt,
            max_tokens = 50
        };

        SkickaTillOllama(data);

    }

    public void SkickaTillOllama(object data)
    {
        try
        {
            HttpResponseMessage svar = klient.PostAsJsonAsync(url, data).Result;

            svar.EnsureSuccessStatusCode();

            string råtext = svar.Content.ReadAsStringAsync().Result;

            string[] rader = råtext.Split("\n");

            foreach (string rad in rader)
            {
                if (rad.Contains("response"))
                {
                    PlockaUtToken(rad);
                }
            }
        }
        catch (HttpRequestException e)
        {
            txbSvar.Text = $"Fel: {e.Message}";
        }
    }

    public string PlockaUtToken(string rad)
    {
        int start = rad.IndexOf("response") + 11;
        int slut = rad.IndexOf("\"", start);

        return rad.Substring(start, slut -start);
    }
}
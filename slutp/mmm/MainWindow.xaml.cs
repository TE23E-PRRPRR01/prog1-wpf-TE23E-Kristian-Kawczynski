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

namespace mmm;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
List<string> ListTask = [];

    private void KlickAdd(object sender, RoutedEventArgs e)
    {
        string newTask = txbTaskInput.Text;

        if (newTask == "")
        {
            txbTaskDisplay.Text = "Please enter a task";
        }
        else if (ListTask.Contains(newTask))
        {
            txbTaskDisplay.Text = "This task already exists";
        }
        else
        {
            txbTaskDisplay.Text = "Task added!";

            ListTask.Add(newTask);
        }
    }

    private void KlickHistory(object sender, RoutedEventArgs e)
    {
        txbTaskDisplay.Text = "";

        foreach (var task in ListTask)
        {
            txbTaskDisplay.Text += task + "\n";
        }
    }

    private void KlickClear(object sender, RoutedEventArgs e)
    {
        txbTaskDisplay.Text = "";
    }

    private void KlickDelete(object sender, RoutedEventArgs e)
    {
        string del = txbTaskDel.Text;

        if (del == "")
        {
            txbTaskDisplay.Text = "Please enter a task";
        }
        else if (ListTask.Contains(del))
        {
            ListTask.Remove(del);
        }
        else
        {
            txbTaskDisplay.Text = "There is no such task, Try again!";
        }
    }
}
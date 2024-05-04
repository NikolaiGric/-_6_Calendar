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
using С_6_Calendar.View;
using С_6_Calendar.ViewModel;

namespace С_6_Calendar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime date;
        public MainWindow()
        {
            InitializeComponent();
            date = DateTime.Now;
            info.Content = date.ToString("MMMM yyyy");
            Cartochki();
        }

        private void y_Click(object sender, RoutedEventArgs e)
        {
            date = date.AddMonths(1);
            info.Content = date.ToString("MMMM yyyy");
            Cartochki();
        }

        private void z_Click(object sender, RoutedEventArgs e)
        {
            date = date.AddMonths(-1);
            info.Content = date.ToString("MMMM yyyy");
            Cartochki();
        }

        public void Cartochki()
        {
            AllWrapPanel.Children.Clear();
            int num = DateTime.DaysInMonth(date.Year, date.Month);
            for (int i = 1; i <= num; i++)
            {
                USA usa = new USA();
                usa.date = i.ToString();
                AllWrapPanel.Children.Add(usa);
            }
        }
    }
}
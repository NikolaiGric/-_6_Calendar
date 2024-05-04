using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using С_6_Calendar.ViewModel;

namespace С_6_Calendar.View
{
    /// <summary>
    /// Логика взаимодействия для USA.xaml
    /// </summary>
    public partial class USA : UserControl
    {
        public string date { get; set; }
        public USA()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}

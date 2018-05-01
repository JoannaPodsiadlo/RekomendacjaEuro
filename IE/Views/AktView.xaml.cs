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

namespace IE.Views
{
    /// <summary>
    /// Logika interakcji dla klasy AktView.xaml
    /// </summary>
    public partial class AktView : UserControl
    {
        public AktView()
        {
            InitializeComponent();
            frame1.Navigate(new Uri("https://www.paszport.ws/"));
           
        }

        private void btn1Content_Click(object sender, RoutedEventArgs e)
        {
           frame1.Navigate(new Uri("https://www.paszport.ws/")); //dziala ok jak sie nacisnie Tak, jeden skrypt wyrzuca(ewentualnie)
        }

        private void btn3Content_Click(object sender, RoutedEventArgs e)
        {
            frame1.Navigate(new Uri("https://www.bankier.pl/waluty")); //ok
        }

        private void btn2Content_Click(object sender, RoutedEventArgs e)
        {
           frame1.Navigate(new Uri("http://waluty.com.pl/s30-wiadomosci___rynek_walutowy__forex.html"));//wyrzuca kilka skryptow(2)
        }
    }
}

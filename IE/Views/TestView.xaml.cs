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
    /// Logika interakcji dla klasy TestView.xaml
    /// </summary>
    public partial class TestView : UserControl
    {
        int points;
        int odp1;
        int odp3;
        int odp4;
        bool clicked;

        public TestView()
        {
            InitializeComponent();
           

        }

        private void Checking()
        {
            if (Odp1a.IsChecked.Value)
            {
                odp1 += 1;
            }
            if (Odp1b.IsChecked.Value)
            {
                odp1 += 1;
            }
            if (Odp1c.IsChecked.Value)
            {
                odp1 += 1;
            }
            if (Odp1d.IsChecked.Value)
            {
                odp1 += 1;
            }
            if (odp1 > 1)
            {
                MessageBox.Show("Zaznaczyłeś więcej niż jedną odpowiedź w zadaniu 1");
              
            }
            else if (odp1 == 0)
            {
                MessageBox.Show("Nie zaznaczyłeś żadnej odpowiedzi w zadaniu 1");
            }
            if (Odp2.Text == "")
            {
                MessageBox.Show("Nie odpowiedziałeś na pytanie 2");
            }
            if (Odp3moze.IsChecked.Value)
            {
                odp3 += 1;
            }
            if (Odp3nie.IsChecked.Value)
            {
                odp3 += 1;
            }
            if (Odp3tak.IsChecked.Value)
            {
                odp3 += 1;
            }
            if (odp3 > 1)
            {
                MessageBox.Show("Zaznaczyłeś więcej niż jedną odpowiedź w zadaniu 3");
               
            }
            else if (odp3 == 0)
            {
                MessageBox.Show("Nie zaznaczyłeś żadnej odpowiedzi w zadaniu 3");
            }
            if (Odp4nie.IsChecked.Value)
            {
                odp4 += 1;
            }
            if (Odp4tak.IsChecked.Value)
            {
                odp4 += 1;
            }
            if (odp4 > 1)
            {
                MessageBox.Show("Zaznaczyłeś więcej niż jedną odpowiedź w zadaniu 4");
                
            }
            else if (odp4 == 0)
            {
                MessageBox.Show("Nie zaznaczyłeś żadnej odpowiedzi w zadaniu 4");
            }
        }

        private void Points()
        {
            if (Odp1a.IsChecked.Value)
            {
                points += 100;
            }
            if (Odp1b.IsChecked.Value)
            {
                points += 1;
            }
            if (Odp1c.IsChecked.Value)
            {
                points += 0;
            }
            if (Odp1d.IsChecked.Value)
            {
                points += 1;
            }
            if (Odp3moze.IsChecked.Value)
            {
                points += 0;
            }
            if (Odp3nie.IsChecked.Value)
            {
                points += 1;
            }
            if (Odp3tak.IsChecked.Value)
            {
                points += 100;
            }
            if (Odp4nie.IsChecked.Value)
            {
                points += 1;
            }
            if (Odp4tak.IsChecked.Value)
            {
                points += 100;
            }
            if (Odp2.Text != "0")
            {
                points += 50;
            }
            if (points > 100)
            {
                MessageBox.Show("JESTEŚ ZDECYDOWNIE RYZYKANTEM!");
            }
            if (points < 100 && points > 50)
            {
                MessageBox.Show("LUBISZ RYZYKO");
            }
            if (points <= 50)
            {
                MessageBox.Show("NIE JESTEŚ RYZYKANTEM");

            }
        }

        private void NextPytContent_Click(object sender, RoutedEventArgs e)
        {
            odp1 = 0;
            odp3 = 0;
            odp4 = 0;
            clicked = true;
            Checking();
           
            

        }

        private void RezultatContent_Click(object sender, RoutedEventArgs e)
        {
            if (clicked) { 
                points = 0;
                Points(); }
            else{
                MessageBox.Show("Nie zatwierdziles!");
            }
        }
    }
}

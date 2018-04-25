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
        private int points;
        private int ex1;
        private bool ex2;
        private bool ex3;
        private bool ex4;

        public TestView()
        {
            InitializeComponent();
            points = 0;
            ex1 = 0;
            ex2 = false;
            ex3 = false;
            ex4 = false;
            string pom = Cena.Text;
            if (pom == "0") points += 0;
            else points += 10;
            Question_1();
            if (ex1 > 1) MessageBox.Show("Zaznaczyles wiecej niz jedną odpowiedź");

        }

        private int Question_1()
        {

            if (CheckBox1a.IsChecked ?? true)
            {
                ex1 += 1;
            }
            if (CheckBox1b.IsChecked ?? false)
            {
                ex1 += 1;
            }
            if (CheckBox1c.IsChecked ?? false)
            {
                ex1 += 1;
            }
            if (CheckBox1d.IsChecked ?? false)
            {
                ex1 += 1;
            }

            return ex1;
                
        }


        private void CheckBox1a_Checked(object sender, RoutedEventArgs e)
        {
            points += 10;
            
        }

        private void CheckBox1b_Checked(object sender, RoutedEventArgs e)
        {
            points += 3;
           
        }
        private void CheckBox1c_Checked(object sender, RoutedEventArgs e)
        {
            points += 2;
            
        }
        private void CheckBox1d_Checked(object sender, RoutedEventArgs e)
        {
            points += 0;
            
        }

        private void Tak3_Checked(object sender, RoutedEventArgs e)
        {
          
            points += 5;
        }
        private void Nie3_Checked(object sender, RoutedEventArgs e)
        {
            points += 6;
        }
        private void Tak4_Checked(object sender, RoutedEventArgs e)
        {
            points += 7;
        }
        private void Nie4_Checked(object sender, RoutedEventArgs e)
        {
            points += 8;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            if (points == 0)
                MessageBox.Show("Słaby z Ciebie ryzykant");
            else if (points < 4)
                MessageBox.Show("Nie najgorzej");
            else if (points < 10)
                MessageBox.Show("Calkiem calkiem");
            else MessageBox.Show("O rany rany ");
            points = 0;
           
        }
    }
}

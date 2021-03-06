﻿using System;
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
using IE.ViewModels;

namespace IE
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StartViewModel start = new StartViewModel();
            this.Visibility = Visibility.Visible;
        }
        private void ButtonPower_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Navigation_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new StartViewModel();
        }
        private void ButtonPrognoza_Click(object sender, RoutedEventArgs e)
        {
			DataContext = new PrognozaViewModel();
        }
		private void ButtonRyzyko_Click(object sender, RoutedEventArgs e)
		{
			DataContext = new RyzykoViewModel();
		}
		private void ButtonAkt_Click(object sender, RoutedEventArgs e)
		{
			DataContext = new AktViewModel();
		}
		private void ButtonTest_Click(object sender, RoutedEventArgs e)
		{
			DataContext = new TestViewModel();
		}
		private void ButtonoNas_Click(object sender, RoutedEventArgs e)
		{
			DataContext = new ONasViewModel();
		}
	}
}

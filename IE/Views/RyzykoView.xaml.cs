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

namespace IE.Views
{
	/// <summary>
	/// Logika interakcji dla klasy RyzykoView.xaml
	/// </summary>
	public partial class RyzykoView : UserControl
	{
		public RyzykoView()
		{
			InitializeComponent();
		}

		private void ButtonRyzyko1_Click(object sender, RoutedEventArgs e)
		{
			DataContext = new Ryzyko1View();
		}
	}
}

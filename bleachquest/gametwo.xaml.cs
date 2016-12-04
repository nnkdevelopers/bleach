using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace bleachquest
{
	/// <summary>
	/// Interaction logic for gametwo.xaml
	/// </summary>
	public partial class gametwo : Window
	{ double a ;
		public gametwo()
		{
			
			this.InitializeComponent();
			 
			a = 0;
			// Insert code required on object creation below this point.
		}

		private void o1_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			  if ((o1move.X > 507)  && (o1move.X < 521) && (o1move.Y >35) && (o1move.Y <64)) {o1.IsEnabled = false; a= a+1;}// TODO: Add event handler implementation here.
		}

		private void o2_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if ((o2move.X > 61)  && (o2move.X < 91) && (o2move.Y >226) && (o2move.Y <258)) {o2.IsEnabled = false; a= a+1;}// TODO: Add event handler implementation here.
		}

		private void o3_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if ((o3move.X > 232)  && (o3move.X < 254) && (o3move.Y >226) && (o3move.Y <258)) {o3.IsEnabled = false; a= a+1;}// TODO: Add event handler implementation here.
		}
	}
}
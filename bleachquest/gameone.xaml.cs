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
	/// Interaction logic for gameone.xaml
	/// </summary>
	public partial class gameone : Window
	{
		double a;
		
		double  y,x;
		public gameone()
			
		{
			
			this.InitializeComponent();
			a = 0;
			// Insert code required on object creation below this point.
		}

		private void pazl1_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
		}

		private void pazl1_DragEnter(object sender, System.Windows.DragEventArgs e)
		{
			 // TODO: Add event handler implementation here.
		}

		private void pazl1_Drop(object sender, System.Windows.DragEventArgs e)
		{
			// TODO: Add event handler implementation here.
		}

		private void pazl1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
	
			// TODO: Add event handler implementation here.
		}

		private void pazl1_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
		}

		private void pazl1_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			  if ((move1.X > 430)  && (move1.X < 437) && (move1.Y >56) && (move1.Y <63)) {pazl1.IsEnabled = false; a= a+1;}// TODO: Add event handler implementation here.
		}

		private void Button_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
		}

		private void Image_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if ((move2.X > 555)  && (move2.X < 562) && (move2.Y >56) && (move2.Y <63)) {pazl2.IsEnabled = false; a= a+1;}// TODO: Add event handler implementation here.
		}

		private void pazl3_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if ((move3.X > 678)  && (move3.X < 683) && (move3.Y >56) && (move3.Y <63)) {pazl3.IsEnabled = false; a= a+1;}// TODO: Add event handler implementation here.
		}

		private void pazl4_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if ((move4.X > 802)  && (move4.X < 806) && (move4.Y >58) && (move4.Y <62)) {pazl4.IsEnabled = false; a= a+1;}// TODO: Add event handler implementation here.
		}

		private void pazl5_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if ((move5.X > 923)  && (move5.X < 926) && (move5.Y >58) && (move5.Y <62)) {pazl5.IsEnabled = false; a= a+1;}// TODO: Add event handler implementation here.
		}

		private void pazl6_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if ((move6.X > 430)  && (move6.X < 437) && (move6.Y >175) && (move6.Y <179)) {pazl6.IsEnabled = false; a= a+1;}// TODO: Add event handler implementation here.
		}

		private void pazl7_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if ((move7.X > 555)  && (move7.X < 562) && (move7.Y >175) && (move7.Y <179)) {pazl7.IsEnabled = false; a= a+1;}// TODO: Add event handler implementation here.
		}

		private void pazl8_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if ((move8.X > 678)  && (move8.X < 683) && (move8.Y >175) && (move8.Y <179)) {pazl8.IsEnabled = false; a= a+1;}// TODO: Add event handler implementation here.
		}

		private void pazl9_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if ((move9.X > 802)  && (move9.X < 806) && (move9.Y >175) && (move9.Y <179)) {pazl9.IsEnabled = false; a= a+1;}// TODO: Add event handler implementation here.
		}

		private void pazl10_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if ((move10.X > 923)  && (move10.X < 926) && (move10.Y >175) && (move10.Y <179)) {pazl10.IsEnabled = false; a= a+1;}// TODO: Add event handler implementation here.
		}

		private void pazl11_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if ((move11.X > 430)  && (move11.X < 437) && (move11.Y >292) && (move11.Y <295)) {pazl11.IsEnabled = false; a= a+1;}// TODO: Add event handler implementation here.
		}

		private void pazl12_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if ((move12.X > 555)  && (move12.X < 562) && (move12.Y >292) && (move12.Y <295)) {pazl12.IsEnabled = false; a= a+1;}// TODO: Add event handler implementation here.
		}

		private void pazl13_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if ((move13.X > 678)  && (move13.X < 683) && (move13.Y >292) && (move13.Y <295)) {pazl13.IsEnabled = false; a= a+1;}// TODO: Add event handler implementation here.
		}

		private void pazl14_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if ((move14.X > 802)  && (move14.X < 806) && (move14.Y >292) && (move14.Y <295)) {pazl14.IsEnabled = false; a= a+1;}// TODO: Add event handler implementation here.
		}

		private void pazl15_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if ((move15.X > 923)  && (move15.X < 926) && (move15.Y >292) && (move15.Y <295)) {pazl15.IsEnabled = false; a= a+1;}// TODO: Add event handler implementation here.
		}

		private void Window_Loaded(object sender, System.Windows.RoutedEventArgs e)
		{
			 MessageBox.Show (" Соберите пазл " , "Задание №1");
			// TODO: Add event handler implementation here.
		}

		private void next_Click(object sender, System.Windows.RoutedEventArgs e)
		{
					if (a == 15) {MessageBox.Show("Поздравляю вы собрали пазл" , "Победа" , MessageBoxButton.OK);}
					 else  {MessageBox.Show("Вы не собрали пазл. Пожалуйста соберите для перехода на следующий уровень");};// TODO: Add event handler implementation here.
		}
	}
}
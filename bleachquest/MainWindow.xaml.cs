using System;
using System.Collections.Generic;
using System.Linq;
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

namespace bleachquest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static public MediaPlayer player = new MediaPlayer();
        static bool gametwobool = false;//comment
        public MainWindow()
        {
            InitializeComponent();
            Uri music = new Uri(Environment.CurrentDirectory + "\\Anime - Bleach Sound Effect.mp3");
            player.Open(music);
            player.Volume = 0.5;
            player.Play();
            MessageBox.Show("cerf");
        }

        private void closeform_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	this.Close(); // TODO: Add event handler implementation here.
        }

        private void start_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            player.Stop();
            if (gametwobool == false) //проверяет старт  если форма создалась инвертирует bool в true
            {
                gametwo main = new gametwo(); main.Show();// TODO: Add event handler implementation here.*/ 
                gametwobool = true;  
            }
        }

        private void start_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {



        }

        private void Window_LostFocus(object sender, RoutedEventArgs e)
        {
            player.Volume = 0;// TODO: Add event handler implementation here.
            
            
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}

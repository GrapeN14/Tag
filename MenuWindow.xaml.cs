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

namespace Tag
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public static bool isDarkTheme;
        public MenuWindow()
        {
            InitializeComponent();
            if (GameWindow.isDarkTheme)
            {
                Start.Background = new SolidColorBrush(Colors.Gray);
                Exit.Background = new SolidColorBrush(Colors.Gray);
                Tag.Foreground = new SolidColorBrush(Colors.White);
                Border.Background = new SolidColorBrush(Color.FromRgb(0, 25, 51));
                ThemeImage.Source = new BitmapImage(new Uri("/moon.png", UriKind.Relative));
                isDarkTheme = true;
            }
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();
            Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Theme_Click(object sender, RoutedEventArgs e)
        {
            if(isDarkTheme)
            {
                Start.Background = new SolidColorBrush(Colors.White);
                Exit.Background = new SolidColorBrush(Colors.White);
                Tag.Foreground = new SolidColorBrush(Colors.Black);
                Border.Background = new SolidColorBrush(Colors.LightGray);
                ThemeImage.Source = new BitmapImage(new Uri("/sun.png", UriKind.Relative));
                isDarkTheme = false;
            }
            else
            {
                Start.Background = new SolidColorBrush(Colors.Gray);
                Exit.Background = new SolidColorBrush(Colors.Gray);
                Tag.Foreground = new SolidColorBrush(Colors.White);
                Border.Background = new SolidColorBrush(Color.FromRgb(0,25,51));
                ThemeImage.Source = new BitmapImage(new Uri("/moon.png", UriKind.Relative));
                isDarkTheme = true;
            }
        }
    }
}

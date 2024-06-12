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
using System.Windows.Shapes;

namespace Tag
{
    /// <summary>
    /// Логика взаимодействия для GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        GameLogic game;
        public static bool isDarkTheme; 
        public GameWindow()
        {
            InitializeComponent();
            game = new GameLogic();        
            if (MenuWindow.isDarkTheme)
            {
                Border.Background = new SolidColorBrush(Color.FromRgb(7, 15, 43));
                button0.Background = new SolidColorBrush(Color.FromRgb(0, 51, 102));
                button1.Background = new SolidColorBrush(Color.FromRgb(0, 51, 102));
                button2.Background = new SolidColorBrush(Color.FromRgb(0, 51, 102));
                button3.Background = new SolidColorBrush(Color.FromRgb(0, 51, 102));
                button4.Background = new SolidColorBrush(Color.FromRgb(0, 51, 102));
                button5.Background = new SolidColorBrush(Color.FromRgb(0, 51, 102));
                button6.Background = new SolidColorBrush(Color.FromRgb(0, 51, 102));
                button7.Background = new SolidColorBrush(Color.FromRgb(0, 51, 102));
                button8.Background = new SolidColorBrush(Color.FromRgb(0, 51, 102));
                button9.Background = new SolidColorBrush(Color.FromRgb(0, 51, 102));
                button10.Background = new SolidColorBrush(Color.FromRgb(0, 51, 102));
                button11.Background = new SolidColorBrush(Color.FromRgb(0, 51, 102));
                button12.Background = new SolidColorBrush(Color.FromRgb(0, 51, 102));
                button13.Background = new SolidColorBrush(Color.FromRgb(0, 51, 102));
                button14.Background = new SolidColorBrush(Color.FromRgb(0, 51, 102));
                button15.Background = new SolidColorBrush(Color.FromRgb(0, 51, 102));
            }
        }
        private void Window_Loaded (object sender, RoutedEventArgs e)
        {
            StartGame();
        }

        private void MenuItem_Click (object sender, RoutedEventArgs e)
        {
            Hide();
            MenuWindow menu = new MenuWindow();
            menu.Show(); 
        }

        private void StartGame()
        {
            game.Start();
            for (int i = 0; i < 200; ++i) 
                game.ShiftRandom();
            RefreshButton();
        }

        private void RefreshButton()
        {
            for (int position = 0; position < 16; ++position)
            {
                int number = game.GetNumber(position);
                button(position).Content = number.ToString();
                if (number > 0)
                    button(position).Visibility = Visibility.Visible;
                else if (number == 0)
                    button(position).Visibility = Visibility.Collapsed;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int position = Convert.ToInt16(((Button)sender).Tag);
            game.Shift(position);
            RefreshButton();
            if (game.CheckNumber())
            {
                MessageBox.Show("Ты выиграл!");
                StartGame();
            }    
        }
        private Button button (int position)
        {
            switch(position)
            {
                    case 0: return button0;
                    case 1: return button1;
                    case 2: return button2;
                    case 3: return button3;     
                    case 4: return button4;
                    case 5: return button5;
                    case 6: return button6;
                    case 7: return button7;
                    case 8: return button8;
                    case 9: return button9;
                    case 10: return button10;
                    case 11: return button11;
                    case 12: return button12;
                    case 13: return button13;
                    case 14: return button14;
                    case 15: return button15;
                    default: return null;
            }
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

        }
    }
}

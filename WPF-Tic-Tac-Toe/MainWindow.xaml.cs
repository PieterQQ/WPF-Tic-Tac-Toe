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

namespace WPF_Tic_Tac_Toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool IsPlayer1 { get; set; }
        public int Counter { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            NewGame();
        }



        public void NewGame()
        {
            IsPlayer1 = false;
            Counter = 0;
            //reset strings
            Button_0_0.Content = String.Empty;
            Button_1_0.Content = String.Empty;
            Button_2_0.Content = String.Empty;
            Button_0_1.Content = String.Empty;
            Button_1_1.Content = String.Empty;
            Button_2_1.Content = String.Empty;
            Button_0_2.Content = String.Empty;
            Button_1_2.Content = String.Empty;
            Button_2_2.Content = String.Empty;
            //reset colors
            Button_0_0.Background = Brushes.AliceBlue;
            Button_1_0.Background = Brushes.AliceBlue;
            Button_2_0.Background = Brushes.AliceBlue;
            Button_0_1.Background = Brushes.AliceBlue;
            Button_1_1.Background = Brushes.AliceBlue;
            Button_2_1.Background = Brushes.AliceBlue;
            Button_0_2.Background = Brushes.AliceBlue;
            Button_1_2.Background = Brushes.AliceBlue;
            Button_2_2.Background = Brushes.AliceBlue;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            if (button.Content.ToString() == string.Empty)
            {
                button.Content = IsPlayer1 ? "O" : "X";
                IsPlayer1 ^= true;
                Counter++;
            }

            if (Counter > 9)
            {
                NewGame();
                return;
            }

            if (PlayerWon())
            {
                MessageBox.Show("Click anywhere to restart game");

                Counter = 10;
            }

        }

        private bool PlayerWon()
        {
            //rows
            if (Button_0_0.Content.ToString() != String.Empty &&
                Button_0_0.Content == Button_0_1.Content && Button_0_1.Content == Button_0_2.Content)
            {
                Button_0_0.Background = Brushes.DarkGreen;
                Button_0_1.Background = Brushes.DarkGreen;
                Button_0_2.Background = Brushes.DarkGreen;
                return true;
            }
            if (Button_1_0.Content.ToString() != String.Empty &&
                Button_1_0.Content == Button_1_1.Content && Button_1_1.Content == Button_1_2.Content)
            {
                Button_1_0.Background = Brushes.DarkGreen;
                Button_1_1.Background = Brushes.DarkGreen;
                Button_1_2.Background = Brushes.DarkGreen;
                return true;
            }
            if (Button_2_0.Content.ToString() != String.Empty &&
                Button_2_0.Content == Button_2_1.Content && Button_2_1.Content == Button_2_2.Content)
            {
                Button_2_0.Background = Brushes.DarkGreen;
                Button_2_1.Background = Brushes.DarkGreen;
                Button_2_2.Background = Brushes.DarkGreen;
                return true;
            }
            //colums
            if (Button_0_0.Content.ToString() != String.Empty &&
                Button_0_0.Content == Button_1_0.Content && Button_1_0.Content == Button_2_0.Content)
            {
                Button_0_0.Background = Brushes.DarkGreen;
                Button_1_0.Background = Brushes.DarkGreen;
                Button_2_0.Background = Brushes.DarkGreen;
                return true;
            }
            if (Button_0_1.Content.ToString() != String.Empty &&
                Button_0_1.Content == Button_1_1.Content && Button_1_1.Content == Button_2_1.Content)
            {
                Button_0_1.Background = Brushes.DarkGreen;
                Button_1_1.Background = Brushes.DarkGreen;
                Button_2_1.Background = Brushes.DarkGreen;
                return true;
            }
            if (Button_0_2.Content.ToString() != String.Empty &&
                Button_0_2.Content == Button_1_2.Content && Button_1_2.Content == Button_2_2.Content)
            {
                Button_0_2.Background = Brushes.DarkGreen;
                Button_1_2.Background = Brushes.DarkGreen;
                Button_2_2.Background = Brushes.DarkGreen;
                return true;
            }
            //diagonal
            if (Button_0_0.Content.ToString() != String.Empty &&
                Button_0_0.Content == Button_1_1.Content && Button_1_1.Content == Button_2_2.Content)
            {
                Button_0_0.Background = Brushes.DarkGreen;
                Button_1_1.Background = Brushes.DarkGreen;
                Button_2_2.Background = Brushes.DarkGreen;
                return true;
            }
            if (Button_0_2.Content.ToString() != String.Empty &&
                Button_0_2.Content == Button_1_1.Content && Button_1_1.Content == Button_2_0.Content)
            {
                Button_0_2.Background = Brushes.DarkGreen;
                Button_1_1.Background = Brushes.DarkGreen;
                Button_2_0.Background = Brushes.DarkGreen;
                return true;
            }

            return false;
        }
    }
}

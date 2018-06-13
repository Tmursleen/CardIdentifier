//Tyler, Shubham, Akshay, Anil

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

namespace Card_Identifier2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnJackDiamonds_Click(object sender, RoutedEventArgs e)
        {
            lbldisplay.Content = "Jack of Diamonds";
        }

        private void btnJackHearts_Click(object sender, RoutedEventArgs e)
        {
            lbldisplay.Content = "Jack of Hearts";
        }

        private void btnJackSpades_Click(object sender, RoutedEventArgs e)
        {
            lbldisplay.Content = "Jack of Spades";
        }

        private void btnJackBlack_Click(object sender, RoutedEventArgs e)
        {
            lbldisplay.Content = "Black Joker";
        }

        private void btnJokerRed_Click(object sender, RoutedEventArgs e)
        {
            lbldisplay.Content = "Red Joker";
        }
    }
}

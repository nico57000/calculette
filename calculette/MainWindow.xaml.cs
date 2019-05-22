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

namespace calculette
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            result.Text += 1; 
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            result.Text += 2;
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            result.Text += 3;
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            result.Text += 4;
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            result.Text += 5;
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            result.Text += 6;
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            result.Text += 7;
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            result.Text += 8;
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            result.Text += 9;
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            result.Text += 0;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            result.Text += "+";
        }

        private void Sous_Click(object sender, RoutedEventArgs e)
        {
            result.Text += "-";
        }

        private void Mult_Click(object sender, RoutedEventArgs e)
        {
            result.Text += "*";
        }

        private void Div_Click(object sender, RoutedEventArgs e)
        {
            result.Text += "/";
        }

        private void Egal_Click(object sender, RoutedEventArgs e)
        {
            Calculatrice calc = new Calculatrice();
            result.Text = calc.calcul(result.Text);
        }

        private void Ac_Click(object sender, RoutedEventArgs e)
        {
            result.Text = "";
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            string tmp = "";
            for (int i = 0; i < result.Text.Length-1; i++)
            {
                tmp += result.Text[i];
            }
            result.Text = tmp;
        }
    }
}

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

namespace Kalkulačka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int num1 = 0;
        int num2 = 0;
        int result = 0;
        char operation = ' ';

        public MainWindow()
        {
            InitializeComponent();
        }

        private void numClick(object sender, RoutedEventArgs e)
        {
            output.Text = output.Text + (sender as Button).Content;
        }

        private void addClick(object sender, RoutedEventArgs e)
        {
            num1 = int.Parse(output.Text);
            operation = '+';
            output.Text = "";
        }

        private void subClick(object sender, RoutedEventArgs e)
        {
            num1 = int.Parse(output.Text);
            operation = '-';
            output.Text = "";
        }

        private void mulClick(object sender, RoutedEventArgs e)
        {
            num1 = int.Parse(output.Text);
            operation = '*';
            output.Text = "";
        }

        private void divClick(object sender, RoutedEventArgs e)
        {
            num1 = int.Parse(output.Text);
            operation = '/';
            output.Text = "";
        }

        private void equClick(object sender, RoutedEventArgs e)
        {
            num2 = int.Parse(output.Text);
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    output.Text = result.ToString();
                    break;
                case '-':
                    result = num1 - num2;
                    output.Text = result.ToString();
                    break;
                case '*':
                    result = num1 * num2;
                    output.Text = result.ToString();
                    break;
                case '/':
                    result = num1 / num2;
                    output.Text = result.ToString();
                    break;
            }
            num1 = result;
        }

        private void delClick(object sender, RoutedEventArgs e)
        {
            output.Text = "";
        }
    }
}

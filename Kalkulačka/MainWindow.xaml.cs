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
        double num1 = 0;
        double num2 = 0;
        double result = 0;
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
            try
            {
                num1 = double.Parse(output.Text);
                operation = '+';
                output.Text = "";
            }
            catch (Exception)
            {
                output.Text = "Error";
            }
        }

        private void subClick(object sender, RoutedEventArgs e)
        {
            try
            {
                num1 = double.Parse(output.Text);
                operation = '-';
                output.Text = "";
            }
            catch (Exception)
            {
                output.Text = "Error";
            }
        }

        private void mulClick(object sender, RoutedEventArgs e)
        {
            try
            {
                num1 = double.Parse(output.Text);
                operation = '*';
                output.Text = "";
            }
            catch (Exception)
            {
                output.Text = "Error";
            }
        }

        private void divClick(object sender, RoutedEventArgs e)
        {
            try
            {
                num1 = double.Parse(output.Text);
                operation = '/';
                output.Text = "";
            }
            catch (Exception)
            {
                output.Text = "Error";
            }
        }

        private void equClick(object sender, RoutedEventArgs e)
        {
            try
            {
                num2 = double.Parse(output.Text);
            }
            catch (Exception)
            {
                output.Text = "Error";
            }
            switch (operation)
            {
                case '+':
                    result = Math.Round(num1 + num2, 3);
                    output.Text = result.ToString();
                    break;
                case '-':
                    result = Math.Round(num1 - num2, 3);
                    output.Text = result.ToString();
                    break;
                case '*':
                    result = Math.Round (num1 * num2, 3);
                    output.Text = result.ToString();
                    break;
                case '/':
                    result = Math.Round(num1 / num2, 3);
                    output.Text = result.ToString();
                    break;
            }
            num1 = result;
        }

        private void delClick(object sender, RoutedEventArgs e)
        {
            try
            {
                output.Text = "";
            }
            catch (Exception)
            {
                output.Text = "Error";
            }
        }

        private void decClick(object sender, RoutedEventArgs e)
        {
            try
            {
                output.Text += ",";
            }
            catch (Exception)
            {
                output.Text = "Error";
            }
        }

        private void negClick(object sender, RoutedEventArgs e)
        {
            try
            {
                output.Text = (double.Parse(output.Text) * -1).ToString();
            }
            catch (Exception)
            {
                output.Text = "Error";
            }
            
        }
    }
}

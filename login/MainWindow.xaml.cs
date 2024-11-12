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

namespace login
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        prihlasovaciUdaje prihlasovaciUdaje = new prihlasovaciUdaje();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LoginBox.Text == prihlasovaciUdaje.Login)
        }
    }



    public class prihlasovaciUdaje
    {
        private string login = "Uzlabina";
        private string password = "ABCabc123";

        public string Login { get { return login; } set { login = value; } }
        public string Password { get { return password; } set { password = value; } }

    }
}

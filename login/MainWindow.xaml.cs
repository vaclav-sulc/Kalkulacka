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

        prihlasovaciUdaje prihlasovaciudaje = new prihlasovaciUdaje();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LoginBox.Text == prihlasovaciudaje.Login)
            {
                if (PasswordBox.Password == prihlasovaciudaje.Password)
                {
                    MessageBox.Show("Přihlášení proběhlo úspěšně");
                }
                else
                {
                    MessageBox.Show("Špatné heslo");
                }
            }
            else
            {
                MessageBox.Show("Špatné jméno");
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

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

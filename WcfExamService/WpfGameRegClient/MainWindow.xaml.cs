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
using WpfGameRegClient.GameRegService;

namespace WpfGameRegClient
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public GameRegistrationClient client ;
        //private List<Gamer> gamers;

        public MainWindow()
        {
            InitializeComponent();
            client = new GameRegistrationClient("BasicHttpBinding_IGameRegistration");
           // gamers= new List<Gamer>();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if ((string)logLogin.Text == null || (string)logPasswd.Text == null || (string)logLogin.Text == String.Empty ||
                (string)logPasswd.Text == String.Empty)
            {
                MessageBox.Show("write fields");
                return;
            }
            var l = (string)logLogin.Text;
            var p = (string) logPasswd.Text;
            var result = "Gamers summary: " + client.LoginToReg(l, p);
            ResultLabel.Content = result;
                MessageBox.Show(result);

        }

        private void Testbt(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(client.TestConnection()); 
            
        }

        private void btnReg(object sender, RoutedEventArgs e)
        {
            if (regLogin.Text == null || regPasswd.Text == null || regNick.Text == null
                || (string)regLogin.Text == String.Empty || (string)regPasswd.Text == String.Empty)
            {
                MessageBox.Show("write fields for registration");
                return;
            };
            
            var l = (string)regLogin.Text;
            var p = (string)regPasswd.Text;
            var n = (string)regNick.Text;

            //Gamer g = new Gamer {Login = l, Passwd = p, NickName = n};

            //gamers.Add(g);
            //int t = client.AddNewGamerToDb( g);
            client.AddNewGamerToDbString(n,l, p);
            //Label.Content = t.ToString();

            //if (t)
            //{
                MessageBox.Show("Registration comlete");
            //}
        }
    }
}

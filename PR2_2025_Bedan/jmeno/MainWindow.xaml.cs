using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace jmeno
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double cislo = 0;
        private double cislo1 = 0;
        private double vysledek = 0;
        private bool plus_clicked = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnpozdrav_Click(object sender, RoutedEventArgs e)
        {
            string uzivatel = jmeno.Text;
            lblpozdrav.Content = "ahoj " + uzivatel;
        }

        private void btplus_Click(object sender, RoutedEventArgs e)
        {
            calc.Content = cislo+"+";
            cislo1 = cislo;
            cislo = 0;
            plus_clicked = true;
        }

        private void btequals_Click(object sender, RoutedEventArgs e)
        {
            double vysledek = cislo + cislo1;
            calc.Content = cislo1 + "+" + cislo + "=" + vysledek;
            plus_clicked = false;
        }

        private void Cislicko_Click(object sender, RoutedEventArgs e)
        {
            Button cudlik = sender as Button;
            int number = int.Parse(cudlik.Content.ToString());

            cislo = cislo * 10 + number;

            if (plus_clicked == true)
            {
                calc.Content = cislo1 + "+" + cislo;
            }
            else
            {
                calc.Content = cislo;
            }
        }
    }
}
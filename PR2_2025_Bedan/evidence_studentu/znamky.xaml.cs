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

namespace EvidenceStudentu
{
    /// <summary>
    /// Interakční logika pro znamky.xaml
    /// </summary>
    public partial class znamky : Window
    {

        public znamky()
        {
            InitializeComponent();

        }
        private void BtnPridat_Click(object sender, RoutedEventArgs e)
        {
            string o;
            int v;
            DateTime d;
            o = txtOznaceni.Text;
            v = int.Parse(txtVaha.Text);
            d = datePicker.SelectedDate.Value;
            hodnoceni h = new hodnoceni(o,v,d);
            vybranyStudent.Hodnoceni.Add(h);
            this.Close();
        }
    }
}

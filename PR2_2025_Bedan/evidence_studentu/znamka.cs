using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EvidenceStudentu
{
    public partial class znamky : Window
    {
        private Student vybranyStudent;

        public znamky(Student student)
        {
            InitializeComponent();
            vybranyStudent = student;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop
{
    internal interface IPolozkaKosiku
    {
        int cena { get; }
        void VlozDoKosiku();
        void OdstranPolozku();
    }
}

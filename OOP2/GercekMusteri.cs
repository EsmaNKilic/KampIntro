using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Individual- Gerçek
    class GercekMusteri : Musteri //bu yaptığımız miras yani inheritance. Müşteride olan özellikler gerçekte de vardır anlamında, gerçek miras alır müşteriden.
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        // tc no, vergi no gibi sayısal verilere 4 işlem türevi bir işlem atamayacaksan string yapabilirsin.
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate - Tüzel
    class TuzelMusteri : Musteri //bu yaptığımız miras yani inheritance. Müşteride olan özellikler tüzelde de vardır anlamında, tüzel miras alır müşteriden.
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }

        // tc no, vergi no gibi sayısal verilere 4 işlem türevi bir işlem atamayacaksan string yapabilirsin.
    }
}

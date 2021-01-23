using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //bu da gerçek bir müşteridir videodaki employee olayı gibi tüzel ve bu .
    class GercekMusteri:Musteri
    {
      
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}

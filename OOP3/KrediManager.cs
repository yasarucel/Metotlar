using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //interface tüm classları içinde tutar mesela yüzlerce krediyi içinde tutar
    //DİĞER KREDİLER BU METHODLARI İÇERMELİ HESAPLA VE BİRŞEYYAP
    interface IKrediManager 
    {
        void Hesapla();
        void BirseyYap();
      
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
       // IKrediManager YAZDIK ÇÜNKÜ PROGRAM CS KISMINDA KOLAYLIK SAĞLIYORBAKNZ. PROGRAM.CS
        public void BasvuruYap(IKrediManager krediManager)
        {
            //Basvuran bilgilerini degerlendirme
            //
            //
          
            krediManager.Hesapla();
        }
        //listedeki kredileri hesapla that bizim seçtiğimiz
        //tek tek hesapladık müşteriye uygun olanları seçip
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
            
        {
            foreach (var kredi in krediler)

            {
                kredi.Hesapla();
            }
        }
    }
}

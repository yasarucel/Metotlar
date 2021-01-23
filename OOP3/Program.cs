using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ıhtiyyackredisi yerine IKrediManager yazılabilir
            IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            // basvuruManager.BasvuruYap(konutKrediManager);
            // köşeli parantez içine istediği kredi türünü seçer aynı anda hesaplama yapmak için
            List<IKrediManager> krediler = new List<IKrediManager>() {ıhtiyacKrediManager, tasitKrediManager };

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}

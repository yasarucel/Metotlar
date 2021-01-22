using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri adi :" + musteri.Adi);
            Console.WriteLine("Musteri soyadi :" + musteri.Soyadi);
            Console.WriteLine("Musteri yasi :" + musteri.Yasi);
            Console.WriteLine("Musteri Id :" + musteri.Id);
        }
       
       
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri adi :" + musteri.Adi);
            Console.WriteLine("Musteri soyadi :" + musteri.Soyadi);
            Console.WriteLine("Musteri yasi :" + musteri.Yasi );
            Console.WriteLine("Musteri Id :" + musteri.Id );

        }
        
    }
}

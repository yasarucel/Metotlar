using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "1234";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "123456";
            musteri1.Id = 1;



            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12334567";
            musteri2.SirketAdi = "Kodlamioo";
            musteri2.VergiNo = " 4225145";

            //Gerçek-  Tüzel(şirket)  Burada ikiside müşteri ama çeşitleri farklı*****
            //  son videodaki mantık ikiside çalışan ama biri employee diğeri worker
            //SOLİD

            //new bir refernas numarası yani yeni bir referenas 
            // müşteri hem gerçek hem de tüzelin referansını tutabiliyor.
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManger customerManger = new CustomerManger();
            customerManger.Add(musteri1);
            customerManger.Add(musteri2);
        }
    }
}

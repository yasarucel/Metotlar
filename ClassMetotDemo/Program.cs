using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Stefan";
            musteri1.Soyadi = "Zweig";
            musteri1.Id = 123456789 ;
            musteri1.Yasi = 58;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Franz";
            musteri2.Soyadi = "Kafka";
            musteri2.Id = 123456789;
            musteri2.Yasi = 99;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Zülfü";
            musteri3.Soyadi = "Livaneli";
            musteri3.Id = 123456789;
            musteri3.Yasi = 48;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Yasi);
                Console.WriteLine("/////////////////");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri3);

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);

        }


    }
}

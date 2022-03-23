using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1= new Musteri();
            musteri1.MusteriId = 1;
            musteri1.TcNo = 12345;
            musteri1.MusteriAdi = "Ali";
            musteri1.MusteriSoyadi = "Güçlü";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.TcNo = 54321;
            musteri2.MusteriAdi = "Veli";
            musteri2.MusteriSoyadi = "Zayıf";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);

            musteriManager.Update(musteri2);

        }
    }
}

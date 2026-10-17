using System;

namespace OOP_week_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitap kitap1 = new Kitap();

            kitap1.kitapAdi = "Suç ve Ceza";
            kitap1.yazar = "Dostoyevski";
            kitap1.sayfaSayisi = 687;

            // Parametresiz - void
            kitap1.BilgileriGoster();

            // Parametreli - void
            kitap1.KitapAdiDegistir("Yeni Kitap Adı");

            // Parametresiz - return
            int sayfa = kitap1.SayfaSayisiniGetir();

            // Parametreli - return
            bool uzunMu = kitap1.UzunKitapMi(500);

            Console.WriteLine("Sayfa: " + sayfa);
            Console.WriteLine("500 sayfadan uzun mu? " + uzunMu);

            // Method overloading
            kitap1.KitapAra("Suç ve Ceza");
            kitap1.KitapAra("Suç ve Ceza", "Dostoyevski");
            kitap1.KitapAra(687);

            // ------------------------------------------------------------------------------------

            // Parametresiz constructor çağrılır
            Kare kare1 = new Kare();

            // Parametreli constructor çağrılır
            Kare kare2 = new Kare(5);

            Console.WriteLine("1. Kare");
            kare1.BilgileriGoster();

            Console.WriteLine("2. Kare");
            kare2.BilgileriGoster();

           // ------------------------------------------------------------------------------------

            // Nesne oluşturmuyoruz!
            MatematikYardimci.BilgiVer();

            int toplam = MatematikYardimci.Topla(10, 5);
            int fark = MatematikYardimci.Cikar(10, 5);
            int carpim = MatematikYardimci.Carp(10, 5);

            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("Fark: " + fark);
            Console.WriteLine("Çarpım: " + carpim);

            // ------------------------------------------------------------------------------------

            Dikdortgen d1 = new Dikdortgen();
            Dikdortgen d2 = new Dikdortgen(5);
            Dikdortgen d3 = new Dikdortgen(5, 8);

            d1.BilgileriGoster();
            d2.BilgileriGoster();
            d3.BilgileriGoster();

            // Klavyeden veri alma
            Console.Write("Uzunluk giriniz: ");
            int u = Convert.ToInt32(Console.ReadLine());

            Console.Write("Genişlik giriniz: ");
            int g = Convert.ToInt32(Console.ReadLine());

            Dikdortgen d4 = new Dikdortgen(u, g);

            Console.WriteLine("Kullanıcıdan alınan değerler:");
            d4.BilgileriGoster();
        }
    }
}

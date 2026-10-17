using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_week_3
{
    public class Kitap
    {
        public string kitapAdi;
        public string yazar;
        public int sayfaSayisi;

        // 1. Parametresiz - Değer döndürmeyen
        public void BilgileriGoster()
        {
            Console.WriteLine("Kitap: " + kitapAdi);
            Console.WriteLine("Yazar: " + yazar);
            Console.WriteLine("Sayfa: " + sayfaSayisi);
        }

        // 2. Parametreli - Değer döndürmeyen
        public void KitapAdiDegistir(string yeniAd)
        {
            kitapAdi = yeniAd;
        }

        // 3. Parametresiz - Değer döndüren
        public int SayfaSayisiniGetir()
        {
            return sayfaSayisi;
        }

        // 4. Parametreli - Değer döndüren
        public bool UzunKitapMi(int sinir)
        {
            return sayfaSayisi > sinir;
        }

        // 5. Method Overloading
        public void KitapAra(string ad)
        {
            Console.WriteLine("Kitap aranıyor: " + ad);
        }

        public void KitapAra(string ad, string yazarAdi)
        {
            Console.WriteLine("Kitap: " + ad);
            Console.WriteLine("Yazar: " + yazarAdi);
        }

        public void KitapAra(int sayfa)
        {
            Console.WriteLine("Sayfa sayısına göre arama: " + sayfa);
        }
    }
}

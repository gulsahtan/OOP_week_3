using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_week_3
{
    public class Dikdortgen
    {
        public int uzunluk;
        public int genislik;

        // Parametresiz constructor
        public Dikdortgen()
        {
            uzunluk = 3;
            genislik = 3;
        }

        // Tek parametreli constructor
        public Dikdortgen(int kenar)
        {
            uzunluk = kenar;
            genislik = kenar;
        }

        // İki parametreli constructor
        public Dikdortgen(int u, int g)
        {
            uzunluk = u;
            genislik = g;
        }

        public int AlanHesapla()
        {
            return uzunluk * genislik;
        }

        public int CevreHesapla()
        {
            return 2 * (uzunluk + genislik);
        }

        public void BilgileriGoster()
        {
            Console.WriteLine("Uzunluk: " + uzunluk);
            Console.WriteLine("Genişlik: " + genislik);
            Console.WriteLine("Alan: " + AlanHesapla());
            Console.WriteLine("Çevre: " + CevreHesapla());
        }
    }
}

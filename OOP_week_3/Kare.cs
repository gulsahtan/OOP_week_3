using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_week_3
{
    public class Kare
    {
        public int kenar;

        // 1. Parametresiz constructor
        public Kare()
        {
            kenar = 1;
            Console.WriteLine("Parametresiz constructor çalıştı.");
        }

        // 2. Parametreli constructor
        public Kare(int k)
        {
            kenar = k;
            Console.WriteLine("Parametreli constructor çalıştı.");
        }

        // Normal metot - Alan
        public int AlanHesapla()
        {
            return kenar * kenar;
        }

        // Normal metot - Çevre
        public int CevreHesapla()
        {
            return 4 * kenar;
        }

        // Normal metot - Bilgi gösterme
        public void BilgileriGoster()
        {
            Console.WriteLine("Kenar: " + kenar);
            Console.WriteLine("Alan: " + AlanHesapla());
            Console.WriteLine("Çevre: " + CevreHesapla());
        }
    }
}

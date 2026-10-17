using System;

namespace OOP_week_3
{
    public static class MatematikYardimci
    {
        // Static toplama metodu
        public static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        // Static çıkarma metodu
        public static int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        // Static çarpma metodu
        public static int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        // Static metot - Değer döndürmeyen
        public static void BilgiVer()
        {
            Console.WriteLine("Matematik işlemleri hazır.");
        }
    }
}

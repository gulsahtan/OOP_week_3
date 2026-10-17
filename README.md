# 🎯 OOP_week_3 – Metot Türleri, Constructor ve Static Metotlar

Bu proje, **Nesne Tabanlı Programlama (Object-Oriented Programming – OOP)** dersi kapsamında işlenen *metot türleri, constructor (kurucu metotlar), method overloading ve static metotlar* konularını C# .NET Console uygulamaları üzerinden öğretmek amacıyla geliştirilmiştir.

Bu haftada, önceki derslerde öğrenilen sınıf oluşturma, nesne tanımlama ve değişkenlere değer atama işlemleri genişletilerek sınıf içerisindeki metotların kullanımı ele alınmıştır.

---

## 📌 Bu Haftanın Konuları

- Metot nedir, neden kullanılır?
- Sınıf içerisinde metot tanımlama
- Parametre alan ve almayan metotlar
- Değer döndüren ve döndürmeyen metotlar
- `void` ve `return` arasındaki fark
- Metotların `Program.cs` içerisinden çağrılması
- Method Overloading (Metotların Aşırı Yüklenmesi)
- Constructor (Kurucu Metot) nedir?
- Parametreli ve parametresiz constructor
- Constructor Overloading
- Constructor ve normal metot arasındaki fark
- `static` metotlar ve kullanım amaçları
- Nesne oluşturmadan metot çağırma
- Constructor kullanarak alan ve çevre hesaplama

---

## 🧠 Projenin Amacı

Bu proje ile öğrencilerin:

- Sınıf içerisinde farklı türlerde metotlar oluşturabilmesi
- Parametre ve dönüş değeri kavramlarını öğrenmesi
- `void` ve `return` kullanımını ayırt edebilmesi
- Aynı isimde farklı parametrelere sahip metotlar tanımlayabilmesi
- Constructor kullanarak nesnelere başlangıç değerleri atayabilmesi
- Normal metot ve constructor arasındaki farkı açıklayabilmesi
- `static` metotları nesne oluşturmadan çağırabilmesi
- Nesne tabanlı programlama kavramlarını gerçek uygulamalarda kullanabilmesi

hedeflenmiştir.

---


# 1️⃣ METOT TÜRLERİ – Kitap Sınıfı

## 🔹 Metot Nedir?

Metot, belirli bir işlemi gerçekleştirmek amacıyla oluşturulan kod bloğudur.

Metotlar sayesinde aynı işlemleri tekrar tekrar yazmak yerine, tanımlanan metot ihtiyaç duyulduğunda çağrılarak çalıştırılabilir.

### Metot Tanımlama Yapısı

```csharp
public void BilgileriGoster()
{
    Console.WriteLine("Kitap bilgileri");
}
```

Burada:

- `public` → Metoda sınıf dışından erişilmesini sağlar.
- `void` → Metodun değer döndürmediğini belirtir.
- `BilgileriGoster` → Metodun adıdır.
- `()` → Parametrelerin tanımlandığı bölümdür.
- `{ }` → Metodun gerçekleştireceği işlemleri içerir.

## 🔹 Metot Türleri

Metotlar parametre alıp almamalarına ve değer döndürüp döndürmemelerine göre dört grupta incelenebilir.

| Metot türü | Parametre | Değer döndürme |
|---|---|---|
| Parametresiz – Değer döndürmeyen | Yok | Yok |
| Parametreli – Değer döndürmeyen | Var | Yok |
| Parametresiz – Değer döndüren | Yok | Var |
| Parametreli – Değer döndüren | Var | Var |

### 1. Parametresiz ve Değer Döndürmeyen Metot

```csharp
public void BilgileriGoster()
{
    Console.WriteLine("Kitap: " + kitapAdi);
    Console.WriteLine("Yazar: " + yazar);
    Console.WriteLine("Sayfa: " + sayfaSayisi);
}
```

Bu metot herhangi bir parametre almaz ve çağırana değer döndürmez.

**Program.cs içerisinde çağrılması:**

```csharp
kitap1.BilgileriGoster();
```

### 2. Parametreli ve Değer Döndürmeyen Metot

```csharp
public void KitapAdiDegistir(string yeniAd)
{
    kitapAdi = yeniAd;
}
```

Bu metot dışarıdan aldığı değeri kullanarak kitabın adını değiştirir.

**Program.cs:**

```csharp
kitap1.KitapAdiDegistir("Yeni Kitap Adı");
```

### 3. Parametresiz ve Değer Döndüren Metot

```csharp
public int SayfaSayisiniGetir()
{
    return sayfaSayisi;
}
```

Bu metot herhangi bir parametre almaz ancak `int` türünde değer döndürür.

**Program.cs:**

```csharp
int sayfa = kitap1.SayfaSayisiniGetir();

Console.WriteLine("Sayfa Sayısı: " + sayfa);
```

### 4. Parametreli ve Değer Döndüren Metot

```csharp
public bool UzunKitapMi(int sinir)
{
    return sayfaSayisi > sinir;
}
```

Bu metot dışarıdan bir sınır değeri alır ve kitabın sayfa sayısını karşılaştırır.

**Program.cs:**

```csharp
bool sonuc = kitap1.UzunKitapMi(500);

Console.WriteLine("500 sayfadan uzun mu? " + sonuc);
```

Sonuç `True` veya `False` olur.

## 🔹 void ve return Arasındaki Fark

| Özellik | void | Değer döndüren metot |
|---|---|---|
| Çağırana değer döndürür mü? | Hayır | Evet |
| Dönüş tipi | `void` | `int`, `string`, `bool` vb. |
| Sonuç değişkene atanabilir mi? | Hayır | Evet |
| Örnek | `BilgileriGoster()` | `SayfaSayisiniGetir()` |

**Önemli:** `void` metot içerisinde de `return;` kullanılabilir. Ancak bu ifade bir değer döndürmez, yalnızca metottan çıkılmasını sağlar.

---

# 2️⃣ METHOD OVERLOADING – Metotların Aşırı Yüklenmesi

## 🔹 Method Overloading Nedir?

Aynı sınıf içerisinde aynı isimde ancak farklı parametre listelerine sahip birden fazla metot tanımlanmasına **Method Overloading** denir.

Örneğin `Kitap` sınıfı içerisinde üç farklı `KitapAra()` metodu tanımlanabilir.

```csharp
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
```

### Program.cs İçerisinde Kullanımı

```csharp
kitap1.KitapAra("Suç ve Ceza");

kitap1.KitapAra("Suç ve Ceza", "Dostoyevski");

kitap1.KitapAra(687);
```

C# derleyicisi, gönderilen parametrelerin sayısına ve türlerine göre uygun metodu belirler.

**Dikkat:** Metotların yalnızca dönüş tiplerinin farklı olması, aşırı yükleme için yeterli değildir. Parametre listeleri farklı olmalıdır.

---

# 3️⃣ CONSTRUCTOR – Kurucu Metotlar (Kare Sınıfı)

## 🔹 Constructor Nedir?

Constructor, bir sınıftan nesne oluşturulduğunda otomatik olarak çalışan özel bir yapıdır.

Constructor'ın temel amacı, nesnenin başlangıç değerlerini belirlemek ve nesneyi kullanıma hazırlamaktır.

Önceki derslerde nesne oluşturduktan sonra değişkenlere tek tek değer atıyorduk.

```csharp
Kare kare1 = new Kare();

kare1.kenar = 5;
```

Constructor kullanıldığında ise başlangıç değerini nesne oluşturulurken gönderebiliriz.

```csharp
Kare kare1 = new Kare(5);
```

Bu işlem sırasında `5` değeri constructor'a gönderilir ve `kenar` değişkenine atanır.

## 🔹 Constructor'ın Özellikleri

- Constructor adı, sınıf adıyla aynı olmalıdır.
- Constructor'ın dönüş tipi bulunmaz.
- `void` ifadesi kullanılmaz.
- Nesne oluşturulurken otomatik çalışır.
- Parametreli veya parametresiz olabilir.
- Aynı sınıfta birden fazla constructor tanımlanabilir.
- Normal metot gibi nesne üzerinden doğrudan çağrılamaz.

## 🔹 Parametresiz Constructor

```csharp
public Kare()
{
    kenar = 1;
    Console.WriteLine("Parametresiz constructor çalıştı.");
}
```

**Program.cs:**

```csharp
Kare kare1 = new Kare();
```

Bu satır çalıştığında `kenar` değişkeninin başlangıç değeri `1` olur.

## 🔹 Parametreli Constructor

```csharp
public Kare(int k)
{
    kenar = k;
    Console.WriteLine("Parametreli constructor çalıştı.");
}
```

**Program.cs:**

```csharp
Kare kare2 = new Kare(5);
```

Bu işlemde `k` parametresine `5` değeri gönderilir ve `kenar` değişkenine atanır.

---

## 🔹 Constructor Overloading

Bir sınıfta farklı parametre listelerine sahip birden fazla constructor tanımlanabilir.

```csharp
public Kare()
{
    kenar = 1;
}

public Kare(int k)
{
    kenar = k;
}
```

**Program.cs:**

```csharp
Kare kare1 = new Kare();

Kare kare2 = new Kare(5);
```

İlk nesne parametresiz constructor ile, ikinci nesne ise parametreli constructor ile oluşturulur.

## 🔹 Constructor ile Normal Metot Arasındaki Fark

| Özellik | Constructor | Normal metot |
|---|---|---|
| İsim | Sınıf adıyla aynı | İstenilen geçerli isim |
| Dönüş tipi | Yok | `void`, `int`, `bool` vb. |
| Çalışma zamanı | Nesne oluşturulurken | Çağrıldığında |
| Parametre alabilir mi? | Evet | Evet |
| Aşırı yüklenebilir mi? | Evet | Evet |
| Kullanım amacı | Nesneye başlangıç durumu kazandırma | Belirli bir işlemi gerçekleştirme |

### Örnek

```csharp
Kare kare1 = new Kare(5);  // Constructor çalışır.

int alan = kare1.AlanHesapla(); // Normal metot çalışır.
```

**Önemli:** Bir sınıfta hiçbir constructor tanımlanmazsa C# derleyicisi uygun koşullarda parametresiz varsayılan constructor sağlar. Ancak sınıfa parametreli constructor tanımlandığında parametresiz constructor otomatik olarak eklenmez.

---

# 4️⃣ STATIC METOTLAR – MatematikYardimci Sınıfı

## 🔹 Static Metot Nedir?

`static` metotlar, bir nesneye değil sınıfın kendisine ait olan metotlardır.

Bu nedenle static metotları çağırmak için nesne oluşturulmasına gerek yoktur.

### Normal Metot Kullanımı

```csharp
Kare kare1 = new Kare(5);

int alan = kare1.AlanHesapla();
```

Burada önce `Kare` sınıfından bir nesne oluşturulmuştur.

### Static Metot Kullanımı

```csharp
int sonuc = MatematikYardimci.Topla(10, 5);
```

Burada herhangi bir nesne oluşturulmamıştır.

Metot doğrudan sınıf adı üzerinden çağrılmıştır.

## 🔹 MatematikYardimci.cs

```csharp
using System;

namespace OOP_week_3
{
    public class MatematikYardimci
    {
        public static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        public static int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public static void BilgiVer()
        {
            Console.WriteLine("Matematik işlemleri hazır.");
        }
    }
}
```

## 🔹 Program.cs İçerisinde Kullanımı

```csharp
MatematikYardimci.BilgiVer();

int toplam = MatematikYardimci.Topla(10, 5);

int fark = MatematikYardimci.Cikar(10, 5);

int carpim = MatematikYardimci.Carp(10, 5);

Console.WriteLine("Toplam: " + toplam);
Console.WriteLine("Fark: " + fark);
Console.WriteLine("Çarpım: " + carpim);
```

### 🖥️ Konsol Çıktısı

```text
Matematik işlemleri hazır.
Toplam: 15
Fark: 5
Çarpım: 50
```

## 🔹 Static ve Normal Metot Karşılaştırması

| Normal metot | Static metot |
|---|---|
| Nesneye aittir | Sınıfa aittir |
| Genellikle nesne üzerinden çağrılır | Sınıf adı üzerinden çağrılır |
| Nesne oluşturulması gerekir | Nesne oluşturulması gerekmez |
| Nesneye ait değişkenlere erişebilir | Nesneye ait değişkenlere doğrudan erişemez |
| `kare1.AlanHesapla()` | `MatematikYardimci.Topla(5, 3)` |

**Önemli:** Static metotlar, nesneye özgü verilerden bağımsız işlemlerde sıklıkla kullanılır. Örneğin matematiksel yardımcı fonksiyonlar static metotlar olarak tasarlanabilir.

---

# 5️⃣ SINIF OLUŞTURMA – Visual Studio Uygulama Adımları

Yeni bir sınıf oluşturmak için:

1. Visual Studio uygulamasını açınız.
2. `Solution Explorer` bölümünden projenizi bulunuz.
3. Projenin üzerine sağ tıklayınız.
4. `Add → Class` seçeneğine tıklayınız.
5. Sınıfın adını giriniz.
6. `Add` butonuna basınız.

Örneğin:

`Dikdortgen.cs`

Visual Studio sınıf dosyasını oluşturacaktır.

```csharp
namespace OOP_week_3
{
    public class Dikdortgen
    {
    }
}
```

Bu sınıf içerisine değişkenler, constructor'lar ve metotlar eklenebilir.

---

# 6️⃣ UYGULAMA – Dikdörtgen ile Alan ve Çevre Hesaplama

## 🎯 Uygulamanın Amacı

Bu uygulamada öğrencilerin constructor kullanarak nesne oluşturması, constructor overloading işlemini gerçekleştirmesi ve sınıf içerisindeki metotları çağırması hedeflenmiştir.

### Uygulama Gereksinimleri

`Dikdortgen` adında bir sınıf oluşturunuz.

Sınıf içerisinde:

- `uzunluk` ve `genislik` adında iki değişken tanımlayınız.
- Parametresiz constructor oluşturunuz.
- Tek parametreli constructor oluşturunuz.
- İki parametreli constructor oluşturunuz.
- Alan hesaplayan metot yazınız.
- Çevre hesaplayan metot yazınız.
- Bilgileri ekrana yazdıran metot oluşturunuz.

## 🔹 Dikdortgen.cs

```csharp
using System;

namespace OOP_week_3
{
    public class Dikdortgen
    {
        public int uzunluk;
        public int genislik;

        // Parametresiz constructor
        public Dikdortgen()
        {
            uzunluk = 1;
            genislik = 1;
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
```

## 🔹 Program.cs İçerisinde Nesne Oluşturma

```csharp
// Parametresiz constructor
Dikdortgen d1 = new Dikdortgen();

// Tek parametreli constructor
Dikdortgen d2 = new Dikdortgen(5);

// İki parametreli constructor
Dikdortgen d3 = new Dikdortgen(5, 8);

d1.BilgileriGoster();
d2.BilgileriGoster();
d3.BilgileriGoster();
```

### 🔍 Constructor'ların Çalışması

| Nesne | Constructor | Uzunluk | Genişlik | Alan | Çevre |
|---|---|---|---|---|---|
| `d1` | `Dikdortgen()` | 1 | 1 | 1 | 4 |
| `d2` | `Dikdortgen(5)` | 5 | 5 | 25 | 20 |
| `d3` | `Dikdortgen(5,8)` | 5 | 8 | 40 | 26 |

---

## 🔹 Klavyeden Veri Alarak Nesne Oluşturma

Uygulamanın son aşamasında kullanıcıdan iki kenar uzunluğu alınarak constructor aracılığıyla nesne oluşturulmuştur.

```csharp
Console.Write("Uzunluk giriniz: ");
int u = Convert.ToInt32(Console.ReadLine());

Console.Write("Genişlik giriniz: ");
int g = Convert.ToInt32(Console.ReadLine());

Dikdortgen d4 = new Dikdortgen(u, g);

Console.WriteLine("Alan: " + d4.AlanHesapla());

Console.WriteLine("Çevre: " + d4.CevreHesapla());
```

### 🖥️ Örnek Konsol Çıktısı

```text
Uzunluk giriniz: 5
Genişlik giriniz: 8

Alan: 40
Çevre: 26
```

### 🔍 Bu Uygulamada Neler Öğrendik?

Önceki haftalarda değişkenlere nesne oluşturulduktan sonra değer atıyorduk.

```csharp
Dikdortgen d1 = new Dikdortgen();

d1.uzunluk = 5;
d1.genislik = 8;
```

Bu hafta ise constructor aracılığıyla nesne oluşturulurken değer atama işlemi gerçekleştirdik.

```csharp
Dikdortgen d1 = new Dikdortgen(5, 8);
```

Bu kullanım, nesnenin başlangıç bilgilerinin constructor aracılığıyla belirlenmesini sağlar.

---

## 📌 Sonuç

Bu haftaki uygulamalarda C# nesne tabanlı programlamanın temel konularından olan **metotlar, constructor ve static metotlar** ele alınmıştır.

- **Kitap sınıfı** ile farklı metot türleri ve method overloading,
- **Kare sınıfı** ile constructor ve constructor overloading,
- **MatematikYardimci sınıfı** ile static metotların kullanımı,
- **Dikdortgen sınıfı** ile constructor kullanarak nesne oluşturma, alan ve çevre hesaplama

uygulamalı olarak gösterilmiştir.

Bu konular, ilerleyen haftalarda işlenecek olan **Encapsulation, Properties (`get`, `set`), Inheritance ve Polymorphism** konularının temelini oluşturmaktadır.

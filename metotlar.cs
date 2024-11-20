using System;

class Program
{
    static void Main()
    {
        // Öğrenci bilgilerini al
        var (adSoyad, not1, not2) = OgrenciBilgileriniAl();

        // Ortalama hesapla
        double ortalama = HesaplaOrtalama(not1, not2);

        // Sonucu yazdır
        Console.WriteLine($"{adSoyad} için ortalama not: {ortalama:F2}");
    }

    static (string, double, double) OgrenciBilgileriniAl()
    {
        Console.Write("Öğrencinin adı ve soyadı: ");
        string adSoyad = Console.ReadLine();

        Console.Write("1. sınav notunu girin: ");
        double not1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("2. sınav notunu girin: ");
        double not2 = Convert.ToDouble(Console.ReadLine());

        return (adSoyad, not1, not2);
    }

    static double HesaplaOrtalama(double not1, double not2)
    {
        return (not1 + not2) / 2;
    }
}

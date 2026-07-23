using System;
using System.Threading.Channels;

public class Ortalama
{

    public void UniversiteDersOrtalama()
    {
        int dersSayisi;
        string[] dersİsmi;
        double[] krediSayisi;
        double toplamKredi, donemNotu = 0;
        double dersSonOrt;
        string ders;
        Console.WriteLine("Üniversite ortalama hesapla ");
        Console.Write("\nDers sayısı : ");
        dersSayisi = Convert.ToInt32(Console.ReadLine());
        dersİsmi = new string[dersSayisi];
        krediSayisi = new double[dersSayisi];
        Console.WriteLine("\nDerslerin isimlerini giriniz  ");
        for (int i = 0; i < dersSayisi; i++)
        {
            Console.Write($"{i + 1}. ders : ");
            ders = Console.ReadLine();
            dersİsmi[i] = ders;
            Console.Write($"{dersİsmi[i]} dersinin kredi sayısı : ");
            krediSayisi[i] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vize notu : ");
            double vize = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ödev notu : ");
            double odev = Convert.ToDouble(Console.ReadLine());
            Console.Write("Final notu : ");
            double final = Convert.ToDouble(Console.ReadLine());
            dersSonOrt = (vize * 30 / 100) + (odev * 10 / 100) + (final * 60 / 100);
            if (dersSonOrt >= 90)
            {
                Console.WriteLine($"Ortalamanız : {dersSonOrt}. Dersten geçtiniz, harf notunuz: AA");
            }
            if (dersSonOrt >= 85 && dersSonOrt < 90)
            {
                Console.WriteLine($"Ortalamanız : {dersSonOrt}. Dersten geçtiniz, harf notunuz: BA");
            }
            if (dersSonOrt >= 80 && dersSonOrt < 85)
            {
                Console.WriteLine($"Ortalamanız : {dersSonOrt}. Dersten geçtiniz, harf notunuz: BB");
            }
            if (dersSonOrt >= 75 && dersSonOrt < 80)
            {
                Console.WriteLine($"Ortalamanız : {dersSonOrt}. Dersten geçtiniz, harf notunuz: CB");
            }
            if (dersSonOrt >= 70 && dersSonOrt < 75)
            {
                Console.WriteLine($"Ortalamanız : {dersSonOrt}. Dersten geçtiniz, harf notunuz: CC");
            }
            if (dersSonOrt >= 65 && dersSonOrt < 70)
            {
                Console.WriteLine($"Ortalamanız : {dersSonOrt}. Dersten geçtiniz, harf notunuz: DC");
            }
            if (dersSonOrt >= 60 && dersSonOrt < 65)
            {
                Console.WriteLine($"Ortalamanız : {dersSonOrt}. Dersten geçtiniz, harf notunuz: DD");
            }
            if (dersSonOrt >= 50 && dersSonOrt < 60)
            {
                Console.WriteLine($"Ortalamanız : {dersSonOrt}. Dersten geçtiniz, harf notunuz: FD");
            }
            if (dersSonOrt < 50)
            {
                Console.WriteLine($"Ortalamanız : {dersSonOrt}. Dersten kaldınız, harf notunuz: FF");
            }
            
        }
    }

    public void UniversiteDonemSonuOrtalama()
    {
        int dersSayisi;
        double[] krediSayisi;
        double kredi;
        string[] dersİsmi;
        double toplamKredi = 0;
        double ortalama = 0;
        string ders, harfNotu;

        Console.WriteLine("Dönem sonu ortalama hesaplama ");
        Console.Write("Ders sayısı : ");
        dersSayisi = Convert.ToInt32(Console.ReadLine());
        dersİsmi = new string[dersSayisi];
        krediSayisi = new double[dersSayisi];
        for (int i = 0; i < dersSayisi; i++)
        {
            Console.Write($"{i + 1}. ders : ");
            ders = Console.ReadLine();
            dersİsmi[i] = ders;
            Console.Write($"{dersİsmi[i]} dersinin kredi sayısı : ");
            kredi = Convert.ToDouble(Console.ReadLine());
            krediSayisi[i] = kredi;
            Console.Write($"{dersİsmi[i]} dersinin harf notu : ");
            harfNotu = Console.ReadLine();
            if (harfNotu == "AA" || harfNotu == "aa")
            {
                ortalama += krediSayisi[i] * 4;
            }
            else if (harfNotu == "BA" || harfNotu == "ba")
            {
                ortalama += krediSayisi[i] * 3.5;
            }
            else if (harfNotu == "BB" || harfNotu == "bb")
            {
                ortalama += krediSayisi[i] * 3;
            }
            else if (harfNotu == "CB" || harfNotu == "cb")
            {
                ortalama += krediSayisi[i] * 2.5;
            }
            else if (harfNotu == "CC" || harfNotu == "cc")
            {
                ortalama += krediSayisi[i] * 2;
            }
            else if (harfNotu == "DC" || harfNotu == "dc")
            {
                ortalama += krediSayisi[i] * 1.5;
            }
            else if (harfNotu == "DD" || harfNotu == "dd")
            {
                ortalama += krediSayisi[i] * 1;
            }
            else if (harfNotu == "FD" || harfNotu == "fd")
            {
                ortalama += krediSayisi[i] * 0.5;
            }
            else if (harfNotu == "FF" || harfNotu == "ff")
            {
                ortalama += krediSayisi[i] * 0;
            }
            else
            {
                Console.WriteLine("Geçersiz harf notu girdiniz.");
            }
        }

        for (int i = 0; i < dersSayisi; i++)
        {
            toplamKredi += krediSayisi[i];
        }
        Console.WriteLine($"Dönem sonu ortalamanız : {ortalama / toplamKredi}");
    }
    public void LiseOrtalama()
    {
        int dersSayisi;
        string[] dersİsmi;
        double[] dersSaati;
        double toplamDersSaati = 0;
        double dersSonOrt;
        double donemNotu = 0;
        string ders;

        Console.WriteLine("Lise ortalama hesapla ");
        Console.Write("\nDers sayısı : ");
        dersSayisi = Convert.ToInt32(Console.ReadLine());
        dersİsmi = new string[dersSayisi];
        dersSaati = new double[dersSayisi];
        Console.WriteLine("\nDerslerin isimlerini giriniz  ");

        for (int i = 0; i < dersSayisi; i++)
        {
            Console.Write($"{i + 1}. ders : ");
            ders = Console.ReadLine();
            dersİsmi[i] = ders;
            Console.Write("Ders saatinizi giriniz : ");
            dersSaati[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write("1. sınav notu : ");
            double sinav1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. sınav notu : ");
            double sinav2 = Convert.ToDouble(Console.ReadLine());
            double sinavOrt = (sinav1 + sinav2) / 2;

            Console.Write("1. sözlü notu : ");
            double sozlu1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. sözlü notu : ");
            double sozlu2 = Convert.ToDouble(Console.ReadLine());
            double sozluOrt = (sozlu1 + sozlu2) / 2;

            toplamDersSaati += dersSaati[i];
            dersSonOrt = (sinavOrt + sozluOrt) / 2;
            Console.WriteLine($"{dersİsmi[i]} dersinin ortalaması : {dersSonOrt}");

            donemNotu += (dersSonOrt * dersSaati[i]);
        }
        Console.WriteLine($"Dönem sonu ortalamanız : {donemNotu / toplamDersSaati}");
    }
}
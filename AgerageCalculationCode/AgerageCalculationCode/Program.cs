using System.Security.Cryptography.X509Certificates;

namespace AgerageCalculationCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ortalama Hesapalama Uygulaması");

            Console.WriteLine("KULLANICI GİRİŞİ");
            string username, password;
            username = "Abdulaziz";
            password = "Aea0000";
            while (username != "Abdulaziz" || password != "Aea0000")
            {
                if (username != "Abdulaziz" || password != "Aea0000")
                {
                    Console.WriteLine("Kullanıcı adı veya şifreniz yanlış.");
                }

                else
                {
                    Console.WriteLine("Giriş yapılıyor...");
                }
            }

            Console.WriteLine("1- Ders ortalaması " +
                "\n2- Dönem sonu ");
            Console.WriteLine("Ne hesaplamak istiyorsunuz: ");
            string islem;
            islem = Console.ReadLine();
            string[] dersİsmi;
            double[] ortalama;
            double[] krediSayisi;
            double ortal = 0;
            switch (islem)
            {
                case "1":
                    Console.WriteLine("ortalama hesapla ");
                    Console.Write("\nDers sayısı : ");
                    int dersSayisi = Convert.ToInt32(Console.ReadLine());
                    dersİsmi = new string[dersSayisi];
                    Console.WriteLine("\nDerslerin isimlerini giriniz  ");

                    for (int i = 0; i < dersSayisi; i++)
                    {
                        Console.Write($"{i + 1}. ders : ");
                        string ders = Console.ReadLine();
                        dersİsmi[i] = ders;
                    }

                    ortalama = new double[dersSayisi];
                    for (int i = 0; i < dersSayisi; i++)
                    {
                        Console.WriteLine($"\n{dersİsmi[i]} dersi için : ");
                        Console.Write("Vize notu : ");
                        double vize = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ödev notu : ");
                        double odev = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Final notu : ");
                        double final = Convert.ToDouble(Console.ReadLine());
                        double ort = (vize * 30 / 100) + (odev * 10 / 100) + (final * 60 / 100);

                        Console.WriteLine($"{dersİsmi[i]} dersinin ortalaması : {ort}");
                    }



                    break;

                case "2":

                    Console.WriteLine("Dönem sonu ortalama hesaplama ");
                    Console.Write("Ders sayısı : ");
                    int dersSayisi2 = Convert.ToInt32(Console.ReadLine());
                    dersİsmi = new string[dersSayisi2];
                    krediSayisi = new double[dersSayisi2];
                    for (int i = 0; i < dersSayisi2; i++)
                    {
                        Console.Write($"{i + 1}. ders : ");
                        string ders = Console.ReadLine();
                        dersİsmi[i] = ders;
                        Console.Write($"{dersİsmi[i]} dersinin kredi sayısı : ");
                        double kredi = Convert.ToDouble(Console.ReadLine());
                        krediSayisi[i] = kredi;
                        Console.Write($"{dersİsmi[i]} dersinin harf notu : ");
                        string harfNotu = Console.ReadLine();
                        if (harfNotu == "AA" || harfNotu == "aa")
                        {
                            ortal += krediSayisi[i] * 4;
                        }
                        else if (harfNotu == "BA" || harfNotu == "ba")
                        {
                            ortal += krediSayisi[i] * 3.5;
                        }
                        else if (harfNotu == "BB" || harfNotu == "bb")
                        {
                            ortal += krediSayisi[i] * 3;
                        }
                        else if (harfNotu == "CB" || harfNotu == "cb")
                        {
                            ortal += krediSayisi[i] * 2.5;
                        }
                        else if (harfNotu == "CC" || harfNotu == "cc")
                        {
                            ortal += krediSayisi[i] * 2;
                        }
                        else if (harfNotu == "DC" || harfNotu == "dc")
                        {
                            ortal += krediSayisi[i] * 1.5;
                        }
                        else if (harfNotu == "DD" ||harfNotu == "dd")
                        {
                            ortal += krediSayisi[i] * 1;
                        }
                        else if (harfNotu == "FD" || harfNotu == "fd")
                        {
                            ortal += krediSayisi[i] * 0.5;
                        }
                        else if (harfNotu == "FF" || harfNotu == "ff")
                        {
                            ortal += krediSayisi[i] * 0;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz harf notu girdiniz.");
                        }

                    }
                    double toplamKredi = 0;
                    for (int i = 0; i < dersSayisi2; i++)
                    {
                        toplamKredi += krediSayisi[i];
                    }
                    Console.WriteLine($"Dönem sonu ortalamanız : {ortal / toplamKredi}");
                    break;
            
            
            }
              
            // 7 TEMMUZDA DEĞİŞİKLİKLER YAPTIM.   


        }
    }
}

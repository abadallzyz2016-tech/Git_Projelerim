using System;

namespace RPSGame
{

    internal class Properties
    {
        private static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TKM_Skoru.txt");


        public static void SkorKaydetme(string oyuncuAdi, int skor)
        {
            string record = $"{DateTime.Now} | {oyuncuAdi} | {skor}";
            File.AppendAllText(filePath, record + Environment.NewLine);
        }

        public static void ShowScores()
        {
            Console.WriteLine("Bütün skorları görmek için '0' yazın : ");
            Console.Write("Son 5 skor için '5' yazın : ");
            string skorSecim = Console.ReadLine();
            if (skorSecim == "0")
            {
                if (File.Exists(filePath))
                {
                    string[] skorlar = File.ReadAllLines(filePath); // Tüm skorları oku
                    Console.WriteLine("=== Geçmiş Skorlar ===");
                    foreach (string skor in skorlar)
                    {
                        Console.WriteLine(skor);
                    }
                }
                else
                {
                    Console.WriteLine("Henüz kayıtlı skor bulunmuyor.");
                }
            }
            else if (skorSecim == "5")
            {
                if (File.Exists(filePath))
                {
                    string[] skorlar = File.ReadAllLines(filePath).Reverse().Take(5).ToArray(); // Son 5 skoru oku

                    Console.WriteLine("=== Geçmiş son 5 Skor ===");

                    foreach (string skor in skorlar)
                    {
                        Console.WriteLine(skor);
                    }
                }
                else
                {
                    Console.WriteLine("Henüz kayıtlı skor bulunmuyor.");
                }
            }
        }

        internal void level1()
        {
            int secim;
            int kullaniciSkoru = 0, bilgisayarSkoru = 0;
            Random random = new Random();
            Console.Write("Oyuncu adı : ");
            string oyuncuAdi = Console.ReadLine();

            Console.WriteLine("1-taş, 2-kağıt, 3-makas ");

            for (int i = 0; i < 5; i++)
            {
                int sekil = random.Next(1, 4); // 1: Taş, 2: Kağıt, 3: Makas 
                Console.Write("\nBir şekil seç : ");
                secim = int.Parse(Console.ReadLine());
                if (secim == 1 || secim == 2 || secim == 3)
                {
                    if (secim == sekil)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Bilgisayarın seçimi: {sekil}");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Berabere!");
                        Console.ResetColor();
                        i--; // Berabere durumunda turu tekrar ettir
                    }
                    else if ((secim == 1 && sekil == 3) || (secim == 2 && sekil == 1) || (secim == 3 && sekil == 2))
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Bilgisayarın seçimi: {sekil}");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("helal bir sayı aldın! ");
                        Console.ResetColor();
                        kullaniciSkoru++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Bilgisayarın seçimi: {sekil}");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Sayı alamadın, bol şanslar ");
                        Console.ResetColor();
                        bilgisayarSkoru++;
                    }
                    if (kullaniciSkoru == 3 || bilgisayarSkoru == 3)
                    {
                        break; ;
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim! Lütfen 1, 2 veya 3 girin.");
                    i--; // Geçersiz seçim durumunda turu tekrar ettir
                }
            }

            if (kullaniciSkoru > bilgisayarSkoru)
            {
                Console.WriteLine("Oyun bitti!");
                Console.WriteLine($"Kullanıcı Skoru: {kullaniciSkoru}");
                Console.WriteLine($"Bilgisayar Skoru: {bilgisayarSkoru}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("***** Tebrikler, kazandın! *****");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Oyun bitti!");
                Console.WriteLine($"Kullanıcı Skoru: {kullaniciSkoru}");
                Console.WriteLine($"Bilgisayar Skoru: {bilgisayarSkoru}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" :( Üzgünüm,  Kaybettin ");
                Console.ResetColor();
            }

            Console.WriteLine("Skorunu kaydetmek istiyor musun ? (Y, N)");
            string cevap = Console.ReadLine().ToUpper();
            if (cevap == "Y")
            {
                Properties.SkorKaydetme(oyuncuAdi, kullaniciSkoru);
                Console.WriteLine("Skor kaydedildi.");
            }
            else
            {
                Console.WriteLine("Skor kaydedilmedi ! ");
            }
        }

        internal void level2()
        {
            int secim;
            int kullaniciSkoru = 0, bilgisayarSkoru = 0;
            Random random = new Random();
            Console.Write("Oyuncu adı : ");
            string oyuncuAdi = Console.ReadLine();

            Console.WriteLine("1-taş, 2-kağıt, 3-makas ");

           for (int i = 0; i < 9; i++)
            {
                int sekil = random.Next(1, 4); // 1: Taş, 2: Kağıt, 3: Makas 
                Console.Write("\nBir şekil seç : ");
                secim = int.Parse(Console.ReadLine());
                if (secim == 1 || secim == 2 || secim == 3)
                {
                    if (secim == sekil)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Bilgisayarın seçimi: {sekil}");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Berabere!");
                        Console.ResetColor();
                        i--; // Berabere durumunda turu tekrar ettir
                    }
                    else if ((secim == 1 && sekil == 3) || (secim == 2 && sekil == 1) || (secim == 3 && sekil == 2))
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Bilgisayarın seçimi: {sekil}");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("helal bir sayı aldın! ");
                        Console.ResetColor();
                        kullaniciSkoru++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Bilgisayarın seçimi: {sekil}");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Sayı alamadın, bol şanslar ");
                        Console.ResetColor();
                        bilgisayarSkoru++;
                    }
                    if (kullaniciSkoru == 5 || bilgisayarSkoru == 5)
                    {
                        break; ;
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim! Lütfen 1, 2 veya 3 girin.");
                    i--; // Geçersiz seçim durumunda turu tekrar ettir
                }
            }

            if (kullaniciSkoru > bilgisayarSkoru)
            {
                Console.WriteLine("Oyun bitti!");
                Console.WriteLine($"Kullanıcı Skoru: {kullaniciSkoru}");
                Console.WriteLine($"Bilgisayar Skoru: {bilgisayarSkoru}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("***** Tebrikler, kazandın! *****");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Oyun bitti!");
                Console.WriteLine($"Kullanıcı Skoru: {kullaniciSkoru}");
                Console.WriteLine($"Bilgisayar Skoru: {bilgisayarSkoru}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" :( Üzgünüm,  Kaybettin ");
                Console.ResetColor();
            }

            Console.WriteLine("Skorunu kaydetmek istiyor musun ? (Y, N)");
            string cevap = Console.ReadLine().ToUpper();
            if (cevap == "Y")
            {
                Properties.SkorKaydetme(oyuncuAdi, kullaniciSkoru);
                Console.WriteLine("Skor kaydedildi.");
            }
            else
            {
                Console.WriteLine("Skor kaydedilmedi ! ");
            }
        }
    }
}

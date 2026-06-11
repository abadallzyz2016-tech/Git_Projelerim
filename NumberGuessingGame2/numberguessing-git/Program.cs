using System.Diagnostics;
using System.Net.Http.Headers;

namespace nuberguessing_git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı Tahmin Oyunu");
            string seviye;
            string islem;
            do
            {
                Console.WriteLine("\"Oyun\"  =======  \"Oyun hakkinda\"  =======  \"Talimatlar");
                Console.WriteLine("Çıkış için \"cikis\"");
                Console.Write("Yapmak istediğin işlemi gir : ");
                islem = Console.ReadLine();
                switch (islem)
                {
                    case "oyun":
                    case "Oyun":
                        do
                        {
                            Console.WriteLine("1. seviye(1)  =====  2. seviye(2)  =====  3. seviye(3) ");
                            Console.WriteLine("1 adım geri gitmek için \"Geri\"");
                            Console.Write("Seviye Seç : ");
                            seviye = Console.ReadLine();
                            switch (seviye)
                            {
                                case "1":
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Kolay Seviye ");
                                    Console.WriteLine("1 - 100 arasında bir sayı tahmin et");
                                    Console.WriteLine("5 hakkın var, iyi düşün...\n");
                                    Console.ResetColor();
                                    Random random = new Random();
                                    int uretilenSayi = random.Next(1, 101); // 1 ile 100 arasında rastgele bir sayı üretir.
                                    int[] tahmin = new int[5];
                                    for (int i = 0; i < 5; i++)
                                    {
                                        Console.Write($"{i + 1}. tahminini gir : ");
                                        tahmin[i] = Convert.ToInt32(Console.ReadLine());
                                        if (tahmin[i] == uretilenSayi)
                                        {
                                            Console.WriteLine("Tebrikler! Doğru tahmin ettin.");
                                            break;
                                        }
                                        else if (tahmin[i] < uretilenSayi)
                                        {
                                            Console.WriteLine("Daha yüksek bir sayı dene.");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Daha düşük bir sayı dene.");
                                        }
                                    }
                                    Console.WriteLine("Oyun bitti  ");
                                    Console.WriteLine($"Tutulan sayı : {uretilenSayi}");
                                    break;

                                case "2":
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Orta Seviye ");
                                    Console.WriteLine("1 - 250 arasında bir sayı tahmin et.");
                                    Console.WriteLine("8 hakkın var, iyi düşün \n");
                                    Console.ResetColor();
                                    Random random2 = new Random();
                                    int uretilenSayi2 = random2.Next(1, 251); // 1 ile 200 arasında rastgele bir sayı üretir.
                                    int[] tahmin2 = new int[8];
                                    for (int i = 0; i < 8; i++)
                                    {
                                        Console.Write($"{i + 1}. tahminini gir : ");
                                        tahmin2[i] = Convert.ToInt32(Console.ReadLine());
                                        if (tahmin2[i] == uretilenSayi2)
                                        {
                                            Console.WriteLine("Tebrikler! Doğru tahmin ettin.");
                                            break;
                                        }
                                        else if (tahmin2[i] < uretilenSayi2)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            if (uretilenSayi2 - tahmin2[i] > 25)
                                            {
                                                Console.WriteLine("Çok daha yüksek bir sayı dene.");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Daha yüksek bir sayı dene.");
                                            }
                                            Console.ResetColor();
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            if (tahmin2[i] - uretilenSayi2 > 25)
                                            {
                                                Console.WriteLine("Çok daha düşük bir sayı dene.");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Daha düşük bir sayı dene.");
                                            }
                                            Console.ResetColor();
                                        }
                                    }
                                    Console.WriteLine("Oyun bitti ");
                                    Console.WriteLine($"Tutulan sayı : {uretilenSayi2}");
                                    break;

                                case "3":
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Zor Seviye ");
                                    Console.WriteLine("1 - 500 arasında bir sayı tahmin et.");
                                    Console.WriteLine("10 Hakkın var, stratejini iyi yaz.\n ");
                                    Console.ResetColor();
                                    Random random3 = new Random();
                                    int uretilenSayi3 = random3.Next(1, 501); // 1 ile 500 arasında rastgele bir sayı üretir.
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Console.Write($"{i + 1}. tahminini gir : ");
                                        int[] tahmin3 = new int[10];
                                        tahmin3[i] = Convert.ToInt32(Console.ReadLine());
                                        if (tahmin3[i] == uretilenSayi3)
                                        {
                                            Console.WriteLine("Tebrikler! Doğru tahmin ettin.");

                                            break;
                                        }
                                        else if (tahmin3[i] < uretilenSayi3)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;

                                            if (uretilenSayi3 - tahmin3[i] > 50)
                                            {
                                                Console.WriteLine("Çok daha yüksek bir sayı dene.");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Daha yüksek bir sayı dene.");
                                            }
                                            Console.ResetColor();
                                        }

                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            if (tahmin3[i] - uretilenSayi3 > 50)
                                            {
                                                Console.WriteLine("Çok daha düşük bir sayı dene.");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Daha düşük bir sayı dene.");
                                            }
                                            Console.ResetColor();
                                        }
                                    }
                                    Console.WriteLine($"Oyun bitti ");
                                    Console.WriteLine($"Tutulan sayı : {uretilenSayi3}");
                                    break;

                                case "Geri":

                                    break;

                                default:
                                    Console.WriteLine("Geçersiz Seviye Seçimi. Lütfen 1, 2 veya 3'ü seçiniz.");
                                    break;
                            }
                        } while (seviye != "Geri");
                        break;

                    case "Oyun hakkinda":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n1. Kısa Özet");
                        Console.ResetColor();
                        Console.WriteLine("\r- \"Zihninizi ve mantığınızı test edecek, odaklanma gerektiren bir sayı tahmin deneyimi. İpuçlarını takip edin, olasılıkları daraltın ve gizli şifreyi en az hamlede kırın.\"\n");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("2. Konsept ve Amacımız");
                        Console.ResetColor();
                        Console.WriteLine("- Karmaşık bir sistemin kilidini açmaya çalışan bir şifre kırıcı rolündesiniz. Sistemin hafızasında tuttuğu gizli değeri bulmak için tamamen stratejik düşünmelisiniz. Yaptığınız her tahminde sistem size yön gösterecek; aldığınız \"Daha Büyük\" veya \"Daha Küçük\" geri bildirimleriyle olasılık uzayını adım adım daraltarak doğru sonuca ulaşacaksınız.\n");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("3. Öne Çıkan Özellikler");
                        Console.ResetColor();
                        Console.WriteLine("- Genişleyen Zorluk Seviyeleri: 1-100 arası rahatlatıcı bir ısınma turundan, 1-500 arası derinlemesine bir odaklanma gerektiren usta seviyelerine kadar kendinizi sınayın.\n");
                        Console.WriteLine("- Akıllı İpucu Sistemi: Sadece yönlendirmelerle kalmayın; hedefe ne kadar yaklaştığınızı gösteren \"daha yüksek/daha düşük\" indikatörleriyle stratejinizi şekillendirin.\n");
                        Console.WriteLine("- Performans İstatistikleri: Çözüme ulaşırken harcadığınız adım sayısını ve geçen süreyi takip edin. Kendi rekorlarınızı kırmak için analitik bir yaklaşım geliştirin.\n");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("4. Oynanış Dinamikleri");
                        Console.ResetColor();
                        Console.WriteLine("- Sistem her turda benzersiz bir hedef belirler. Klavyenizi kullanarak tahminlerinizi girin ve ekrandaki yönergeleri anlık olarak takip edin. Şifreyi en kısa ve en verimli yoldan çözmeye çalışın.\n");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("5. Geliştirici Notu");
                        Console.ResetColor();
                        Console.WriteLine("- \"Bu oyun, algoritmik düşünme becerisini ve temiz, sade bir oyun tasarımını bir araya getirme fikriyle geliştirildi. Amacım, temel bir matematiksel bulmacanın ne kadar rekabetçi ve tatmin edici olabileceğini göstermekti. En iyi skorunuzu görmek için sabırsızlanıyorum!\"\n");
                        break;

                    case "Talimatlar":
                        break;

                    default:
                        Console.WriteLine("Yanlış giriş yaptın, geçerli bir işlem seç.");
                        break;

                }
            } while (islem != "cikis");
            Console.WriteLine("Oyun bitti");


            int puan = -1;  
            while (puan < 0 || puan > 10)
            {
                Console.WriteLine("1-10 arasında bir puan veriniz.");
                puan = Convert.ToInt32(Console.ReadLine());
                if (puan > 0 && puan <= 10)
                {
                    Console.WriteLine("Teşekkür ederiz. Sağlıklı günler dileriz... ");
                    break;
                }
                else
                {
                    Console.WriteLine("Geçerli bir puan giriniz.");
                }
            }


        }
    }
}

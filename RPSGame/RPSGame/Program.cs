using System.Security.Cryptography;

namespace RPSGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========  Taş-Kağıt-Makas  =========");

            int seviye;
            while (true)
            {
                Console.WriteLine("----- Oyun modu seçin -----");
                Console.WriteLine("1) 3 olan kazanır");
                Console.WriteLine("2) 5 olan kazanır");
                Console.WriteLine("3) Skorları gör" +
                    "\n4) Çıkış");
                seviye = int.Parse(Console.ReadLine());
                switch (seviye)
                {
                    case 1:
                        Properties level1 = new Properties();
                        level1.level1();
                        
                        // Seviye 1 için işlemler
                        break;

                    case 2: 
                        Properties level2 = new Properties();
                        level2.level2();
                        // Seviye 2 için işlemler
                        break;

                    case 3:
                        Properties.ShowScores();
                        break;

                    case 4:
                        Console.WriteLine("Oyun sonlandırılıyor...");
                        return;
                    
                    default:
                        Console.WriteLine("Geçersiz seçim, lütfen 1-4 arasında bir seviye seçin.");
                        break;
                }
            } 

        }
    }
}

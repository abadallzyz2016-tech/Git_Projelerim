using System.Data;
using System.Security.Cryptography;

namespace calculator_git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çok Fonksiyonlu Hesap Makinesi");
            string islem;
            do
            {
                Console.WriteLine("\n '*' veya 'carpma'  <===>  '/' veya 'bolme'\n '+' veya 'toplama'  <===>  '-' veya 'cikarma'\n 'karekok alma'  <===>  'us hesaplama'" +
                    "\nÇıkış için 'cikis' yazınız");
                Console.Write("\n Yapmak istediğiniz işlemi seçiniz : ");
                islem = Console.ReadLine();
                switch (islem)
                {
                    case "carpma":
                    case "*":
                        Console.WriteLine("Kaç sayı ile işlem yapcaksın. ");                     //  bu satırı caselerin içerisinde yazıılması gerekir çünkü bazı işlemlerin içerisinde 2 sayı veya tek sayı yeterli olacaktır. 
                        int adet1 = Convert.ToInt32(Console.ReadLine());

                        // Eğer 0 veya negatif girilirse hatayı önlemek için ufak bir kontrol
                        if (adet1 <= 0)
                        {
                            Console.WriteLine("Geçerli bir adet girmediniz.");
                            break;
                        }

                        int[] sayiAdedi1 = new int[adet1];

                        for (int i = 0; i < adet1; i++)
                        {
                            Console.Write($"{i + 1}. sayıyı giriniz : ");
                            sayiAdedi1[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        int carpim = 1;
                        for (int i = 0; i < adet1; i++)
                        {
                            carpim *= sayiAdedi1[i];
                        }
                        Console.WriteLine($"İşleminizin carpimu : {carpim}");
                        break;

                    case "bolme":
                    case "/":
                        Console.WriteLine("Bölmek istediğiniz sayıları giriniz : ");

                        Console.WriteLine(" 1. sayıyı giriniz : ");
                        int bolunen = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("2. sayıyı giriniz : ");
                        int bolen = Convert.ToInt32(Console.ReadLine());

                        if (bolen == 0)
                        {
                            Console.WriteLine("Bölen sıfır olamaz. Lütfen geçerli bir sayı giriniz.");
                            break;
                        }

                        int bolum = bolunen / bolen;
                        Console.WriteLine($"İşleminizin sonucu : {bolum}");
                        break;

                    case "toplama":
                    case "+":
                        Console.WriteLine("Kaç sayı ile işlem yapcaksın. ");
                        int adet2 = Convert.ToInt32(Console.ReadLine());
                        int[] sayiAdedi2 = new int[adet2];
                        int toplam = 0;
                        for (int i = 0; i < adet2; i++)
                        {
                            Console.Write($"{i + 1}. sayıyı giriniz :  ");
                            int sayi = Convert.ToInt32(Console.ReadLine());
                            sayiAdedi2[i] = sayi;
                        }
                        for (int i = 0; i < adet2; i++)
                        {
                            toplam += sayiAdedi2[i];
                        }
                        Console.WriteLine($"İşleminizin sonucu : {toplam}");
                        break;

                    case "cikarma":
                    case "-":
                        Console.WriteLine("Kaç sayı ile işlem yapacaksın: ");
                        int adet3 = Convert.ToInt32(Console.ReadLine());

                        // Eğer 0 veya negatif girilirse hatayı önlemek için ufak bir kontrol
                        if (adet3 <= 0)
                        {
                            Console.WriteLine("Geçerli bir adet girmediniz.");
                            break;
                        }

                        int[] sayiAdedi3 = new int[adet3];

                        // Kullanıcıdan sayıları diziye alıyoruz
                        for (int i = 0; i < adet3; i++)
                        {
                            Console.Write($"{i + 1}. sayıyı giriniz:  ");
                            sayiAdedi3[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        // İlk sayıyı sonucun başlangıç değeri olarak atıyoruz
                        int csonuc = sayiAdedi3[0];

                        // Döngüyü 1. indeksten (yani 2. sayıdan) başlatıp ilk sayıdan çıkarıyoruz
                        for (int i = 1; i < adet3; i++)
                        {
                            csonuc = csonuc - sayiAdedi3[i]; // veya kısaca csonuc -= sayiAdedi3[i];
                        }

                        Console.WriteLine($"İşleminizin sonucu: {csonuc}");
                        break;

                    /*
                        case "cikarma":
                        case "-":
                            // Hepsini sıfırdan çıkarınca doğru sonucu verecektir. çünkü çıkaarma işlemi A-B-C şeklinde yapılıyor. bu kodda 0-A-B-C olarak aldık ve A'yı -1 ile çarparsak A-B-C olur ve doğru sonuç verir.  "bu farklı bir yöntem, kullanılır ama yazılımcılar tarafından tercih edilmez çünkü bazı işlemler bilgisayarı gereksiz bir şekilde çalıştırır, yorar ve biraz kod kalabalığı olur."
                            int csonuc = 0;

                            Console.Write("Kaç sayı ile işlem yapacaksınız : ");
                            int adet3 = Convert.ToInt32(Console.ReadLine());

                            if (adet3 <= 0)
                            {
                                Console.WriteLine("Geçerli bir adet girmediniz.");
                                break;
                            }

                            int[] sayiAdedi3 = new int[adet3];

                            for (int i = 0; i < adet3; i++)
                            {
                                Console.Write($"{i + 1}. sayıyı giriniz : ");
                                sayiAdedi3[i] = Convert.ToInt32(Console.ReadLine());
                            }
                            //ilk sayıyı -1 ile çarpıp yerine kaydediyoruz.
                            sayiAdedi3[0] = sayiAdedi3[0] * -1;

                            for (int i = 0; i < adet3; i++)
                            {
                                csonuc -= sayiAdedi3[i];
                            }
                            Console.WriteLine($"İşleminiz sonucu : {csonuc}");
                            break;
                    */

                    case "karekok alma":
                        Console.WriteLine("Karekök 2. derecedendir. Girilen sayı >= 0 olmalı.");

                        Console.Write("Karekökünü almak istediğniiz sayıyı giriniz : ");
                        decimal girilenSayi = Convert.ToInt32(Console.ReadLine());

                        // Eğer 0 veya negatif girilirse hatayı önlemek için ufak bir kontrol
                        if (girilenSayi < 0)
                        {
                            Console.WriteLine("Geçerli bir sayı girmediniz.");
                            break;
                        }
                        decimal karekokSonuc = (decimal)Math.Sqrt((double)girilenSayi);
                        Console.WriteLine($"İşleminizin sonucu : {karekokSonuc} ");
                        break;

                    case "us hesaplama":
                        Console.WriteLine("Taban sayıyı giriniz :  ");
                        double taban = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Üssü giriniz : ");
                        double us = Convert.ToInt32(Console.ReadLine());

                        double ussonuc = Math.Pow(taban, us);
                        Console.WriteLine($"İşleminizin sonucu : {ussonuc} ");
                        break;
                }

            }
            while (islem != "cikis");
            Console.Write("Hesap Makinemize 10 üzerinden kaç verirsiniz : ");
            double geriBildirim = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geri bildiriminiz için teşekkür ederiz. Sağlıklı günler dileriz... ");


        }
    }
}

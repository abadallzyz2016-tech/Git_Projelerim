using System.Security.Cryptography.X509Certificates;

namespace AgerageCalculationCode
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ortalama Hesapalama Uygulaması");
            
            Console.WriteLine("1- Ders ortalaması \n2- Dönem sonu \n3- Lise ortalama");
            Console.WriteLine("Ne hesaplamak istiyorsunuz: ");
            string islem;
            islem = Console.ReadLine();
          
            switch (islem)
            {
                case "1":
                    Ortalama dersOrtalaması = new Ortalama();
                    dersOrtalaması.UniversiteDersOrtalama();
                    break;

                case "2":
                    Ortalama donemSonuOrtalama = new Ortalama();
                    donemSonuOrtalama.UniversiteDonemSonuOrtalama();
                    break;

                case "3":
                    Ortalama liseOrtalama  = new Ortalama();
                    liseOrtalama.LiseOrtalama();
                    break;
            }

        }
    }
}

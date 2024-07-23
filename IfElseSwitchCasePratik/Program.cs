using System;

namespace ıfYapısııIle
{
class program
    {
        static void Main(string[] args)

            //İlk olarak If karar yapısı ile kodu yazdım.
        {
            Console.WriteLine("Rüya Manavına Hoşgeldiniz");
            Console.WriteLine("Elma = 2TL");
            Console.WriteLine("Armut = 3TL");
            Console.WriteLine("Çilek = 2TL");
            Console.WriteLine("Muz = 3TL");
            Console.WriteLine("Diğer Bütün Meyveler = 4TL");

            Console.Write("Lütfen almak istediğiniz ürünün adını yazınız (Elma/Armut/Çilek/Muz/Diğer:");
            string meyve = Console.ReadLine();
            if (meyve == "Elma")
            {
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı 2-TL");
            }
            else if (meyve == "Armut")
            {
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı 3-TL");
            }
            else if (meyve == "Çilek")
            {
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı 2-TL");
            }
            else if (meyve == "Muz")
            {
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı 3-TL");
            }
            else
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı 3-TL");
        }
    }
}



// Switch yapısı ile de aynı kodu başka bir projede yazdırdım çalışıp çalışmadığını kontrol etmek için ancak ödev ekranında tek dosya yükleyeceğimizden buraya yapıştırdım.


namespace SwitchDegiskeni
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rüya Manavına Hoşgeldiniz");
            Console.WriteLine("Elma = 2TL");
            Console.WriteLine("Armut = 3TL");
            Console.WriteLine("Çilek = 2TL");
            Console.WriteLine("Muz = 3TL");
            Console.WriteLine("Diğer Bütün Meyveler = 4TL");

            Console.Write("Lütfen almak istediğiniz ürünün adını yazınız (Elma/Armut/Çilek/Muz/Diğer:");
            string meyve = Console.ReadLine();

            switch (meyve)
            {
                case "Elma":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı 2-TL");
                    break;

                case "Armut":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı 3-TL");
                    break;

                case "Çilek":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı 2-TL");
                    break;

                case "Muz":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı 3-TL");
                    break;

                case "Diğer":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı 4-TL");
                    break;


            }
        }
    }
}

// Bu kodu switch kodu ile yazmak daha mantıklı çünkü bir çok değişken var ve hepsini ayrı ayrı if değişkeni ile yazmaktansa Switch ile case kullanarak yazmak daha kolay ve pratik.












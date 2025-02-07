using System;

namespace OOPGyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Konyv konyv1 = new("A kis herceg", "Antoine de Saint-Exupéry", 1943, 96, 2500);
            Konyv konyv2 = new("Ez még készül", "én");

            Console.WriteLine(konyv1.ToString() + "\n" + konyv2.ToString());

            konyv1.Kedvezmeny(20);
            konyv1.Arnoveles(1000);

            Console.WriteLine(konyv2.ToString() + "\n" + konyv1.ToString());


            Console.WriteLine("-------------------------------------------");


            Film film1 = new Film("Eredet", "Christopher Nolan", 148, "Sci-fi", true);
            Film film2 = new Film("Ismeretlen film", "Ismeretlen rendező");

            Console.WriteLine(film1);
            film1.Jatszas();
            film1.MufajModositas("Akció");
            film1.HosszNovelese(10);
            Console.WriteLine(film1);

            Console.WriteLine("\n" + film2);
            film2.Jatszas();


            Console.WriteLine("-------------------------------------------");


            Videojatek karakter1 = new Videojatek("Warrior", 5, 200, 50);
            Videojatek karakter2 = new Videojatek("Rogue", 30);

            Console.WriteLine(karakter1);
            karakter1.Tamadas();
            karakter1.Gyogyulas(20);
            karakter1.Szintlepes();
            Console.WriteLine(karakter1);

            Console.WriteLine("\n" + karakter2);
            karakter2.Tamadas();
            karakter2.Gyogyulas(50);
            karakter2.Szintlepes();
            Console.WriteLine(karakter2);


            Console.WriteLine("-------------------------------------------");


            Urhajo urhajo1 = new Urhajo("Millennium Falcon", 2000, 10, 100);
            Urhajo urhajo2 = new Urhajo("X-Szárnyú", 5);

            Console.WriteLine(urhajo1);
            urhajo1.Indulas();
            urhajo1.Tankolas(50);
            urhajo1.Landolas();
            Console.WriteLine(urhajo1);

            Console.WriteLine("\n"+urhajo2);
            urhajo2.Indulas();
            urhajo2.Tankolas(10);
            urhajo2.Landolas();
            Console.WriteLine("\n" + urhajo2);
        }
    }
}

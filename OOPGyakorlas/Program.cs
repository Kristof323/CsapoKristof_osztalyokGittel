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

        }
    }
}

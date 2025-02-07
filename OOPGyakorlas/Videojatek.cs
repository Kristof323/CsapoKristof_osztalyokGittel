using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGyakorlas
{
    internal class Videojatek
    {
        private string nev;
        private int szint;
        private int eletero;
        private int ero;

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        public int Szint
        {
            get { return szint; }
            set { szint = value > 0 ? value : 1; }
        }

        public int Eletero
        {
            get { return eletero; }
            set { eletero = value >= 0 ? value : 0; }
        }

        public int Ero
        {
            get { return ero; }
            set { ero = value > 0 ? value : 1; }
        }

        public Videojatek(string nev, int szint, int eletero, int ero)
        {
            this.nev = nev;
            this.szint = szint;
            this.eletero = eletero;
            this.ero = ero;
        }

        public Videojatek(string nev, int ero)
        {
            this.nev = nev;
            this.szint = 1;
            this.eletero = 100;
            this.ero = ero;
        }

        public void Tamadas()
        {
            Console.WriteLine($"{nev} támad {ero} erővel!");
        }

        public void Gyogyulas(int mennyiseg)
        {
            if (mennyiseg > 0)
            {
                eletero += mennyiseg;
                Console.WriteLine($"{nev} gyógyult {mennyiseg} egységet. Jelenlegi életerő: {eletero}");
            }
            else
            {
                Console.WriteLine("A gyógyulás mennyisége nem lehet negatív vagy nulla.");
            }
        }

        public void Szintlepes()
        {
            szint++;
            ero += 5;
            Console.WriteLine($"{nev} szintet lépett! Új szint: {szint}, új erő: {ero}");
        }

        public override string ToString()
        {
            return $"Név: {nev}, Szint: {szint}, Életerő: {eletero}, Erő: {ero}";
        }
    }
}

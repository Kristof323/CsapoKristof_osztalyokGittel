using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGyakorlas
{
    internal class Urhajo
    {
        private string nev;
        private int sebesseg;
        private int utaskapacitas;
        private int uzemanyagSzint;

        public string Nev { get => nev; set => nev = value; }
        public int Sebesseg { get => sebesseg; set => sebesseg = value; }
        public int Utaskapacitas { get => utaskapacitas; set => utaskapacitas = value; }
        public int UzemanyagSzint { get => uzemanyagSzint; set => uzemanyagSzint = value; }

        public Urhajo(string nev, int sebesseg, int utaskapacitas, int uzemanyagSzint)
        {
            this.nev = nev;
            this.sebesseg = sebesseg;
            this.utaskapacitas = utaskapacitas;
            this.uzemanyagSzint = uzemanyagSzint;
        }

        public Urhajo(string nev, int utaskapacitas)
        {
            this.nev = nev;
            this.sebesseg = 0;
            this.utaskapacitas = utaskapacitas;
            this.uzemanyagSzint = 100;
        }

        public void Indulas()
        {
            if (uzemanyagSzint > 0)
            {
                Console.WriteLine($"{nev} elindult!");
                sebesseg += 10;
                uzemanyagSzint -= 10;
            }
            else
            {
                Console.WriteLine($"{nev} nem tud elindulni, mert nincs elég üzemanyag!");
            }
        }
        public void Tankolas(int mennyiseg)
        {
            Console.WriteLine($"{nev} tankolt {mennyiseg} egység üzemanyagot!");
            uzemanyagSzint += mennyiseg;
        }

        public void Landolas()
        {
            Console.WriteLine($"{nev} leszállt!");
            sebesseg = 0;
        }
        public override string ToString()
        {
            return $"{nev} - {sebesseg} / {utaskapacitas} / {uzemanyagSzint}";
        }
    }
}

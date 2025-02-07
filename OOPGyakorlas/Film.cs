using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGyakorlas
{
    internal class Film
    {
    private string cim;
        private string rendezo;
        private int hosszPercekben;
        private string mufaj;
        private bool megjelent;

        public string Cim
        {
            get { return cim; }
            set { cim = value; }
        }

        public string Rendezo
        {
            get { return rendezo; }
            set { rendezo = value; }
        }

        public int HosszPercekben
        {
            get { return hosszPercekben; }
            set { hosszPercekben = value > 0 ? value : 0; }
        }

        public string Mufaj
        {
            get { return mufaj; }
            set { mufaj = value; }
        }

        public bool Megjelent
        {
            get { return megjelent; }
            set { megjelent = value; }
        }

        public Film(string cim, string rendezo, int hosszPercekben, string mufaj, bool megjelent)
        {
            this.cim = cim;
            this.rendezo = rendezo;
            this.hosszPercekben = hosszPercekben;
            this.mufaj = mufaj;
            this.megjelent = megjelent;
        }

        public Film(string cim, string rendezo)
        {
            this.cim = cim;
            this.rendezo = rendezo;
            this.hosszPercekben = 120;
            this.mufaj = "Ismeretlen";
            this.megjelent = false;
        }

        public void Jatszas()
        {
            Console.WriteLine($"A(z) \"{cim}\" című film elkezdődött.");
        }

        public void MufajModositas(string ujMufaj)
        {
            mufaj = ujMufaj;
        }

        public void HosszNovelese(int percek)
        {
            if (percek > 0)
            {
                hosszPercekben += percek;
            }
        }

        public override string ToString()
        {
            return $"Cím: {cim}, Rendező: {rendezo}, Hossz: {hosszPercekben} perc, Műfaj: {mufaj}, Megjelent: {megjelent}";
        }
    }
}

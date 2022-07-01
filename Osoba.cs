using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrimerOsoba
{
    class Osoba
    {
        string ime, prezime;
        int god;

        public Osoba()
        {
            ime = prezime = "";
            god = 0;
        }
        public Osoba(string ime, string prezime, int god)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.god = god;
        }
        public Osoba(Osoba o)
        {
            this.ime = o.ime;
            this.prezime = o.prezime;
            this.god = o.god;
        }

        public void Citaj(StreamReader f)
        {
            ime = f.ReadLine();
            prezime = f.ReadLine();
            god = Convert.ToInt32(f.ReadLine());
        }
        public void Pisi(StreamWriter f)
        {
            f.WriteLine(ime);
            f.WriteLine(prezime);
            f.WriteLine(god.ToString());
        }
        public bool StarijaOd(Osoba o)
        {
            return god > o.god;
        }
        public bool MladjaOd(Osoba o)
        {
            return god < o.god;
        }
        public bool IstoGodiste(Osoba o)
        {
            return god == o.god;
        }
        public override string ToString()
        {
            return ime + " " + prezime + ", " + god + " god";
        }

    }
}

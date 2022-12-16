using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class Vedouci : Zamestnanec
    {
        int priplatekaVedeni;
        string titul;

        public Vedouci(int priplatekaVedeni, string titul, string jmeno, string prijmeni, DateTime datumNastupu, int hodinovaMzda) : base(jmeno, prijmeni, datumNastupu, hodinovaMzda)
        {
            this.priplatekaVedeni = priplatekaVedeni;
            this.titul = titul;
        }
        
        public override int VypoctiMzdu()
        {           
            return HodinovaMzda * odpracHodiny + priplatekaVedeni;
        }

    }
}

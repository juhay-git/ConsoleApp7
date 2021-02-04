using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp7
{
    public class Aanite:Teos
    {
        private String Esittaja;
        private String Kustantaja;
        private int Julkaisuvuosi;

        public Aanite(String e, String k, int vv)
        {
            Esittaja = e;
            Kustantaja = k;
            Julkaisuvuosi = vv;
        }
        public override void TulostaTiedot()
        {
            Console.WriteLine("Esittäjä: " + Esittaja);
            Console.WriteLine("Kustantaja: " + Kustantaja);
            Console.WriteLine("Julkaisuvuosi: " + Julkaisuvuosi);
            Console.WriteLine("");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp7
{
    public class Lehti : Teos
    {
        private int Numero;
        private int Vuosikerta;
      
        private String Kustantaja;
        public Lehti(String n, String k, int nn, int vv)
        {
            Nimi = n;
            Kustantaja = k;
            Numero = nn;
            Vuosikerta = vv;
        }

        public override void TulostaTiedot()
        {
            Console.WriteLine("Nimi: " + Nimi);
            Console.WriteLine("Kustantaja: " + Kustantaja);
            Console.WriteLine("Numero: " + Numero + "/" + Vuosikerta);
            Console.WriteLine("");
        }
    }
}
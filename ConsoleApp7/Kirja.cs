using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp7
{
    public class Kirja:Teos
    {
        public Kirja(String n, String t)
        {
            Nimi = n;
            Tekija = t;
        }

        public override void TulostaTiedot()
        {
            Console.WriteLine("Nimi: " + Nimi);
            Console.WriteLine("Tekijä: " + Tekija);
            Console.WriteLine("");
        }
    }

    
}
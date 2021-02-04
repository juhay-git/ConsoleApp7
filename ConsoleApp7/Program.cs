using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static List<Teos> lista;
        static void Main(string[] args)
        {
            lista = new List<Teos>();

            lista.Add(new Kirja("Hobitti", "J.R.R. Tolkien"));
            lista.Add(new Kirja("Antiikin tarinoita 1-2", "Alf Henrikson"));

            lista.Add(new Lehti("Tekniikan maailma", "A-lehdet", 3, 1984));

            lista.Add(new Aanite("Olavi Virta", "Suomilevyt", 1966));


            for(int i=0;i<lista.Count;i++)
            {
                Teos t = lista.ElementAt(i);
                t.TulostaTiedot();

                //lista.ElementAt(i).TulostaTiedot();
            }

            Console.ReadLine();
        }
    }
}

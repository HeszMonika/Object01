using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object01
{
    class Ember
    {
        public string nev;
        public int eletkor;

        public void Bemutatkozas()
        {
            Console.WriteLine("{0} vagyok, {1} éves.", nev, eletkor);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ember Pisti = new Ember();
            Ember Eva = new Ember();

            Pisti.nev = "Nagy Pisti";
            Pisti.eletkor = 20;
            
            Pisti.eletkor++;

            Eva.nev = "Nagy Éva";
            Eva.eletkor = 18;

            Console.WriteLine("{0} vagyok, {1} éves.", Pisti.nev, Pisti.eletkor);
            Console.WriteLine("{0} vagyok, {1} éves.", Eva.nev, Eva.eletkor);

            Console.ReadKey();
        }
    }
}

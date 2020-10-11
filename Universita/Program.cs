using System;
using System.Threading.Tasks.Dataflow;

namespace Universita
{
    class Program
    {
        static void Main(string[] args)
        {
            Universita u = new Universita("Politecnico Di Torino");
            Console.WriteLine("Universita: " + u.ToString()); //Universita: Politecnico Di Torino
            Rettore r = new Rettore("Enrico", "Saracco", "WHBDYV38E17E635Y");
            Console.WriteLine("Rettore: " + r.ToString()); //Rettore: Enrico Saracco
        }
    }
}

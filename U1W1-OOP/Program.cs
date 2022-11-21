using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace U1W1_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veicolo auto = new Veicolo();

            auto.Modello = "ModelX";

            Console.WriteLine($"Quella {auto.marca} è una {auto.Modello}");
            Console.ReadLine();
        }
    }
}

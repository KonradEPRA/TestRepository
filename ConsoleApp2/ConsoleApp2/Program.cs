using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            

            Console.WriteLine("Podaj imię");
            osoba.Imie = Console.ReadLine();
            Console.WriteLine("Witaj "+osoba.Imie);
            Console.ReadKey();
        }
    }
}

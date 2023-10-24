using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Animal
    {
        public virtual void Move() {
            Console.WriteLine("A");
        }
    };
    class Bird:Animal
    {
        public override void Move() 
        {
            Console.WriteLine("b");
        }
    };
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Bird();
            a.Move();
            Console.ReadLine();
        }
    }
}

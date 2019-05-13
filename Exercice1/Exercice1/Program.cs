using System;
using System.Threading;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Compteur c1 = new Compteur("Toto", 10);
            Compteur c2 = new Compteur("Titi", 10);

            new Thread(c1.Compter).Start();
            new Thread(c2.Compter).Start();

            Console.ReadLine();
        }        
    }
}

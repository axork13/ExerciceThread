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
            Compteur c3 = new Compteur("Tata", 10);

            Thread t1 = new Thread(Compter);
            Thread t2 = new Thread(Compter);
            Thread t3 = new Thread(Compter);

            t1.Start(c1);
            t2.Start(c2);
            t3.Start(c3);

            Console.ReadLine();
        }

        public static void Compter(Object o)
        {
            Random r = new Random();

            Compteur c = o as Compteur;
            
            for (int i = 1; i <= c.N; i++)
            {
                Console.WriteLine(c.Nom + " : " + i);
                Thread.Sleep(r.Next(0, 5000));
            }
            Console.WriteLine("*** " + c.Nom + " a fini de compter jusqu'à " + c.N);

        }
    }
}

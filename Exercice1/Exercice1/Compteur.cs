using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Exercice1
{
    class Compteur
    {
        public string nom;
        public int n;
        public Random r;


        public Compteur(string nom, int n)
        {
            this.nom = nom;
            this.n = n;
            Thread thread = new Thread(Compter);

            thread.Start();
         }

        public void Compter()
        {
            r = new Random();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(nom + " : " + i);
                Thread.Sleep(r.Next(0, 5000));
            }
            Console.WriteLine("*** " + nom + " a fini de compter jusqu'à " + n);

        }
    }
}

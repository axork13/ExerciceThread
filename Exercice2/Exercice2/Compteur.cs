using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Exercice2
{
    class Compteur
    {
        public string nom;
        public int n;
        public Random r;
        public int position;


        public Compteur(string nom, int n)
        {
            this.nom = nom;
            this.n = n;
        }

        public void Compter()
        {
            r = new Random();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(nom + " : " + i);
                Thread.Sleep(r.Next(0, 5000));
            }
            position++;
            Console.WriteLine("*** " + nom + " a fini de compter jusqu'à " + n + " en position " + position);

        }
    }
}

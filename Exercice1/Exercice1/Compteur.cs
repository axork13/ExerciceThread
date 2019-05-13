using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Exercice1
{
    class Compteur
    {
        private string nom;
        private int n;

        public string Nom { get => nom; set => nom = value; }
        public int N { get => n; set => n = value; }

        public Compteur(string nom, int n)
        {
            this.nom = nom;
            this.n = n;
        }


        public void Compter()
        {
            Random r = new Random();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(nom + " : " + i);
                Thread.Sleep(r.Next(0, 5000));
            }
            Console.WriteLine("*** " + nom + " a fini de compter jusqu'à " + n);

        }
    }
}

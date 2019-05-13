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
        
    }
}

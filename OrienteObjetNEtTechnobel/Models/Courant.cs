using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OrienteObjetNEtTechnobel.Models
{
    public class Courant
    {

        public string Numero { get; set; }

        public double Solde { get; private set; } = 300;

        public double LigneCredit { get; set; } = 200;

        public Personne Titulaire { get; set; }

        public void Depot(double montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Vous ne pouvez pas ajouter un montant inferieur ou egal a zero.");
                return;
            }
                
            Solde += montant;
            Console.WriteLine($"Solde actuel : {Solde}");
        }

        public void Retrait(double montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Vous ne pouvez pas enlever un montant inferieur ou egal a zero.");
                return;
            }

            if (Solde - montant < -LigneCredit)
            {
                Console.WriteLine("Chef, t'as un chat a nourrir... Force pas.");
                return;
            }

            Solde -= montant;
            Console.WriteLine($"Solde actuel : {Solde}");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrienteObjetNEtTechnobel.Models
{
    public class Banque
    {

        public string Nom { get; set; }

        Dictionary<string, Courant> Comptes {get; set;} = new Dictionary<string, Courant>();

        public Courant this[string numeroCompte]
        {
            get
            {
                Courant c;
                Comptes.TryGetValue(numeroCompte, out c);
                return c;
            }
        }

        public void Ajouter(Courant courant)
        {
            if (!Comptes.ContainsKey(courant.Numero))
            {
                Comptes.Add(courant.Numero, courant);
                Console.WriteLine($"Compte {courant.Numero} bien ajouté.");
            }
            
        }

        public void Supprimer(string numeroCompte)
        {
            if (Comptes.ContainsKey(numeroCompte))
            {
                Console.WriteLine($"Compte {this[numeroCompte].Numero} bien supprimé.");
                Comptes.Remove(numeroCompte);
                
            }
            
        }
    }
}

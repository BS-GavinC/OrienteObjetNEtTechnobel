
using OrienteObjetNEtTechnobel.Models;

Courant c1 = new Courant();
c1.Numero = "BE123";
Courant c2 = new Courant();
c2.Numero = "FR123";
Courant c3 = new Courant();
c3.Numero = "US123";

Banque banque = new Banque();

banque.Ajouter(c1);

Console.WriteLine(banque["BE123"].Solde);

banque.Supprimer("BE123");
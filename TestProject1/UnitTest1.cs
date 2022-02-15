using LeGrandRestaurant;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestProject1
{
    
    public class Tests
    {
        //ÉTANT DONNE un serveur dans un restaurant
        //QUAND il prend une commande de nourriture
        //ALORS cette commande apparaît dans la liste de tâches de la cuisine de ce restaurant
            
            [Test]
        public void TestCommandeNourriture()
        {
            List<CommandeNourriture> commande = new List<CommandeNourriture>();
            var serveur = new Serveur(commande);
            var rest = new Restaurant(serveur);
            rest.DébuterService();
            
            var restCommandeprise = rest.ListeTâchesCuisine;

            Assert.AreEqual(commande, restCommandeprise);

            //Assert.True();


        }

        [Test]
        public void TestCommandeBoisson()
        {
            List<CommandeNourriture> commande = new List<CommandeNourriture>();
            var serveur = new Serveur(commande);
            var rest = new Restaurant(serveur);
            rest.DébuterService();
            CommandeBoissons commandeBoissons = new CommandeBoissons();
            serveur.PrendreCommande(commandeBoissons);
            
            var restCommandeprise = rest.ListeTâchesCuisine;

            Assert.AreNotEqual(restCommandeprise, commandeBoissons);

            //Assert.True();


        }
    }
}
using LeGrandRestaurant;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestProject1
{
    
    public class Tests
    {
        //�TANT DONNE un serveur dans un restaurant
        //QUAND il prend une commande de nourriture
        //ALORS cette commande appara�t dans la liste de t�ches de la cuisine de ce restaurant
            
            [Test]
        public void TestCommandeNourriture()
        {
            List<CommandeNourriture> commande = new List<CommandeNourriture>();
            var serveur = new Serveur(commande);
            var rest = new Restaurant(serveur);
            rest.D�buterService();
            
            var restCommandeprise = rest.ListeT�chesCuisine;

            Assert.AreEqual(commande, restCommandeprise);

            //Assert.True();


        }

        [Test]
        public void TestCommandeBoisson()
        {
            List<CommandeNourriture> commande = new List<CommandeNourriture>();
            var serveur = new Serveur(commande);
            var rest = new Restaurant(serveur);
            rest.D�buterService();
            CommandeBoissons commandeBoissons = new CommandeBoissons();
            serveur.PrendreCommande(commandeBoissons);
            
            var restCommandeprise = rest.ListeT�chesCuisine;

            Assert.AreNotEqual(restCommandeprise, commandeBoissons);

            //Assert.True();


        }
    }
}
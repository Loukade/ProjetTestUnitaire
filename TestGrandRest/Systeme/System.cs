using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeGrandRestaurant;
using TestGrandRest.Recette;

namespace TestGrandRest.Systeme
{
    [TestClass]
    public class System
    {
        [TestMethod]
        public void TestSysteme()
        {
            //ETANT DONNEE un serveur dans un restaurant qui à une table 
            Serveur serveur = new Serveur();
            Table table = new Table();
            Restaurant restaurant = new Restaurant(serveur, table);
            Client client = new Client();

            //QUAND on affecte la table au serveur et que le client est affecté à la table
            serveur.AffecterTable(table);
            table.Affecter(client);

            //ALORS la quantité de tables disponibles dans le restaurant est à 0 
            //ET le Client est affecté à la table 
            Assert.AreEqual(restaurant.TablesLibres.Count(), 0);
            Assert.AreEqual(table.EstLibre, false);
        }

        [TestMethod]
        public void CommandeNourriture()
        {
            // ÉTANT DONNE un serveur dans un restaurant
            var serveur = new ServeurBuilder().Build();
            var restaurant = new Restaurant(serveur);

            var commande = new CommandeNourriture();

            // QUAND il prend une commande de nourriture
            serveur.PrendreCommande(commande);

            // ALORS cette commande apparaît dans la liste de tâches de la cuisine de ce restaurant
            var listeTâches = restaurant.ListeTâchesCuisine;
            Assert.AreEqual(serveur.CommandesPrises.Count(), 1);
        }

        [TestMethod]
        public void CommandeBoissons()
        {
            // ÉTANT DONNE un serveur dans un restaurant
            var serveur = new ServeurBuilder().Build();
            var restaurant = new Restaurant(serveur);

            var commande = new CommandeBoissons();

            // QUAND il prend une commande de boissons
            serveur.PrendreCommande(commande);

            // ALORS cette commande n'apparaît pas dans la liste de tâches de la cuisine de ce restaurant
            var listeTâches = restaurant.ListeTâchesCuisine;
            Assert.AreNotEqual(commande, listeTâches);
        }
    }
}

using System.Collections.Generic;
using Xunit;
using LeGrandRestaurant;

namespace MaxantTest
{
    public class CommandeNourritureTest
    {
        [Fact(DisplayName = "ÉTANT DONNE un serveur dans un restaurant " +
                                 "QUAND il prend une commande de nourriture " +
                                 "ALORS cette commande apparaît dans la liste de tâches de la cuisine de ce restaurant")]
        public void CommandeCuisine()
        {
            //ÉTANT DONNE un serveur dans un restaurant
            IList<CommandeNourriture> commande = new List<CommandeNourriture>();
            var serveur = new Serveur(commande);
            var restaurant = new Restaurant(serveur);
            restaurant.DébuterService();
            //QUAND il prend une commande de nourriture
            CommandeNourriture commandeNourriture = new CommandeNourriture();
            serveur.PrendreCommande(commandeNourriture);
            //ALORS cette commande apparaît dans la liste de tâches de la cuisine de ce restaurant
            var restCommandePrise = restaurant.ListeTâchesCuisine;

            //Assert.Empty(restaurant.ListeTâchesCuisine);
            Assert.Contains(commandeNourriture, restCommandePrise);
        }
    }
    public class CommandeBoissonTest
    {
        [Fact(DisplayName = "ÉTANT DONNE un serveur dans un restaurant " +
                           "QUAND il prend une commande de boisson " +
                           "ALORS cette commande n'apparaît pas dans la liste de tâches de la cuisine de ce restaurant")]

        public void CommandeBoissonCuisine()
        {
            //ÉTANT DONNE un serveur dans un restaurant
            IList<CommandeNourriture> commande = new List<CommandeNourriture>();
            var serveur = new Serveur(commande);
            var restaurant = new Restaurant(serveur);
            restaurant.DébuterService();
            //QUAND il prend une commande de boisson
            CommandeBoissons commandeBoisson = new CommandeBoissons();
            serveur.PrendreCommande(commandeBoisson);
            //ALORS cette commande apparaît dans la liste de tâches de la cuisine de ce restaurant

            var restCommandePrise = restaurant.ListeTâchesCuisine;
            Assert.DoesNotContain(commandeBoisson, restCommandePrise);

        }


    }
}
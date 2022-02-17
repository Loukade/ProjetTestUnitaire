using System.Collections.Generic;
using Xunit;
using LeGrandRestaurant;

namespace MaxantTest
{
    public class CommandeNourritureTest
    {
        [Fact(DisplayName = "�TANT DONNE un serveur dans un restaurant " +
                                 "QUAND il prend une commande de nourriture " +
                                 "ALORS cette commande appara�t dans la liste de t�ches de la cuisine de ce restaurant")]
        public void CommandeCuisine()
        {
            //�TANT DONNE un serveur dans un restaurant
            IList<CommandeNourriture> commande = new List<CommandeNourriture>();
            var serveur = new Serveur(commande);
            var restaurant = new Restaurant(serveur);
            restaurant.D�buterService();
            //QUAND il prend une commande de nourriture
            CommandeNourriture commandeNourriture = new CommandeNourriture();
            serveur.PrendreCommande(commandeNourriture);
            //ALORS cette commande appara�t dans la liste de t�ches de la cuisine de ce restaurant
            var restCommandePrise = restaurant.ListeT�chesCuisine;

            //Assert.Empty(restaurant.ListeT�chesCuisine);
            Assert.Contains(commandeNourriture, restCommandePrise);
        }
    }
    public class CommandeBoissonTest
    {
        [Fact(DisplayName = "�TANT DONNE un serveur dans un restaurant " +
                           "QUAND il prend une commande de boisson " +
                           "ALORS cette commande n'appara�t pas dans la liste de t�ches de la cuisine de ce restaurant")]

        public void CommandeBoissonCuisine()
        {
            //�TANT DONNE un serveur dans un restaurant
            IList<CommandeNourriture> commande = new List<CommandeNourriture>();
            var serveur = new Serveur(commande);
            var restaurant = new Restaurant(serveur);
            restaurant.D�buterService();
            //QUAND il prend une commande de boisson
            CommandeBoissons commandeBoisson = new CommandeBoissons();
            serveur.PrendreCommande(commandeBoisson);
            //ALORS cette commande appara�t dans la liste de t�ches de la cuisine de ce restaurant

            var restCommandePrise = restaurant.ListeT�chesCuisine;
            Assert.DoesNotContain(commandeBoisson, restCommandePrise);

        }


    }
}
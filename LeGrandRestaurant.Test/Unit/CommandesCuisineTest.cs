using LeGrandRestaurant.Test.Utilities;
using Xunit;

namespace LeGrandRestaurant.Test.Unit
{
    public class CommandesCuisineTest
    {
        [Fact]
        public void PrendreCommandeNourriture_AjouteLaCommandeDansLaListeDuServeur()
        {
            var serveur = new ServeurBuilder().Build();
            var commande = new CommandeNourriture();
            serveur.PrendreCommande(commande);

            Assert.Contains(commande, serveur.CommandesPrises);
        }

        [Fact]
        public void PrendreCommandeBoissons_AjouteLaCommandeDansLaListeDuServeur()
        {
            var serveur = new ServeurBuilder().Build();
            var commande = new CommandeBoissons();
            serveur.PrendreCommande(commande);

            Assert.Empty(serveur.CommandesPrises);
        }
    }
}

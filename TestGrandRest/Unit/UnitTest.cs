using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeGrandRestaurant;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestGrandRest.Recette;

namespace TestGrandRest.Unit
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void AffecterTableServeur_AjouteLaTableDansLaListeDesTablesDuServeur()
        {
            //ETANT DONNEE un serveur a qui on affecte une table 
            Serveur serveur = new Serveur();
            Table table = new Table();

            //QUAND on affecte la table au serveur 
            serveur.AffecterTable(table);

            //ALORS la quantité de tables que le serveur s'occupe est de 1

            Assert.AreEqual(serveur.getListeTable().Count, 1);
        }

        [TestMethod]
        public void PrendreCommandeNourriture_AjouteLaCommandeDansLaListeDuServeur()
        {
            // ÉTANT DONNE un serveur 
            var serveur = new ServeurBuilder().Build();
            var commande = new CommandeNourriture();

            // QUAND il prend une commande de nourriture
            serveur.PrendreCommande(commande);

            // ALORS cette commande apparaît dans la liste des commande du serveur
            Assert.AreEqual(serveur.CommandesPrises.Count(), 1);
        }
    }
}

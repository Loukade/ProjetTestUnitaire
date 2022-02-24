using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeGrandRestaurant;

namespace TestGrandRest.Recette
{
    [TestClass]
    public class TestRecette
    {
        [TestMethod]
        public void TestRecettes()
        {
            //ÉTANT DONNE une liste de table et un serveur
            var mesTables = new List<Table>();
            Table uneTable = new Table();
            Table uneTable2 = new Table();
            List<Table> mesTables2 = new List<Table>();
            Serveur serveurChoisi = new Serveur(mesTables2);

            // QUAND on lui affecte deux tables 
            mesTables.Add(uneTable);
            mesTables.Add(uneTable2);

            foreach (var table in mesTables)
            {
                serveurChoisi.AffecterTable(table);
            }

            //ALORS cette table appraît sur la liste des tables libres du serveur
            var listeTablesServer = new List<Table>(mesTables);
            Assert.AreEqual(listeTablesServer.Count(), serveurChoisi.getListeTable().Count());

        }
    }
}

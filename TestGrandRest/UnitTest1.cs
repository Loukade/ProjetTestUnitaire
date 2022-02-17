using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeGrandRestaurant;
using System.Linq;

namespace TestGrandRest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //ÉTANT DONNE une table dans un restaurant ayant débuté son service
            Table maTable = new Table();
            Restaurant monRestaurant = new Restaurant(maTable);
            //QUAND un client est affecté à une table
            Client monClient = new Client();
            maTable.Affecter(monClient);
            //ALORS cette table n'est plus sur la liste des tables libres du restaurant
            Assert.AreEqual(monRestaurant.TablesLibres, Enumerable.Empty<Table>());

        }
        [TestMethod]
        public void TestMethod2()
        {
            //ÉTANT DONNE une table occupée par un client
            Table maTable = new Table();
            Restaurant monRestaurant = new Restaurant(maTable);
            Client monClient = new Client();
            maTable.Affecter(monClient);
            //QUAND la table est libérée
            maTable.Libérer();
            //ALORS cette table appraît sur la liste des tables libres du restaurant
            Assert.AreNotEqual(monRestaurant.TablesLibres, Enumerable.Empty<Table>());

        }
    }
}
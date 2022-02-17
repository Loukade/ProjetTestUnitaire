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
            //�TANT DONNE une table dans un restaurant ayant d�but� son service
            Table maTable = new Table();
            Restaurant monRestaurant = new Restaurant(maTable);
            //QUAND un client est affect� � une table
            Client monClient = new Client();
            maTable.Affecter(monClient);
            //ALORS cette table n'est plus sur la liste des tables libres du restaurant
            Assert.AreEqual(monRestaurant.TablesLibres, Enumerable.Empty<Table>());

        }
        [TestMethod]
        public void TestMethod2()
        {
            //�TANT DONNE une table occup�e par un client
            Table maTable = new Table();
            Restaurant monRestaurant = new Restaurant(maTable);
            Client monClient = new Client();
            maTable.Affecter(monClient);
            //QUAND la table est lib�r�e
            maTable.Lib�rer();
            //ALORS cette table appra�t sur la liste des tables libres du restaurant
            Assert.AreNotEqual(monRestaurant.TablesLibres, Enumerable.Empty<Table>());

        }
    }
}
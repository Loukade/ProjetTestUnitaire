using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeGrandRestaurant;
using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json.Nodes;

namespace TestGrandRest.Integration
{
    [TestClass]
    public class Integration
    {
        [TestMethod]
        public void IntegrationServeur()
        {
            //// ÉTANT DONNE un serveur dans un restaurant 
            JsonObject jsonStringTest = new JsonObject();

            //// QUAND il se prénomme pierre
            jsonStringTest.Add("id", "1");
            jsonStringTest.Add("age", "20");
            jsonStringTest.Add("Nom", "Pierre");

            //// ALORS il doit s'appeler pierre 
            Serveur monServeur2 = new Serveur(1, 20, "Pierre");
            Assert.AreEqual(jsonStringTest["Nom"].ToString(), monServeur2.Nom);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeGrandRestaurant;

namespace TestGrandRest.Recette
{
    internal class ServeurGenerator
    {
 
            private readonly ServeurBuilder _builder;

            public ServeurGenerator(bool isIntegration = false)
            {
                _builder = new ServeurBuilder(isIntegration);
            }

            public IEnumerable<Serveur> Generate(int nombre)
            {
                for (var i = 0; i < nombre; i++)
                {
                    yield return _builder.Build();
                }
            
        
            }

    }
}

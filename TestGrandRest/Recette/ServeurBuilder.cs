using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeGrandRestaurant;

namespace TestGrandRest.Recette
{
    internal class ServeurBuilder
    {
        private readonly IList<Table> _tableRepository;

        public ServeurBuilder(bool isIntegration = false)
        {
            _tableRepository = isIntegration ? new DatabaseTableRepository() : new List<Table>();
        }

        public Serveur Build() => new(_tableRepository);
    }
}


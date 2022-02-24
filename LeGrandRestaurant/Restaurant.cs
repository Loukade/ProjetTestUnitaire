namespace LeGrandRestaurant
{
    public class Restaurant
    {
        private readonly Serveur[] _serveurs;
        private readonly Serveur _serveur;
        private readonly Table _table;

        public Restaurant(Table table)
        {
            _table = table;
        }

        public Restaurant(params Serveur[] serveurs)
        {
            _serveurs = serveurs;
        }
        public Restaurant(Serveur serveurs, Table table)
        {
            _serveur = serveurs;
            _table = table;
        }

        public IEnumerable<Table> TablesLibres => _table.EstLibre ? new[] { _table } : Enumerable.Empty<Table>();
        public IEnumerable<ICommande> ListeTâchesCuisine => _serveurs.SelectMany(serveur => serveur.CommandesPrises);

        public void DébuterService()
        {
        }
    }
}

namespace LeGrandRestaurant
{
    public class Serveur
    {

            public int id { get; set; }
            public int age { get; set; }
            public string? Nom { get; set; }
        
        public IEnumerable<CommandeNourriture> CommandesPrises => _commandesPrises;
        private readonly IList<CommandeNourriture> _commandesPrises = new List<CommandeNourriture>();

       // private readonly IList<CommandeNourriture> _commandesPrises;
        private readonly IList<Table> _tablePrises = new List<Table>();


        public Serveur(IList<CommandeNourriture> commandeRepository)
        {
            _commandesPrises = commandeRepository;
        }
        public Serveur(IList<Table> tableRepository)
        {
            _tablePrises = tableRepository;
        }

        public Serveur()
        {
        }

        public Serveur(int id, int age, string nom)
        {
            this.id = id;
            this.age = age;
            this.Nom = nom;
        }

        public void PrendreCommande(ICommande commande)
        {
            if(commande is CommandeNourriture commandeNourriture)
                _commandesPrises.Add(commandeNourriture);
        }

        public void AffecterTable(Table table)
        {
            _tablePrises.Add(table); 
        }
        public IList<Table> getListeTable()
        {
            return _tablePrises;

        }
    }
}

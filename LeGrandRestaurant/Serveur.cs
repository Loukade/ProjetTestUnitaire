namespace LeGrandRestaurant
{
    public class Serveur
    {
        public IEnumerable<CommandeNourriture> CommandesPrises => _commandesPrises;

        private readonly IList<CommandeNourriture> _commandesPrises;

        public Serveur(IList<CommandeNourriture> commandeRepository)
        {
            _commandesPrises = commandeRepository;
        }

        public void PrendreCommande(ICommande commande)
        {
            if(commande is CommandeNourriture commandeNourriture)
                _commandesPrises.Add(commandeNourriture);
        }
    }
}

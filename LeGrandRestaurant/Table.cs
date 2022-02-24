namespace LeGrandRestaurant
{
    public class Table
    {
        public Table()
        {
            EstLibre = true;
        }

        public void Affecter(Client client)
        {
            EstLibre = false;
        }

        public void Libérer()
        {
            EstLibre = true;
        }

        public bool EstLibre { get; private set; } = true;
    }
}

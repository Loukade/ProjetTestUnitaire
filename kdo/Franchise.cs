using System.Collections.Generic;

namespace LeGrandRestaurant
{
    public class Franchise
    {
        private readonly Menu _menu;

        public Franchise(Restaurant restaurant)
        {
            _menu = new Menu();
        }

        public void FixerPrix(Plat plat, decimal nouveauPrix)
            => _menu.FixerPrix(plat, nouveauPrix);
    }
}

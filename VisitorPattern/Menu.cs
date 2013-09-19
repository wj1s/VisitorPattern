using System.Collections.Generic;

namespace VisitorPattern
{
    public class Menu
    {
        private List<MenuItem> MenuItems { get; set; }

        public Menu(List<MenuItem> menuItems)
        {
            MenuItems = menuItems;
        }
    }
}

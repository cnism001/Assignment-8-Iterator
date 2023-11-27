using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8_Iterator
{
    // PancakeHouseMenu implements the IMenu interface, indicating it must provide
    // an implementation for the CreateIterator method.
    public class PancakeHouseMenu : IMenu
    {
        // A List to store the menu items. 
        private List<MenuItem> menuItems;

        // Method to add a MenuItem instance to the  menuItems list. 
        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem);
        }

        // Constructor for PancakeHouseMenu. It initializes the menuItems list and adds some items to it .
        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>();

            
            AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99);
            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99);
            AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49);
            AddItem("Waffles", "Waffles with your choice of blueberries or strawberries", true, 3.59);
        }


        // CreateIterator method from IMenu interface, it returns an enumerator for the menuItems list.
        public IEnumerator<MenuItem> CreateIterator()
        {
            return menuItems.GetEnumerator();
        }
    }

}

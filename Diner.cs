using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8_Iterator
{
    
    public class DinerMenu : IMenu
    {
        
        static readonly int MAX_ITEMS = 6;
        int numberOfItems = 0;
      
        MenuItem[] menuItems;

        // Method to add a MenuItem to the menu
        // It also checks if there is room in the array before adding a new item, 
        //without that check numberOfItems variable is not used and serves no purpose.
        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if (numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
            }
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }

        // Constructor for DinerMenu. It initializes the menuItems array and adds items to it.
        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];

            
            AddItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);
            AddItem("Hotdog", "A hot dog, with sauerkraut, relish, onions, topped with cheese", false, 3.05);
            AddItem("Steamed Veggies and Brown Rice", "Steamed vegetables over brown rice", true, 3.99);
            AddItem("Pasta","Spaghetti with Marinara Sauce, and a slice of sourdough bread", true, 3.89);
            
        }



        // CreateIterator method from IMenu interface, it returns an enumerator for the menuItems list.
        public IEnumerator<MenuItem> CreateIterator()
        {
            //explicit cast added to avoid errors with debugger
            return (IEnumerator<MenuItem>)menuItems.GetEnumerator();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8_Iterator
{
    public class MenuPrinter
    {
        // Static method to print menu items from a  IMenu instance.
        public static void PrintMenu(IMenu menu)
        {
            // CreateIterator is called from IMenu instance to get an enumerator to iterate over the list.
            IEnumerator<MenuItem> iterator = menu.CreateIterator();

            // Loops through the menu items in the list.
            while (iterator.MoveNext())
            {
                // Selects current item on the list
                MenuItem menuItem = iterator.Current;

                // Prints the details of the current item.
                Console.WriteLine($"{menuItem.Name}, {menuItem.Price} -- {menuItem.Description}");
            }
        }
    }
}

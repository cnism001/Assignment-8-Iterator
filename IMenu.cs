using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8_Iterator
{
    
    public interface IMenu
    {
        //IEnumerator iterater over contents of MenuItem collection
        IEnumerator<MenuItem> CreateIterator();
    }
    // Class for an individual items on any of menus.
    public class MenuItem
    {
        // Properties to hold the details of a menu item.
        public string Name { get; }
        public string Description { get; }
        public bool IsVegetarian { get; }
        public double Price { get; }

        // Constructor to initialize a new MenuItem.
       
        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            Name = name;
            Description = description;
            IsVegetarian = isVegetarian;
            Price = price;
        }
    }
}

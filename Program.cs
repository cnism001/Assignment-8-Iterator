using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8_Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instances of the PancakeHouseMenu and DinerMenu.
            var pancakeHouseMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();

            // Print the breakfast  PancakeHouseMenu menu.
            Console.WriteLine("MENU\n----\nBREAKFAST");
            MenuPrinter.PrintMenu(pancakeHouseMenu);

            // Print the lunch DinerMenu menu.
            Console.WriteLine("\nLUNCH");
            MenuPrinter.PrintMenu(dinerMenu);
        }
    }
}

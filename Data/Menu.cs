using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CowboyCafe.Data;
using CowboyCafe.Data.Entrees;
using CowboyCafe.Data.Sides;
using CowboyCafe.Data.Drinks;


namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// Forms a list contianing a single instances of each entree
        /// </summary>
        /// <returns>A list containing all entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entree = new List<IOrderItem>();
            entree.Add(new AngryChicken());
            entree.Add(new CowpokeChili());
            entree.Add(new DakotaDoubleBurger());
            entree.Add(new PecosPulledPork()); 
            entree.Add(new RustlersRibs());
            entree.Add(new TexasTripleBurger());
            entree.Add(new TrailBurger());
            return entree;
        }
        /// <summary>
        /// Forms a list contianing a single instances of each side
        /// </summary>
        /// <returns>A list containing all sides</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> side = new List<IOrderItem>();
            side.Add(new BakedBeans());
            side.Add(new ChiliCheeseFries());
            side.Add(new PanDeCampo());
            side.Add(new CornDodgers());
            return side;
        }
        /// <summary>
        /// Forms a list contianing a single instances of each drink
        /// </summary>
        /// <returns>A list containing all drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drink = new List<IOrderItem>();
            drink.Add(new CowboyCoffee());
            drink.Add(new JerkedSoda());
            drink.Add(new TexasTea());
            drink.Add(new Water());
            return drink;
        }
        /// <summary>
        /// A list containing single instances of all menu items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> CompleteMenu() 
        {
            List<IOrderItem> complete = new List<IOrderItem>();
            foreach(IOrderItem item in Menu.Entrees())
            {
                complete.Add(item);
            }
            foreach (IOrderItem item in Menu.Sides())
            {
                complete.Add(item);
            }
            foreach (IOrderItem item in Menu.Drinks())
            {
                complete.Add(item);
            }
            return complete;
        }
    }
}

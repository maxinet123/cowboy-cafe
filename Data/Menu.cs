/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class to keep track of the lists and filters
*/
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
            foreach(Size size in Enum.GetValues(typeof(Size)))
            {
                CornDodgers corn = new CornDodgers();
                corn.Size = size;
                side.Add(corn);
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                BakedBeans beans = new BakedBeans();
                beans.Size = size;
                side.Add(beans);
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                ChiliCheeseFries fries = new ChiliCheeseFries();
                fries.Size = size;
                side.Add(fries);
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                PanDeCampo pan = new PanDeCampo();
                pan.Size = size;
                side.Add(pan);
            }
            
            return side;
        }
        /// <summary>
        /// Forms a list contianing a single instances of each drink
        /// </summary>
        /// <returns>A list containing all drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drink = new List<IOrderItem>();
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                JerkedSoda soda = new JerkedSoda();
                soda.Size = size;
                drink.Add(soda);
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                CowboyCoffee coffee = new CowboyCoffee();
                coffee.Size = size;
                drink.Add(coffee);
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                TexasTea tea = new TexasTea();
                tea.Size = size;
                // if soda has sweet
                drink.Add(tea);
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                Water water = new Water();
                water.Size = size;
                drink.Add(water);
            }
            return drink;
        }
        /// <summary>
        /// A list containing single instances of all menu items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> All() 
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

        /// <summary>
        /// Searches the database for matching menu items
        /// </summary>
        /// <param name="terms">The terms to search for</param>
        /// <returns>A collection of menu items</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> all, string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            // Return all movies if there are no search terms
            if (terms == null) return all;
            // return each movie in the database containing the terms substring
            foreach (IOrderItem item in all)
            {
                if (item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }
        /// <summary>
        /// Gets the possible MPAARatings
        /// </summary>
        public static string[] Categories
        {
            get => new string[]
            {
            "Entrees",
            "Sides",
            "Drinks"
            };
        }

        /// <summary>
        /// Filters the provided collection of menu items
        /// </summary>
        /// <param name="menu">The collection of items to filter</param>
        /// <param name="category">The category to include</param>
        /// <returns>A collection containing only items that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByCategories(IEnumerable<IOrderItem> menu, IEnumerable<string> category)
        {
            // If no filter is specified, just return the provided collection
            if (category == null || category.Count() == 0) return All();
            // Filter the supplied collection of movies
            List<IOrderItem> results = new List<IOrderItem>();
            foreach(String str in category)
            {
                if (str.Equals("Entrees"))
                {
                    foreach(IOrderItem item in Entrees())
                    {
                        results.Add(item);
                    }
                }
                else if (str.Equals("Sides"))
                {
                    foreach (IOrderItem item in Sides())
                    {
                        results.Add(item);
                    }
                }
                else if (str.Equals("Drinks"))
                {
                    foreach (IOrderItem item in Drinks())
                    {
                        results.Add(item);
                    }
                }
            }
            return results;
        }


        /// <summary>
        /// Filters the provided collection of menu items 
        /// to those with Calories falling within 
        /// the specified range
        /// </summary>
        /// <param name="menu">The collection of menu items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered menu item collection</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> menu, double? min, double? max)
        {
            if (min == null && max == null) return menu;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem item in menu)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
        /// <summary>
        /// Filters the provided collection of menu items 
        /// to those with Prices falling within 
        /// the specified range
        /// </summary>
        /// <param name="menu">The collection of menu items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered menu items collection</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> menu, double? min, double? max)
        {
            if (min == null && max == null) return menu;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem item in menu)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}

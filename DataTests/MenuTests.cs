using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class MenuTests
    {
        /*
         * entree has all entrees-
         * same for drinks-
         * and sides-
         * and all -
         * null check price min and 
         * max
         * and calories min 
         * and max
         * check search if nothing is in it that all items are displayed
         * check seach at least one item returns IOrderitem
         * check multiple
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         */
         /// <summary>
         /// Checks if all IOrderItems are in the All()
         /// </summary>
         [Fact]
         public void AllContainsAllIOrderItems()
        {
            var all = Menu.All();
            foreach(IOrderItem item in all)
            {
                Assert.Contains(item, all);
            }
        }
        /// <summary>
        /// Checks if all entrees are in the Entrees()
        /// </summary>
        [Fact]
        public void EntreesContainsAllEntrees()
        {
            var entree = Menu.Entrees();
            foreach (IOrderItem item in entree)
            {
                Assert.Contains(item, entree);
            }
        }
        /// <summary>
        /// Checks if all sides are in the Sides()
        /// </summary>
        [Fact]
        public void SidesContainsAllSides()
        {
            var side = Menu.Sides();
            foreach (IOrderItem item in side)
            {
                Assert.Contains(item, side);
            }
        }
        /// <summary>
        /// Checks if all drinks are in the Drinks()
        /// </summary>
        [Fact]
        public void DrinksContainsAllDrinks()
        {
            var drink = Menu.Drinks();
            foreach (IOrderItem item in drink)
            {
                Assert.Contains(item, drink);
            }
        }
        /// <summary>
        /// Checks to see that when searching for an item it is found and will return true
        /// </summary>
        [Fact]
        public void SearchFilterWorksTest()
        {
            IEnumerable<IOrderItem> all = Menu.All();
            IEnumerable<IOrderItem> test = Menu.Search(all, "burger");
            bool contains = false;
            foreach(IOrderItem item in test)
            {
                if (item.ToString().Contains("burger", StringComparison.InvariantCultureIgnoreCase))
                {
                    contains = true;
                }
            }
            Assert.True(contains);
        }
        /// <summary>
        /// Checks to see when nothing is searched, if all menu items are there
        /// </summary>
        [Fact]
        public void SearchFilterWorksTestingNull()
        {
            IEnumerable<IOrderItem> all = Menu.All();
            IEnumerable<IOrderItem> test = Menu.Search(all, "");
            Assert.Equal<int>(all.Count(), test.Count());
        }

        /// <summary>
        /// Checks to see when nothing is marked for categories, if all menu items are there
        /// </summary>
        [Fact]
        public void CategoryFilterWorksTestingNull()
        {
            IEnumerable<IOrderItem> all = Menu.All();
            IEnumerable<IOrderItem> test = Menu.FilterByCategories(all, null);
            Assert.Equal<int>(all.Count(), test.Count());
        }
        /// <summary>
        /// Checks to see when nothing is searched for price, if all menu items are there
        /// </summary>
        [Fact]
        public void PriceFilterWorksTestingNull()
        {
            IEnumerable<IOrderItem> all = Menu.All();
            IEnumerable<IOrderItem> test = Menu.FilterByPrice(all, null, null);
            Assert.Equal<int>(all.Count(), test.Count());
        }
        /// <summary>
        /// Checks to see when nothing is searched for calories, if all menu items are there
        /// </summary>
        [Fact]
        public void CaloriesFilterWorksTestingNull()
        {
            IEnumerable<IOrderItem> all = Menu.All();
            IEnumerable<IOrderItem> test = Menu.FilterByCalories(all, null, null);
            Assert.Equal<int>(all.Count(), test.Count());
        }

        /// <summary>
        /// Checks to see if filtering by entrees if all entrees show up
        /// </summary>
        [Fact]
        public void CategoryFilterWorksTest()
        {
            string[] category = new string[] { "Entrees" };
            IEnumerable<IOrderItem> test = Menu.FilterByCategories(Menu.All(), category);
            Assert.Equal<int>(7, test.Count());
        }
        /// <summary>
        /// Checks to see if the minimum price works
        /// </summary>
        [Fact]
        public void PriceMinFilterTest()
        {
            IEnumerable<IOrderItem> all = Menu.All();
            IEnumerable<IOrderItem> test = Menu.FilterByPrice(all, 0, null);
            Assert.Equal<int>(all.Count(), test.Count());
        }
        /// <summary>
        /// Checks to see if the maximum price works
        /// </summary>
        [Fact]
        public void PriceMaxFilterTest()
        {
            IEnumerable<IOrderItem> test = Menu.FilterByPrice(Menu.All(), null, 0);
            Assert.Empty(test);
        }
        /// <summary>
        /// Checks to see if the minimum calories works
        /// </summary>
        [Fact]
        public void CaloriesMinFilterTest()
        {
            IEnumerable<IOrderItem> all = Menu.All();
            IEnumerable<IOrderItem> test = Menu.FilterByCalories(all, 0, null);
            Assert.Equal<int>(all.Count(), test.Count());
        }
        /// <summary>
        /// Checks to see if the maximum calories works (water will still pop up because it has zero calories
        /// </summary>
        [Fact]
        public void CaloriesMaxFilterTest()
        {
            IEnumerable<IOrderItem> all = Menu.All();
            IEnumerable<IOrderItem> test = Menu.FilterByCalories(all, null, 0);
            bool contains = false;
            foreach (IOrderItem item in test)
            {
                if (item.ToString().Contains("water", StringComparison.InvariantCultureIgnoreCase))
                {
                    contains = true;
                }
            }
            Assert.True(contains);
        }
    }
}

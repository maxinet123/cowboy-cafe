/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: Connects the Menu class from CowboyCafe.Data to the PageModel for Index
*/using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// The movies to display on the index page 
        /// </summary>
        public IEnumerable<IOrderItem> MenuItems { get; protected set; }
        /// <summary>
        /// The current search terms 
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; }
        
        /// <summary>
        /// The filtered MPAA Ratings
        /// </summary>
        [BindProperty]
        public string[] Categories { get; set; }

        /// <summary>
        /// Gets and sets the Calories minimium value
        /// </summary>
        [BindProperty]
        public double? CaloriesMin { get; set; }

        /// <summary>
        /// Gets and sets the Calories maxium value
        /// </summary>
        [BindProperty]
        public double? CaloriesMax { get; set; }

        /// <summary>
        /// Gets and sets the price minimium value
        /// </summary>
        [BindProperty]
        public double? PriceMin { get; set; }

        /// <summary>
        /// Gets and sets the price maxium value
        /// </summary>
        [BindProperty]
        public double? PriceMax { get; set; }

        /// <summary>
        /// Gets all the correct information with applied filters
        /// </summary>
        /// <param name="PriceMin">Minimum price value.</param>
        /// <param name="PriceMax">Maximum price value.</param>
        /// <param name="CaloriesMin">Minimum calories value.</param>
        /// <param name="CaloriesMax">Maximum calories value.</param>
        public void OnGet(double? PriceMin, double? PriceMax, double? CaloriesMin, double? CaloriesMax)
        {
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;
            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;
            MenuItems = Menu.All();
            SearchTerms = Request.Query["SearchTerms"];
            Categories = Request.Query["Categories"];
            MenuItems = Menu.FilterByCategories(MenuItems, Categories);
            MenuItems = Menu.FilterByPrice(MenuItems, this.PriceMin, this.PriceMax);
            MenuItems = Menu.FilterByCalories(MenuItems, this.CaloriesMin, this.CaloriesMax);
            MenuItems = Menu.Search(MenuItems, SearchTerms);
        }
    }
}

/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A base class for the drinks
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a drink
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }
        
        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }
        
        /// <summary>
        /// Gets the special instructions for the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
        
        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the bool for ice in the drink
        /// </summary>
        public virtual bool Ice { get; set; } = true;
    }

}


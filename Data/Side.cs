/*
* Author: Nathan Bean
* Class: CIS 400
* Purpose: A base class for the sides
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the size of the side
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Returns an empty list is there are no secial instrictions
        /// </summary>
        public List<string> SpecialInstructions => new List<string>();

        /// <summary>
        /// Property that is triggered when something has changed and updates everything
        /// </summary>
        public abstract event PropertyChangedEventHandler PropertyChanged;
    }
}

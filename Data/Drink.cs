/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A base class for the drinks
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a drink
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
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
        /// Gets the bool for ice in the drink
        /// </summary>
        public virtual bool Ice { get; set; } = true;

        /// <summary>
        /// Property that is triggered when something has changed and updates everything
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// private backing variable
        /// </summary>
        private Size size;

        /// <summary>
        /// Gets the size of the side
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// Notifies when the property is changed and updates
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }
    }

}


/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class representing the qualities for the Cowboy Coffee
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data.Drinks
{
    /// <summary>
    /// A class representing the Cowboy Coffee
    /// </summary>
    public class CowboyCoffee : Drink
    {
        private Size size = Size.Small;
        /// <summary>
        /// Gets the size for the Cowboy Coffee
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                NotifyOfPropertyChanged("Size");
            }
        }

        private bool cream = false;
        /// <summary>
        /// If the coffee needs room for cream
        /// </summary>
        public bool RoomForCream
        {
            get { return cream; }
            set 
            { 
                cream = value;
                NotifyOfPropertyChanged("RoomForCream");
                NotifyOfPropertyChanged("SpecialInstructions");

            }
        }

        private bool decaf = false;
        /// <summary>
        /// If the coffee is decaf.
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set 
            { 
                decaf = value;
                NotifyOfPropertyChanged("Decaf");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        private bool ice = false;
        /// <summary>
        /// If the coffee comes iced.
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set 
            { 
                ice = value;
                NotifyOfPropertyChanged("Ice");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Calories depending on size for coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Price depending on size for coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the special instructions for the Cowboy coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (ice) instructions.Add("add ice");
                if (cream) instructions.Add("room for cream");

                return instructions;
            }
        }

        /// <summary>
        /// Prints the string corresponding to the drink and size of the drink
        /// </summary>
        /// <returns>The string describing the Cowboy Coffee</returns>
        public override string ToString()
        {
            if (decaf)
            {
                return Size.ToString() + " Decaf Cowboy Coffee";
            }
            return Size.ToString() + " Cowboy Coffee";
        }

        /// <summary>
        /// Prints the name of the drink
        /// </summary>
        /// <returns>The string for the drink</returns>
        public override string ItemName()
        {
            return "Cowboy Coffee";
        }
    }
}

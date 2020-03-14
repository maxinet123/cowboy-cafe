/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class representing the qualities for the drink, Water
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{    
    /// <summary>
     /// A class representing the water drink
     /// </summary>
    public class Water : Drink
    {
        private Size size = Size.Small;
        /// <summary>
        /// Gets the size for the Water
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

        private bool ice = true;
        /// <summary>
        /// If the water comes with ice.
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set 
            { 
                ice = value;
                NotifyOfPropertyChanged("Ice");
            }
        }

        private bool lemon = false;
        /// <summary>
        /// If the water comes with ice.
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set 
            { 
                lemon = value;
                NotifyOfPropertyChanged("Lemon");            
            }
        }

        /// <summary>
        /// Calories depending on size for water
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0;
                    case Size.Medium:
                        return 0;
                    case Size.Large:
                        return 0;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Price depending on size for water
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.12;
                    case Size.Medium:
                        return 0.12;
                    case Size.Large:
                        return 0.12;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the special instructions for the water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!ice) instructions.Add("hold ice");
                if (lemon) instructions.Add("add lemon");

                return instructions;
            }
        }

        /// <summary>
        /// Prints the string corresponding to the drink and size of the drink
        /// </summary>
        /// <returns>The string describing the water</returns>
        public override string ToString()
        {
            return Size + " Water";
        }
    }
}

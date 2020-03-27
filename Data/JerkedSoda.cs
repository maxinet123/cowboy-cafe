/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class representing the qualities for the Jerked Soda
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Jerked Soda drink
    /// </summary>
    public class JerkedSoda : Drink
    {
        private Size size = Size.Small;
        /// <summary>
        /// Gets the size for the Jerked Soda
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

        private SodaFlavor flavor = SodaFlavor.BirchBeer;
        /// <summary>
        /// Gets the flavor of the soda
        /// </summary>
        public SodaFlavor Flavor 
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                NotifyOfPropertyChanged("Flavor");
            }
        }

        private bool ice = true;
        /// <summary>
        /// If the jerked soda comes with ice.
        /// </summary>
        public override bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
                NotifyOfPropertyChanged("Ice");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Calories depending on size for Jerked Soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Price depending on size for Jerked Soda
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the special instructions for the Jerked soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!ice) instructions.Add("hold ice");

                return instructions;
            }
        }
        /// <summary>
        /// Prints the string corresponding to the drink and size of the drink
        /// </summary>
        /// <returns>The string describing the water</returns>
        public override string ToString()
        {
            switch (Flavor)
            {
                case SodaFlavor.BirchBeer:
                    return Size.ToString() + " Birch Beer Jerked Soda";
                case SodaFlavor.CreamSoda:
                    return Size.ToString() + " Cream Soda Jerked Soda";
                case SodaFlavor.OrangeSoda:
                    return Size.ToString() + " Orange Soda Jerked Soda";
                case SodaFlavor.RootBeer:
                    return Size.ToString() + " Root Beer Jerked Soda";
                case SodaFlavor.Sarsparilla:
                    return Size.ToString() + " Sarsparilla Jerked Soda";
                default:
                    throw new NotImplementedException("No flavor found.");
            }
        }
    }
}

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
        public override event PropertyChangedEventHandler PropertyChanged;

        private Size size = Size.Small;
        public override Size Size 
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
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

        private bool ice = true;
        /// <summary>
        /// If the jerked soda comes with ice.
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Gets the special instructions for the Jerked soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!ice) instructions.Add("Hold Ice");

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
                    return Size + " Birch Beer Jerked Soda";
                case SodaFlavor.CreamSoda:
                    return Size + " Cream Soda Jerked Soda";
                case SodaFlavor.OrangeSoda:
                    return Size + " Orange Soda Jerked Soda";
                case SodaFlavor.RootBeer:
                    return Size + " Root Beer Jerked Soda";
                case SodaFlavor.Sarsparilla:
                    return Size + " Sarsparilla Jerked Soda";
                default:
                    throw new NotImplementedException();
            }
            /*switch (Size)
            {
                case Size.Small:
                    if (Flavor == SodaFlavor.BirchBeer)
                    {
                        return "Small Birch Beer Jerked Soda";
                    }
                    else if (Flavor == SodaFlavor.CreamSoda)
                    {
                        return "Small Cream Soda Jerked Soda";
                    }
                    else if (Flavor == SodaFlavor.OrangeSoda)
                    {
                        return "Small Orange Soda Jerked Soda";
                    }
                    else if (Flavor == SodaFlavor.RootBeer)
                    {
                        return "Small Root Beer Jerked Soda";
                    }
                    else
                    {
                        return "Small Sarsparilla Jerked Soda";
                    }
                case Size.Medium:
                    if (Flavor == SodaFlavor.BirchBeer)
                    {
                        return "Medium Birch Beer Jerked Soda";
                    }
                    else if (Flavor == SodaFlavor.CreamSoda)
                    {
                        return "Medium Cream Soda Jerked Soda";
                    }
                    else if (Flavor == SodaFlavor.OrangeSoda)
                    {
                        return "Medium Orange Soda Jerked Soda";
                    }
                    else if (Flavor == SodaFlavor.RootBeer)
                    {
                        return "Medium Root Beer Jerked Soda";
                    }
                    else
                    {
                        return "Medium Sarsparilla Jerked Soda";
                    }
                case Size.Large:
                    if (Flavor == SodaFlavor.BirchBeer)
                    {
                        return "Large Birch Beer Jerked Soda";
                    }
                    else if (Flavor == SodaFlavor.CreamSoda)
                    {
                        return "Large Cream Soda Jerked Soda";
                    }
                    else if (Flavor == SodaFlavor.OrangeSoda)
                    {
                        return "Large Orange Soda Jerked Soda";
                    }
                    else if (Flavor == SodaFlavor.RootBeer)
                    {
                        return "Large Root Beer Jerked Soda";
                    }
                    else
                    {
                        return "Large Sarsparilla Jerked Soda";
                    }
                default:
                    throw new NotImplementedException();
            }*/
        }
    }
}

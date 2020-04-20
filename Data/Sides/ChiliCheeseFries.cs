/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class representing the qualities for the Chili Cheese Fries
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data.Sides
{
    /// <summary>
    /// A class representing the Chili Cheese Fries side
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        private Size size = Size.Small;
        /// <summary>
        /// Gets the size for the Chili Cheese Fries
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

        /// <summary>
        /// Calories depending on size for Chili Cheese Fries
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 433;
                    case Size.Medium:
                        return 524;
                    case Size.Large:
                        return 610;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }

        }

        /// <summary>
        /// Price depending on size for Chili Cheese Fries
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Large:
                        return 3.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Prints the string corresponding to the side and size of the side
        /// </summary>
        /// <returns>The string describing the Chili Cheese Fries side</returns>
        public override string ToString()
        {
            return Size.ToString() + " Chili Cheese Fries";
        }
        /// <summary>
        /// Prints the name of the side
        /// </summary>
        /// <returns>The string for the side</returns>
        public override string ItemName()
        {
            return "Chili Cheese Fries";
        }
    }
}

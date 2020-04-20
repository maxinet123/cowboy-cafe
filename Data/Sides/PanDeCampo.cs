/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class representing the qualities for the Pan de Campo
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data.Sides
{
    /// <summary>
    /// A class representing the Pan de Campo side
    /// </summary>
    public class PanDeCampo : Side
    {
        private Size size = Size.Small;
        /// <summary>
        /// Gets the size for the Pan de Campo
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
        /// Calories depending on size for Pan De Campo
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 227;
                    case Size.Medium:
                        return 269;
                    case Size.Large:
                        return 367;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Price depending on size for Pan De Campo
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
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Prints the string corresponding to the side and size of the side
        /// </summary>
        /// <returns>The string describing the Pan de Campo side</returns>
        public override string ToString()
        {
            switch (Size)
            {
                default:
                case Size.Small:
                    return "Small Pan de Campo";
                case Size.Medium:
                    return "Medium Pan de Campo";
                case Size.Large:
                    return "Large Pan de Campo";
            }
        }

        /// <summary>
        /// Prints the name of the side
        /// </summary>
        /// <returns>The string for the side</returns>
        public override string ItemName()
        {
            return "Pan de Campo";
        }
    }
}

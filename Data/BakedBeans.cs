/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class representing the qualities for the Baked Beans
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Baked Beans side
    /// </summary>
    public class BakedBeans : Side
    {
        /// <summary>
        /// Calories depending on size for Baked Beans
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 312;
                    case Size.Medium:
                        return 378;
                    case Size.Large:
                        return 410;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Price depending on size for Baked Beans
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
        /// <returns>The string describing the Baked Beans side</returns>
        public override string ToString()
        {
            if (Size == Size.Small)
            {
                return "Small Baked Beans";
            }
            else if (Size == Size.Medium)
            {
                return "Medium Baked Beans";
            }
            else
            {
                return "Large Baked Beans";
            }
        }
    }
}

/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class representing the qualities for the Pan de Campo
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pan de Campo side
    /// </summary>
    public class PanDeCampo : Side
    {
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
            if (Size == Size.Small)
            {
                return "Small Pan de Campo";
            }
            else if (Size == Size.Medium)
            {
                return "Medium Pan de Campo";
            }
            else
            {
                return "Large Pan de Campo";
            }
        }
    }
}

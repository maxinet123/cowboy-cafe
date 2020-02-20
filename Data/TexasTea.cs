/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class representing the qualities for the Texas Tea
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A  class representing the qualities for the Texas tea
    /// </summary>
    public class TexasTea : Drink
    {
        private bool sweet = true;
        /// <summary>
        /// If the Texas Tea is sweet
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set { sweet = value; }
        }

        private bool lemon = false;
        /// <summary>
        /// If the Texas Tea comes with a lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

        private bool ice = true;
        /// <summary>
        /// If the Texas Tea comes with ice.
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Calories depending on size and sweetness for Texas Tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        if (!sweet)
                        {
                            return 5;
                        }
                        return 10;
                    case Size.Medium:
                        if (!sweet)
                        {
                            return 11;
                        }
                        return 22;
                    case Size.Large:
                        if (!sweet)
                        {
                            return 18;
                        }
                        return 36;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Price depending on size for Texas Tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the special instructions for the Texas Tea
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!ice) instructions.Add("Hold Ice");
                if (lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }
        /// <summary>
        /// Prints the string corresponding to the drink and size of the drink
        /// </summary>
        /// <returns>The string describing the Texas Tea</returns>
        public override string ToString()
        {
            if (Size == Size.Small)
            {
                return "Small Texas Tea";
            }
            else if (Size == Size.Medium)
            {
                return "Medium Texas Tea";
            }
            else
            {
                return "Large Texas Tea";
            }
        }
    }
}

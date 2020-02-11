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
        /// Calories depending on size for Texas Tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                //NEED TO FIGURE HALF OF AMOUNT FOR WITHOUT SWEETENER
                switch (Size)
                {
                    case Size.Small:
                        return 10;
                    case Size.Medium:
                        return 22;
                    case Size.Large:
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

                if (!ice) instructions.Add("hold ice");
                if (lemon) instructions.Add("add lemon");

                return instructions;
            }
        }
    }
}

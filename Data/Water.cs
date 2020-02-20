using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{    
    /// <summary>
     /// A class representing the water drink
     /// </summary>
    public class Water : Drink
    {
        private bool ice = true;
        /// <summary>
        /// If the water comes with ice.
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        private bool lemon = false;
        /// <summary>
        /// If the water comes with ice.
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
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

                if (!ice) instructions.Add("Hold Ice");
                if (lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }
        /// <summary>
        /// Prints the string corresponding to the drink and size of the drink
        /// </summary>
        /// <returns>The string describing the water</returns>
        public override string ToString()
        {
            if (Size == Size.Small)
            {
                return "Small Water";
            }
            else if (Size == Size.Medium)
            {
                return "Medium Water";
            }
            else
            {
                return "Large Water";
            }
        }
    }
}

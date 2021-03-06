﻿/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class representing the qualities for the Baked Beans
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data.Sides
{
    /// <summary>
    /// A class representing the Baked Beans side
    /// </summary>
    public class BakedBeans : Side
    {
        private Size size = Size.Small;
        /// <summary>
        /// Gets the size for the Baked Beans
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
            return this.Size + " Baked Beans";
        }
        /// <summary>
        /// Prints the name of the side
        /// </summary>
        /// <returns>The string for the side</returns>
        public override string ItemName()
        {
            return "Baked Beans";
        }
    }
}

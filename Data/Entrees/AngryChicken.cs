﻿/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class representing the qualities for the Angry Chicken
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


namespace CowboyCafe.Data.Entrees
{
    /// <summary>
    /// A class representing the Angry Chicken entree
    /// </summary>
    public class AngryChicken : Entree
    {
        private bool bread = true;
        /// <summary>
        /// If the chicken comes on bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set 
            { 
                bread = value;
                NotifyOfPropertyChanged("Bread");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        private bool pickle = true;
        /// <summary>
        /// If the chicken sandwich has pickles on it.
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set 
            { 
                pickle = value;
                NotifyOfPropertyChanged("Pickle");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// The price of the chicken sandwich
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The calories of the chicken sandwich
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chicken sandwich
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }

        /// <summary>
        /// Prints the string corresponding to the entree
        /// </summary>
        /// <returns>The string describing the Angry Chicken</returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}

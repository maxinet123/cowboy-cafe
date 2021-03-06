﻿/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class representing the qualities for the Trail Burger
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data.Entrees
{
    /// <summary>
    /// A class representing the Trail Burger entree
    /// </summary>
    public class TrailBurger : Entree
    {
        private bool bun = true;
        /// <summary>
        /// If the burger has a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set 
            { 
                bun = value;
                NotifyOfPropertyChanged("Bun");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        private bool cheese = true;
        /// <summary>
        /// If the burger is topped with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set 
            { 
                cheese = value;
                NotifyOfPropertyChanged("Cheese");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        private bool ketchup = true;
        /// <summary>
        /// If the burger is topped with ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set 
            { 
                ketchup = value;
                NotifyOfPropertyChanged("Ketchup");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        private bool mustard = true;
        /// <summary>
        /// If the burger is topped with mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set 
            { 
                mustard = value;
                NotifyOfPropertyChanged("Mustard");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        private bool pickle = true;
        /// <summary>
        /// If the burger has pickles on it
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
        /// The price of the burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }
        }

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 288;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bun) instructions.Add("hold bun");
                if (!cheese) instructions.Add("hold cheese");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }

        /// <summary>
        /// Prints the string corresponding to the entree
        /// </summary>
        /// <returns>The string describing the Trail Burger</returns>
        public override string ToString()
        {
            return "Trail Burger";
        }
    }
}

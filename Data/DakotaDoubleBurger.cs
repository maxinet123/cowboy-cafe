﻿/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class representing the qualities for the Dakota Double Burger
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Dakota Double Burger entree
    /// </summary>
    public class DakotaDoubleBurger : Entree
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
            }
        }

        private bool tomato = true;
        /// <summary>
        /// If the burger is topped with tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set 
            { 
                tomato = value;
                NotifyOfPropertyChanged("Tomato");
            }
        }

        private bool lettuce = true;
        /// <summary>
        /// If the burger is topped with lettuce
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set 
            { 
                lettuce = value;
                NotifyOfPropertyChanged("Lettuce");
            }
        }

        private bool mayo = true;
        /// <summary>
        /// If the burger is topped with mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set 
            { 
                mayo = value;
                NotifyOfPropertyChanged("Mayo");

            }
        }

        /// <summary>
        /// The price of the burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
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
                if (!tomato) instructions.Add("hold tomato");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!mayo) instructions.Add("hold mayo");

                return instructions;
            }
        }
        /// <summary>
        /// Prints the string corresponding to the entree
        /// </summary>
        /// <returns>The string describing the Dakota Double Burger</returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }
    }
}

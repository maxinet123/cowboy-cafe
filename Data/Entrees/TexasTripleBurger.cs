/*
* Author: Maxine Teixeira
* Class: CIS 400
* Purpose: A class representing the qualities for the Texas Triple Burger
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data.Entrees
{
    /// <summary>
    /// A class representing the Texas Triple Burger entree
    /// </summary>
    public class TexasTripleBurger : Entree
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
                NotifyOfPropertyChanged("SpecialInstructions");
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
                NotifyOfPropertyChanged("SpecialInstructions");
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
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        private bool bacon = true;
        /// <summary>
        /// If the burger is topped with bacon
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set
            {
                bacon = value;
                NotifyOfPropertyChanged("Bacon");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        private bool egg = true;
        /// <summary>
        /// If the burger is topped with egg
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set 
            {
                egg = value;
                NotifyOfPropertyChanged("Egg");
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
                return 6.45;
            }
        }

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 698;
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
                if (!bacon) instructions.Add("hold bacon");
                if (!egg) instructions.Add("hold egg");

                return instructions;
            }
        }

        /// <summary>
        /// Prints the string corresponding to the entree
        /// </summary>
        /// <returns>The string describing the Texas Triple Burger</returns>
        public override string ToString()
        {
            return "Texas Triple Burger";
        }
    }
}

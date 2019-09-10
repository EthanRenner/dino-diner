/* SteakosaurusBurger.cs
 * Author: Ethan Renner
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Implement a class to represent the Steakosaurus Burger entree. 
    /// Its price is $5.15, it contains 621 calories, and its ingredients are: whole wheat bun, steakburger pattie, pickle, ketchup, and mustard. 
    /// It should implement methods for holding the bun, pickle, ketchup, and mustard.
    /// </summary>
    public class SteakosaurusBurger
    {
        /// <summary>
        /// Whether the entree has the given ingredient.
        /// </summary>
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        /// <summary>
        /// Gives the price and the calories of this entree.
        /// </summary>
        public double Price { get; set; }
        public uint Calories { get; set; }

        /// <summary>
        /// Gives list of all the ingredients in this entree.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                if (bun) ingredients.Add("Whole Wheat Bun");
                ingredients.Add("Steakburger Pattie");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// Initialize price to 5.15 and calories to 621.
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Remove bun from this entree.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Remove pickle from this entree.
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Remove ketchup from this entree.
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Remove mustard from this entree.
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
}

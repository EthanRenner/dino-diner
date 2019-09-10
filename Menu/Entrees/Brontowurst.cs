/* Brontowurst.cs
 * Author: Ethan Renner
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Implement a class to represent the Brontowurst entree. 
    /// Its price is $5.36, it contains 498 calories, and its ingredients are: brautwurst, whole-wheat bun, peppers, and onions. 
    /// It should implement methods for holding the bun, peppers, and onions.
    /// </summary>
    public class Brontowurst
    {
        /// <summary>
        /// Whether the entree has the given ingredient.
        /// </summary>
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

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
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Initialize price to 5.36 and calories to 356.
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Remove bun from this entree.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Remove peppers from this entree.
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        /// <summary>
        /// Remove onions from this entree.
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}

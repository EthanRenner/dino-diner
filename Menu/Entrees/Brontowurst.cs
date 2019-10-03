/* Brontowurst.cs
 * Author: Ethan Renner
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Implement a class to represent the Brontowurst entree. 
    /// Its price is $5.36, it contains 498 calories, and its ingredients are: brautwurst, whole-wheat bun, peppers, and onions. 
    /// It should implement methods for holding the bun, peppers, and onions.
    /// </summary>
    public class Brontowurst: Entree
    {
        // Private variables
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;
        
        /// <summary>
        /// Gives list of all the ingredients in this entree.
        /// </summary>
        public override List<string> Ingredients
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

        /// <summary>
        /// Overrides to string to give accurate description of order.
        /// </summary>
        /// <returns>A string representation of this entree.</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}

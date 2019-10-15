/* SteakosaurusBurger.cs
 * Author: Ethan Renner
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Implement a class to represent the Steakosaurus Burger entree. 
    /// Its price is $5.15, it contains 621 calories, and its ingredients are: whole wheat bun, steakburger pattie, pickle, ketchup, and mustard. 
    /// It should implement methods for holding the bun, pickle, ketchup, and mustard.
    /// </summary>
    public class SteakosaurusBurger: Entree
    {
        // Private variables
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        
        /// <summary>
        /// Gives list of all the ingredients in this entree.
        /// </summary>
        public override List<string> Ingredients
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

        /// <summary>
        /// String description of this entree order.
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// String array of all specials added to this entree order.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                if (bun) specials.Add("+ Bun");
                else specials.Add("- Bun");
                if (pickle) specials.Add("+ Pickle");
                else specials.Add("- Pickle");
                if (ketchup) specials.Add("+ Ketchup");
                else specials.Add("- Ketchup");
                if (mustard) specials.Add("+ Mustard");
                else specials.Add("- Mustard");
                return specials.ToArray();
            }
        }

        /// <summary>
        /// Overrides to string to give accurate description of order.
        /// </summary>
        /// <returns>A string representation of this entree.</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}

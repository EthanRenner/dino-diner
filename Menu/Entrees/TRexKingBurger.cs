/* TRexKingBurger.cs
 * Author: Ethan Renner
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Implement a class to represent the T-Rex King Burger entree. 
    /// Its price is $8.45, it contains 728 calories, and its ingredients are: a whole wheat bun, three steakburger patties, lettuce, tomato, onion, pickle, ketchup, mustard, and mayo. 
    /// It should implement methods for holding the bun, lettuce, tomato, onion, pickle, ketchup, mustard, and mayo.
    /// </summary>
    public class TRexKingBurger: Entree
    {
        // Private variables
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool mayo = true;
        
        /// <summary>
        /// Gives list of all the ingredients in this entree.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < 3; i++) ingredients.Add("Steakburger Pattie");
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// Initialize price to 8.45 and calories to 728.
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
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
        /// Remove tomato from this entree.
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }

        /// <summary>
        /// Remove mayo from this entree.
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }

        /// <summary>
        /// Remove onion from this entree.
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }

        /// <summary>
        /// Remove lettuce from this entree.
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
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
                if (tomato) specials.Add("+ Tomato");
                else specials.Add("- Tomato");
                if (onion) specials.Add("+ Onion");
                else specials.Add("- Onion");
                if (mayo) specials.Add("+ Mayo");
                else specials.Add("- Mayo");
                if (lettuce) specials.Add("+ Lettuce");
                else specials.Add("- Lettuce");
                return specials.ToArray();
            }
        }

        /// <summary>
        /// Overrides to string to give accurate description of order.
        /// </summary>
        /// <returns>A string representation of this entree.</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}

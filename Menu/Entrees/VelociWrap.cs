/* VelociWrap.cs
 * Author: Ethan Renner
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Implement a class to represent the Veloci-Wrap entree. 
    /// Its price is $6.86, it contains 356 calories, and its ingredients are: a flour tortilla, chicken breast, romaine lettuce, Ceasar dressing, and parmesan cheese. 
    /// It should implement methods to hold the dressing, lettuce, and cheese.
    /// </summary>
    public class VelociWrap: Entree
    {
        // Private variables
        private bool dressing = true;
        private bool cheese = true;
        private bool lettuce = true;

        /// <summary>
        /// Gives the price of this entree.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Gives the calories of this entree.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gives list of all the ingredients in this entree.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                if (dressing) ingredients.Add("Ceasar Dressing");
                ingredients.Add("Flour Tortilla");
                ingredients.Add("Chicken Breast");
                if (cheese) ingredients.Add("Parmesan Cheese");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                return ingredients;
            }
        }

        /// <summary>
        /// Initialize price to 6.86 and calories to 356.
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Remove dressing from this entree.
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }

        /// <summary>
        /// Remove cheese from this entree.
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }

        /// <summary>
        /// Remove lettuce from this entree.
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }
    }
}

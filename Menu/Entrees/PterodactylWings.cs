/* PterodactylWings.cs
 * Author: Ethan Renner
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Implement a class to represent the Pterodactyl Wings entree. 
    /// Its price is $7.21, it contains 318 calories, and its ingredients are: Chicken and Wing Sauce.
    /// </summary>
    public class PterodactylWings
    {
        /// <summary>
        /// Gives the price and the calories of this entree.
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
                ingredients.Add("Chicken");
                ingredients.Add("Wing Sauce");
                return ingredients;
            }
        }

        /// <summary>
        /// Initialize price to 7.21 and calories to 318.
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

    }
}

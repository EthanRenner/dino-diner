/* PterodactylWings.cs
 * Author: Ethan Renner
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Implement a class to represent the Pterodactyl Wings entree. 
    /// Its price is $7.21, it contains 318 calories, and its ingredients are: Chicken and Wing Sauce.
    /// </summary>
    public class PterodactylWings: Entree
    {
        /// <summary>
        /// Gives list of all the ingredients in this entree.
        /// </summary>
        public override List<string> Ingredients
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
                return specials.ToArray();
            }
        }

        /// <summary>
        /// Overrides to string to give accurate description of order.
        /// </summary>
        /// <returns>A string representation of this entree.</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}

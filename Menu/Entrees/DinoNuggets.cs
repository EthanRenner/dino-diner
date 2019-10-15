/* DinoNuggets.cs
 * Author: Ethan Renner
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Implement a class to represent the Dino Nuggest entree. 
    /// Its price is $4.25, it contains 59 calories per nugget, and its ingredients are: 6 chicken nuggets. 
    /// It should implement methods for adding a nugget at an additional $0.25.
    /// </summary>
    public class DinoNuggets: Entree
    {
        //private variables
        private uint NumberOfNuggets;
        static uint CaloriesPerNugget = 59;
        static double PricePerExtraNugget = .25;
        
        /// <summary>
        /// Gives list of all the ingredients in this entree.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < NumberOfNuggets; i++) ingredients.Add("Chicken Nugget");
                return ingredients;
            }
        }

        /// <summary>
        /// Initialize price to 4.25, nuggets to 6, and calories to 6*59.
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.NumberOfNuggets = 6;
            this.Calories = NumberOfNuggets * CaloriesPerNugget;
        }

        /// <summary>
        /// Adds another chicken nugget to the order.
        /// </summary>
        public void AddNugget()
        {
            this.NumberOfNuggets++;
            this.Price += PricePerExtraNugget;
            this.Calories += CaloriesPerNugget;
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
                specials.Add($"{NumberOfNuggets} Nuggets");
                return specials.ToArray();
            }
        }

        /// <summary>
        /// Overrides to string to give accurate description of order.
        /// </summary>
        /// <returns>A string representation of this entree.</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}

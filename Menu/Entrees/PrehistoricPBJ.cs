using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Implement a class to represent the PrehistoricPBJ entree.
    /// </summary>
    public class PrehistoricPBJ
    {
        // Private variables
        private bool peanutButter = true;
        private bool jelly = true;

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
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Initialize price to 6.52 and calories to 483.
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Remove peanut butter from this entree.
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        /// <summary>
        /// Remove jelly from this entree.
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}

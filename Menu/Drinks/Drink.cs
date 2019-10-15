/* Drink.cs
 * Author: Ethan Renner
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The abstract base class representing a drink. 
    /// </summary>
    public abstract class Drink: IMenuItem, IOrderItem
    {
        // Private variables for size and ice
        protected Size size = Size.Small;
        private bool ice = true;

        /// <summary>
        /// Price of entree.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Amount of calories in the entree.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// List of ingredients in the entree.
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Property for the size of the drink.
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Property to get whether or not this drink has ice.
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Sets the private ice variable to false.
        /// </summary>
        public void HoldIce()
        {
            ice = false;
        }

        /// <summary>
        /// String description of the drink.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// String array of all specials added to drink.
        /// </summary>
        public abstract string[] Special { get; }
    }
}

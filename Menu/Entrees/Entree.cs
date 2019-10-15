using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The abstract base class representing a side. Requires price, calories, and ingredients.
    /// </summary>
    public abstract class Entree: IMenuItem, IOrderItem
    {
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
        /// String description of the entree.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// String array of all specials added to entree.
        /// </summary>
        public abstract string[] Special { get; }
    }
}

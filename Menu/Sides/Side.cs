﻿/* Side.cs
 * Author: Ethan Renner
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The abstract base class representing a side. Has price, calories, ingredients, and size.
    /// </summary>
    public abstract class Side: IMenuItem, IOrderItem
    {
        /// <summary>
        /// Price of side.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Amount of calories in the side.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// List of ingredients in the side.
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// String description of the side.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// String array of all specials added to side.
        /// </summary>
        public abstract string[] Special { get; }
    }
}

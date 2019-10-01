using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// The abstract base class representing a drink. 
    /// </summary>
    public abstract class Drink
    {
        // Private variables for size and ice
        protected Size size = Size.Small;
        private bool ice = true;

        /// <summary>
        /// Property for the price of a drink.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Property for the amount of calories in a drink.
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// Property to get the list of ingredients in a drink.
        /// </summary>
        public abstract List<String> Ingredients { get; }
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

        
    }
}

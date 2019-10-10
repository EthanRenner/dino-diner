/* Water.cs
 * Author: Ethan Renner
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class representation of the water drink.
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Constructor for a water drink, size defaults to small.
        /// </summary>
        public Water()
        {
            Size = Size.Small;
        }

        /// <summary>
        /// Property for the size of this drink. Updates price and calories when size changes.
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = .1;
                        Calories = 0;
                        break;
                    case Size.Medium:
                        Price = .1;
                        Calories = 0;
                        break;
                    case Size.Large:
                        Price = .1;
                        Calories = 0;
                        break;
                }
            }
        }

        /// <summary>
        /// Property to get the ingredients list for this drink.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        private bool lemon = false;
        /// <summary>
        /// Property of whether or not this order has a lemon.
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }
        /// <summary>
        /// Adds a lemon to this drink order.
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }

        /// <summary>
        /// Overrides to string to give accurate description of order.
        /// </summary>
        /// <returns>A string representation of this drink.</returns>
        public override string ToString()
        {
            return $"{size} Water";
        }
    }
}

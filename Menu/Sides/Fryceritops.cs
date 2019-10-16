/* Fryceritops.cs
 * Author: Ethan Renner
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents an order of fryceritops aka french fries.
    /// Inherits from the base Side.cs class
    /// </summary>
    public class Fryceritops : Side
    {
        // Private variables
        private Size size;

        /// <summary>
        /// The size of the side order.
        /// Updates the price and calories when size changes.
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = .99;
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Instantiates default small fryceritops order.
        /// </summary>
        public Fryceritops()
        {
            Size = Size.Small;
        }

        /// <summary>
        /// Gets the list of ingredients for this side.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegetable Oil");
                return ingredients;
            }
        }

        /// <summary>
        /// String description of this side order.
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// String array of all specials added to this side order.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> specials = new List<string>(base.specials);

                return specials.ToArray();
            }
        }

        /// <summary>
        /// Overrides to string to give accurate description of order.
        /// </summary>
        /// <returns>A string representation of this entree.</returns>
        public override string ToString()
        {
            return $"{size} Fryceritops";
        }
    }
}

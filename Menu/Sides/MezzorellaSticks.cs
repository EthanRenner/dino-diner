using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents an order of fryceritops aka tater tots.
    /// Inherits from the base Side.cs class
    /// </summary>
    public class MezzorellaSticks : Side
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
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;
                }
            }
        }

        /// <summary>
        /// Instantiates default small MezzorellaSticks order.
        /// </summary>
        public MezzorellaSticks()
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
                ingredients.Add("Breading");
                ingredients.Add("Cheese Product");
                ingredients.Add("Vegetable Oil");
                return ingredients;
            }
        }

        /// <summary>
        /// Overrides to string to give accurate description of order.
        /// </summary>
        /// <returns>A string representation of this entree.</returns>
        public override string ToString()
        {
            return $"{size} Mezzorella Sticks";
        }
    }
}

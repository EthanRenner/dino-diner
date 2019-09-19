using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Represents an order of Triceritots aka tater tots.
    /// Inherits from the base Side.cs class
    /// </summary>
    public class Triceritots : Side
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
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                }
            }
        }

        /// <summary>
        /// Instantiates default small triceritots order.
        /// </summary>
        public Triceritots()
        {
            Size = Size.Small;
        }

        /// <summary>
        /// Gets the list of ingredients for this side.
        /// </summary>
        public override List<String> Ingredients
        {
            get
            {
                List<String> ingredients = new List<string>();
                ingredients.Add("Potato");
                ingredients.Add("Vegetable Oil");
                ingredients.Add("Salt");
                return ingredients;
            }
        }
    }
}

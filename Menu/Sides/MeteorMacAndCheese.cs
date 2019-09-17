﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Represents an order of MeteorMacAndCheese aka mac n cheese.
    /// Inherits from the base Side.cs class
    /// </summary>
    public class MeteorMacAndCheese : Side
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
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                }
            }
        }

        /// <summary>
        /// Instantiates default small MeteorMacAndCheese order.
        /// </summary>
        public MeteorMacAndCheese()
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
                ingredients.Add("Macaroni Noodles");
                ingredients.Add("Pork Sausuage");
                ingredients.Add("Cheese Product");
                return ingredients;
            }
        }
    }
}

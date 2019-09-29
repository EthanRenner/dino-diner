﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class representation of the tyrannotea drink.
    /// </summary>
    public class Tyrannotea: Drink
    {
        /// <summary>
        /// Constructor for a tyrannotea drink, size defaults to small.
        /// </summary>
        public Tyrannotea()
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
                        Price = .99;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        break;
                }
                if (Sweet) Calories *= 2;
            }
        }

        /// <summary>
        /// Property to get the ingredients list for this drink.
        /// </summary>
        public override List<String> Ingredients
        {
            get
            {
                List<string> ingredients = new List<String>();
                ingredients.Add("Water");
                ingredients.Add("Tea");
                if (Sweet) ingredients.Add("Cane Sugar");
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        private bool sweet = false;
        /// <summary>
        /// Property for the sweetness of this order of tyrannotea.
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set
            {
                Sweet = value;
                Size = Size;
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
        public void AddLemon() {
            Lemon = true;
        }
    }
}

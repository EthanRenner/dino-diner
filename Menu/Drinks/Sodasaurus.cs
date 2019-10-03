using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class representation of Sodasaurus an old-fashioned soda drink.
    /// </summary>
    public class Sodasaurus: Drink
    {
        /// <summary>
        /// Property for the flavor of a sodasaurus drink.
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; }

        /// <summary>
        /// Constructor for a sodasuarus drink, size defaults to small.
        /// </summary>
        public Sodasaurus()
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
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
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
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        /// <summary>
        /// Overrides to string to give accurate description of order.
        /// </summary>
        /// <returns>A string representation of this drink.</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sodasaurus";
        }
    }
}

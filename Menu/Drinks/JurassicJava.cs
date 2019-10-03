using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class representation of the JurassicJava drink, coffee.
    /// </summary>
    public class JurassicJava: Drink
    {
        /// <summary>
        /// Constructor for a jurassicjava drink, size defaults to small.
        /// </summary>
        public JurassicJava()
        {
            Size = Size.Small;
            HoldIce();
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
                        Price = .59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = .99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
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
                ingredients.Add("Coffee");
                return ingredients;
            }
        }

        private bool roomForCream = false;
        /// <summary>
        /// Property for whether or not this coffee order has room for cream.
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }

        private bool decaf = false;
        /// <summary>
        /// Property for whether or not this coffee order is decaf.
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }

        /// <summary>
        /// Sets roomForCream to true.
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        /// <summary>
        /// Sets ice to true.
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }
    }
}

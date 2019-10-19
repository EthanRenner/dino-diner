/* Side.cs
 * Author: Ethan Renner
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The abstract base class representing a side. Has price, calories, ingredients, and size.
    /// </summary>
    public abstract class Side: IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        private double price;
        private uint calories;

        /// <summary>
        /// Price of side.
        /// </summary>
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                NotifyOfPropertyChanged("Price");
            }
        }

        /// <summary>
        /// Amount of calories in the side.
        /// </summary>
        public uint Calories
        {
            get
            {
                return calories;
            }
            set
            {
                calories = value;
                NotifyOfPropertyChanged("Calories");
            }
        }

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
        public string Description { get { return this.ToString(); } }

        /// <summary>
        /// String array of all specials added to side.
        /// </summary>
        public abstract string[] Special { get; }

        protected List<string> specials = new List<string>();

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyOfPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Adds the special to the specials list.
        /// </summary>
        /// <param name="special">Special to add to list.</param>
        public void AddSpecial(string special)
        {
            specials.Add(special);
            NotifyOfPropertyChanged("Special");
        }
    }
}

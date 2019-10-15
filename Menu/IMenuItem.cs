/* IMenuItem.cs
 * Author: Ethan Renner
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for a menu item. Requires price, calories, and ingredients list properties.
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Price of the menu item.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Amount of calories for the menu item.
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// List of ingredients for the menu item.
        /// </summary>
        List<string> Ingredients { get; }
    }
}

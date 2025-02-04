﻿/* IOrderItem.cs
 * Author: Ethan Renner
 */

using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for an order item. Requires price, description, and specials list properties.
    /// </summary>
    public interface IOrderItem: INotifyPropertyChanged
    {
        /// <summary>
        /// Price of the order item.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// String description of the order item.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// String array of all specials added to menu item.
        /// </summary>
        string[] Special { get; }
    }
}

/* Order.cs
 * Author: Ethan Renner
 */
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    public class Order
    {
        /// <summary>
        /// The items added to this order.
        /// </summary>
        public ObservableCollection<IOrderItem> Items
        {
            get;
            set;
        } = new ObservableCollection<IOrderItem>();

        /// <summary>
        /// The total price from the prices of all order items.
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double sum = 0;
                foreach (IOrderItem item in Items)
                {
                    sum += item.Price;
                }
                if (sum < 0) return 0;
                else return sum;
            }
        }

        /// <summary>
        /// The current sales tax rate with getter and protected setter.
        /// </summary>
        public double SalesTaxRate
        {
            get;
            protected set;
        }

        /// <summary>
        /// The cost added by sales tax. Product of sales tax rate and subtotal cost.
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }

        /// <summary>
        /// The total cost of the order. Sum of sales tax cost and subtotal cost.
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }
    }
}

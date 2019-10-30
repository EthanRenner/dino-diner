/* Order.cs
 * Author: Ethan Renner
 */
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    
    public class Order: INotifyPropertyChanged
    {
        private List<IOrderItem> items = new List<IOrderItem>();
        /// <summary>
        /// The items added to this order.
        /// </summary>
        public IOrderItem[] Items
        {
            get { return items.ToArray(); }
        }

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

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyOfPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public void NotifyItemChanged(object sender, PropertyChangedEventArgs e)
        {
            NotifyOfPropertyChanged("Items");
            NotifyOfPropertyChanged("TotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
            NotifyOfPropertyChanged("SubtotalCost");
        }

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += NotifyItemChanged;
            items.Add(item);
            NotifyItemChanged(this, null);
        }

        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            NotifyItemChanged(this, null);
            return removed;
        }
    }
}

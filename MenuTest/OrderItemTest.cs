/* OrderItemTest.cs
 * Author: Ethan Renner
 */
using DinoDiner.Menu;
using System.Collections.ObjectModel;
using Xunit;

namespace MenuTest
{
    public class OrderItemTest
    {
        [Fact]
        public void PriceAddition()
        {
            ObservableCollection<IOrderItem> oc = new ObservableCollection<IOrderItem>();
            OrderItem oi1 = new OrderItem();
            oi1.Price = 10.0;
            oc.Add(oi1);

            OrderItem oi2 = new OrderItem();
            oi2.Price = 9.70;
            oc.Add(oi2);

            Order order = new Order();
            order.Items = oc;

            Assert.Equal<double>(19.70, order.SubtotalCost);
            Assert.Equal<double>(19.70*order.SalesTaxRate, order.SalesTaxCost);
            Assert.Equal<double>(19.70*(order.SalesTaxRate + 1), order.TotalCost);
        }

        [Fact]
        public void PriceSubtraction()
        {
            ObservableCollection<IOrderItem> oc = new ObservableCollection<IOrderItem>();
            OrderItem oi1 = new OrderItem();
            oi1.Price = -10.0;
            oc.Add(oi1);

            OrderItem oi2 = new OrderItem();
            oi2.Price = 9.70;
            oc.Add(oi2);

            Order order = new Order();
            order.Items = oc;

            Assert.Equal<double>(0, order.SubtotalCost);
            Assert.Equal<double>(0, order.SalesTaxCost);
            Assert.Equal<double>(0, order.TotalCost);
        }
        internal class OrderItem : IOrderItem
        {
            public double Price { get; set; }

            public string Description { get; set; }

            public string[] Special { get; set; }
        }
    }
}

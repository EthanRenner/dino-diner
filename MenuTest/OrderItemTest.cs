/* OrderItemTest.cs
 * Author: Ethan Renner
 */
using System.ComponentModel;
using DinoDiner.Menu;
using Xunit;

namespace DinoDiner.MenuTest
{
    public class OrderItemTest
    {
        [Fact]
        public void PriceAddition()
        {
            Order order = new Order();
            OrderItem oi1 = new OrderItem();
            oi1.Price = 10.0;
            order.Add(oi1);
            

            OrderItem oi2 = new OrderItem();
            oi2.Price = 9.70;
            order.Add(oi2);


            Assert.Equal<double>(19.70, order.SubtotalCost);
            Assert.Equal<double>(19.70*order.SalesTaxRate, order.SalesTaxCost);
            Assert.Equal<double>(19.70*(order.SalesTaxRate + 1), order.TotalCost);
        }

        [Fact]
        public void PriceSubtraction()
        {
            Order order = new Order();
            OrderItem oi1 = new OrderItem();
            oi1.Price = 20.0;
            order.Add(oi1);

            OrderItem oi2 = new OrderItem();
            oi2.Price = -.30;
            order.Add(oi2);

            Assert.Equal<double>(19.70, order.SubtotalCost);
            Assert.Equal<double>(19.70 * order.SalesTaxRate, order.SalesTaxCost);
            Assert.Equal<double>(19.70 * (order.SalesTaxRate + 1), order.TotalCost);
        }
        [Fact]
        public void PriceSubtractionNegative()
        {
            Order order = new Order();
            OrderItem oi1 = new OrderItem();
            oi1.Price = -10.0;
            order.Add(oi1);

            OrderItem oi2 = new OrderItem();
            oi2.Price = 9.70;
            order.Add(oi2);

            Assert.Equal<double>(0, order.SubtotalCost);
            Assert.Equal<double>(0, order.SalesTaxCost);
            Assert.Equal<double>(0, order.TotalCost);
        }
        internal class OrderItem : IOrderItem
        {
            public double Price { get; set; }

            public string Description { get; set; }

            public string[] Special { get; set; }

            public event PropertyChangedEventHandler PropertyChanged;

        }
    }
}

using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace DinoDiner.MenuTest.Entrees
{
    public class BrontowurstUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Brautwurst", ingredients);
            Assert.Contains<string>("Peppers", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain<string>("Peppers", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.DoesNotContain<string>("Onion", bw.Ingredients);
        }

        [Fact]
        public void BrontowurstDescriptionTest()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal("Brontowurst", bw.Description);
        }

        [Fact]
        public void BrontowurstSpecialsTest()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Empty(bw.Special);

            bw.HoldBun();
            Assert.Contains("Hold Bun", bw.Special);

            bw.HoldPeppers();
            Assert.Contains("Hold Peppers", bw.Special);

            bw.HoldOnion();
            Assert.Contains("Hold Onion", bw.Special);
        }

        [Fact]
        public void BrontowurstNotifyPropertyChanged()
        {
            Brontowurst brontowurst = new Brontowurst();

            Assert.PropertyChanged(brontowurst, "Price", () =>
            {
                brontowurst.Price = 10;
            });
            Assert.PropertyChanged(brontowurst, "Calories", () =>
            {
                brontowurst.Calories = 10;
            });

            System.Action[] actions = {
                () => { brontowurst.HoldBun(); },
                () => { brontowurst.HoldPeppers(); },
                () => { brontowurst.HoldOnion(); },
            };
            string[] properties = { "Special", "Ingredients" };

            foreach (System.Action action in actions)
            {
                foreach (string property in properties)
                    Assert.PropertyChanged(brontowurst, property, action);
            }
        }
    }
}

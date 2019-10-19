using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace DinoDiner.MenuTest.Entrees
{
    public class TRexKingBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(8.45, trex.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal<uint>(728, trex.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger trex = new TRexKingBurger();
            List<string> ingredients = trex.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Steakburger Pattie")) count++;
            }
            Assert.Equal<int>(3, count);
            Assert.Contains<string>("Lettuce", ingredients);
            Assert.Contains<string>("Tomato", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Contains<string>("Mayo", ingredients);
            Assert.Equal<int>(11, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", trex.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain<string>("Onion", trex.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", trex.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", trex.Ingredients);
        }

        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.DoesNotContain<string>("Mayo", trex.Ingredients);
        }

        [Fact]
        public void TRexKingBurgerDescriptionTest()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal("T-Rex King Burger", trex.Description);
        }

        [Fact]
        public void TRexKingBurgerSpecialsTest()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Empty(trex.Special);

            trex.HoldBun();
            Assert.Contains("Hold Bun", trex.Special);

            trex.HoldPickle();
            Assert.Contains("Hold Pickle", trex.Special);

            trex.HoldKetchup();
            Assert.Contains("Hold Ketchup", trex.Special);

            trex.HoldMustard();
            Assert.Contains("Hold Mustard", trex.Special);

            trex.HoldTomato();
            Assert.Contains("Hold Tomato", trex.Special);

            trex.HoldOnion();
            Assert.Contains("Hold Onion", trex.Special);

            trex.HoldMayo();
            Assert.Contains("Hold Mayo", trex.Special);

            trex.HoldLettuce();
            Assert.Contains("Hold Lettuce", trex.Special);
        }

        [Fact]
        public void TRexKingBugerNotifyPropertyChanged()
        {
            TRexKingBurger trex = new TRexKingBurger();

            Assert.PropertyChanged(trex, "Price", () =>
            {
                trex.Price = 10;
            });
            Assert.PropertyChanged(trex, "Calories", () =>
            {
                trex.Calories = 10;
            });

            System.Action[] actions = {
                () => { trex.HoldBun(); },
                () => { trex.HoldPickle(); },
                () => { trex.HoldKetchup(); },
                () => { trex.HoldMustard(); },
                () => { trex.HoldLettuce(); },
                () => { trex.HoldTomato(); },
                () => { trex.HoldOnion(); },
                () => { trex.HoldMayo(); }
            };
            string[] properties = { "Special", "Ingredients" };

            foreach (System.Action action in actions)
            {
                foreach (string property in properties)
                    Assert.PropertyChanged(trex, property, action);
            }
        }
    }
}

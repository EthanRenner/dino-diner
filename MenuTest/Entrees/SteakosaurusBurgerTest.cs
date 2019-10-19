using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace DinoDiner.MenuTest.Entrees
{
    public class SteakosaurusBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal(5.15, sb.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal<uint>(621, sb.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            List<string> ingredients = sb.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Steakburger Pattie", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", sb.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", sb.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", sb.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", sb.Ingredients);
        }

        [Fact]
        public void SteakosaurusBurgerDescriptionTest()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal("Steakosaurus Burger", sb.Description);
        }
        [Fact]
        public void SteakosaurusBurgerSpecialsTest()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Empty(sb.Special);

            sb.HoldBun();
            Assert.Contains("Hold Bun", sb.Special);

            sb.HoldPickle();
            Assert.Contains("Hold Pickle", sb.Special);

            sb.HoldKetchup();
            Assert.Contains("Hold Ketchup", sb.Special);

            sb.HoldMustard();
            Assert.Contains("Hold Mustard", sb.Special);
        }

        [Fact]
        public void SteakosaurusBugerNotifyPropertyChanged()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();

            Assert.PropertyChanged(sb, "Price", () =>
            {
                sb.Price = 10;
            });
            Assert.PropertyChanged(sb, "Calories", () =>
            {
                sb.Calories = 10;
            });

            System.Action[] actions = {
                () => { sb.HoldBun(); },
                () => { sb.HoldPickle(); },
                () => { sb.HoldKetchup(); },
                () => { sb.HoldMustard(); },
            };
            string[] properties = { "Special", "Ingredients" };

            foreach (System.Action action in actions)
            {
                foreach (string property in properties)
                    Assert.PropertyChanged(sb, property, action);
            }
        }
    }
}

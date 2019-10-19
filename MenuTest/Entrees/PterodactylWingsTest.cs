using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace DinoDiner.MenuTest.Entrees
{
    public class PterodactylWingsUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Equal(7.21, pw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Equal<uint>(318, pw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            PterodactylWings pw = new PterodactylWings();
            List<string> ingredients = pw.Ingredients;
            Assert.Contains<string>("Chicken", ingredients);
            Assert.Contains<string>("Wing Sauce", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }

        [Fact]
        public void PterodactylWingsDescriptionTest()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Equal("Pterodactyl Wings", pw.Description);
        }

        [Fact]
        public void PterodactylWingsSpecialsTest()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Empty(pw.Special);
        }

        [Fact]
        public void PterodactylWingsNotifyPropertyChanged()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.PropertyChanged(pw, "Price", () =>
            {
                pw.Price = 10;
            });
            Assert.PropertyChanged(pw, "Calories", () =>
            {
                pw.Calories = 10;
            });
        }
    }
}

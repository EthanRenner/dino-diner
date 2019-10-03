using Xunit;
using DinoDiner.Menu;
using System.Collections.Generic;

namespace DinoDiner.MenuTest.Drinks
{
    public class SodasaurusTest
    {
        [Fact]
        public void CorrectAbilityToSetEachFlavor()
        {
            Sodasaurus s = new Sodasaurus();
            List<SodasaurusFlavor> listOfFlavors = new List<SodasaurusFlavor>{ SodasaurusFlavor.Cherry, SodasaurusFlavor.Chocolate, SodasaurusFlavor.Cola, SodasaurusFlavor.Lime, SodasaurusFlavor.Orange, SodasaurusFlavor.RootBeer, SodasaurusFlavor.Vanilla };
            foreach (SodasaurusFlavor f in listOfFlavors)
            {
                s.Flavor = f;
                Assert.Equal<SodasaurusFlavor>(f, s.Flavor);
            }
        }

        [Fact]
        public void CorrectDefaultPriceCaloriesIceSize()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Equal<double>(1.50, s.Price);
            Assert.Equal<uint>(112, s.Calories);
            Assert.True(s.Ice);
            Assert.Equal<Size>(Size.Small, s.Size);
        }

        [Fact]
        public void CorrectPriceCaloriesAfterSizeChanges()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Large;
            Assert.Equal<double>(2.50, s.Price);
            Assert.Equal<uint>(208, s.Calories);
            s.Size = Size.Medium;
            Assert.Equal<double>(2.00, s.Price);
            Assert.Equal<uint>(156, s.Calories);
            s.Size = Size.Small;
            Assert.Equal<double>(1.50, s.Price);
            Assert.Equal<uint>(112, s.Calories);
        }

        [Fact]
        public void CorrectHoldIce()
        {
            Sodasaurus s = new Sodasaurus();
            s.HoldIce();
            Assert.False(s.Ice);
        }

        [Fact]
        public void CorrectIngredients()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Contains("Water", s.Ingredients);
            Assert.Contains("Natural Flavors", s.Ingredients);
            Assert.Contains("Cane Sugar", s.Ingredients);
        }
    }
}

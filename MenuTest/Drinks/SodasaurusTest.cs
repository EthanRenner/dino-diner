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

        [Theory]
        [InlineData(Size.Small, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Small, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Small, SodasaurusFlavor.Cola)]
        [InlineData(Size.Small, SodasaurusFlavor.Lime)]
        [InlineData(Size.Small, SodasaurusFlavor.Orange)]
        [InlineData(Size.Small, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Small, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Medium, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cola)]
        [InlineData(Size.Medium, SodasaurusFlavor.Lime)]
        [InlineData(Size.Medium, SodasaurusFlavor.Orange)]
        [InlineData(Size.Medium, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Medium, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Large, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Large, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Large, SodasaurusFlavor.Cola)]
        [InlineData(Size.Large, SodasaurusFlavor.Lime)]
        [InlineData(Size.Large, SodasaurusFlavor.Orange)]
        [InlineData(Size.Large, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Large, SodasaurusFlavor.Vanilla)]
        public void SodasaurusDescriptionTest(Size size, SodasaurusFlavor flavor)
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = size;
            soda.Flavor = flavor;
            Assert.Equal($"{size} {flavor} Sodasaurus", soda.Description);
        }

        [Fact]
        public void SodaSaurusSpecialsTest()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Empty(soda.Special);

            soda.HoldIce();
            Assert.Contains("Hold Ice", soda.Special);
        }
        [Fact]
        public void SodasaurusNotifyPropertyChanged()
        {
            Sodasaurus s = new Sodasaurus();

            string[] sizeProperties = { "Size", "Price", "Calories", "Description" };
            foreach (string property in sizeProperties)
                Assert.PropertyChanged(s, property, () =>
                {
                    s.Size = Size.Large;
                });

            string[] flavorProperties = { "Flavor", "Description" };
            foreach (string property in flavorProperties)
                Assert.PropertyChanged(s, property, () =>
                {
                    s.Flavor = SodasaurusFlavor.Chocolate;
                });

            string[] iceProperties = { "Ice", "Special" };
            foreach (string property in iceProperties)
                Assert.PropertyChanged(s, property, () =>
                {
                    s.HoldIce();
                });
        }
    }
}

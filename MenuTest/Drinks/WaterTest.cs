using Xunit;
using DinoDiner.Menu;
using System.Collections.Generic;

namespace DinoDiner.MenuTest.Drinks
{
    public class WaterTest
    {

        [Fact]
        public void CorrectDefaultState()
        {
            Water s = new Water();
            Assert.Equal<double>(.1, s.Price);
            Assert.Equal<uint>(0, s.Calories);
            Assert.True(s.Ice);
            Assert.Equal<Size>(Size.Small, s.Size);
            Assert.False(s.Lemon);
        }

        [Fact]
        public void CorrectPriceCaloriesAfterSizeChanges()
        {
            Water s = new Water();
            s.Size = Size.Large;
            Assert.Equal<double>(.1, s.Price);
            Assert.Equal<uint>(0, s.Calories);
            s.Size = Size.Medium;
            Assert.Equal<double>(.1, s.Price);
            Assert.Equal<uint>(0, s.Calories);
            s.Size = Size.Small;
            Assert.Equal<double>(.1, s.Price);
            Assert.Equal<uint>(0, s.Calories);
        }

        [Fact]
        public void CorrectHoldIce()
        {
            Water s = new Water();
            s.HoldIce();
            Assert.False(s.Ice);
        }

        [Fact]
        public void CorrectAddLemon()
        {
            Water s = new Water();
            s.AddLemon();
            Assert.True(s.Lemon);
        }

        [Fact]
        public void CorrectIngredients()
        {
            Water s = new Water();
            Assert.Contains("Water", s.Ingredients);
            Assert.DoesNotContain("Lemon", s.Ingredients);
            s.Lemon = true;
            Assert.Contains("Lemon", s.Ingredients);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void WaterDescriptionTest(Size size)
        {
            Water water = new Water();
            water.Size = size;
            Assert.Equal($"{size} Water", water.Description);
        }

        [Fact]
        public void WaterSpecialsTest()
        {
            Water water = new Water();
            Assert.Empty(water.Special);

            water.AddLemon();
            Assert.Contains("Add Lemon", water.Special);

            water.HoldIce();
            Assert.Contains("Hold Ice", water.Special);
        }

        [Fact]
        public void WaterNotifyPropertyChanged()
        {
            Water w = new Water();
            string[] sizeProperties = { "Size", "Price", "Calories", "Description" };
            foreach (string property in sizeProperties)
                Assert.PropertyChanged(w, property, () =>
                {
                    w.Size = Size.Large;
                });

            string[] lemonProperties = { "Lemon", "Special", "Ingredients" };
            foreach (string property in lemonProperties)
                Assert.PropertyChanged(w, property, () =>
                {
                    w.AddLemon();
                });

            string[] iceProperties = { "Ice", "Special" };
            foreach (string property in iceProperties)
                Assert.PropertyChanged(w, property, () =>
                {
                    w.HoldIce();
                });
        }
    }
}

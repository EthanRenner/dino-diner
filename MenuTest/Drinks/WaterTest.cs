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
    }
}

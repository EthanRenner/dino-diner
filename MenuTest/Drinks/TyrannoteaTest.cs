using Xunit;
using DinoDiner.Menu.Drinks;
using System.Collections.Generic;

namespace DinoDiner.MenuTest.Drinks
{
    public class TyrannoteaTest
    {

        [Fact]
        public void CorrectDefaultState()
        {
            Tyrannotea s = new Tyrannotea();
            Assert.Equal<double>(.99, s.Price);
            Assert.Equal<uint>(8, s.Calories);
            Assert.True(s.Ice);
            Assert.Equal<Size>(Size.Small, s.Size);
            Assert.False(s.Lemon);
            Assert.False(s.Sweet);
        }

        [Fact]
        public void CorrectPriceCaloriesAfterSizeChanges()
        {
            Tyrannotea s = new Tyrannotea();
            s.Size = Size.Large;
            Assert.Equal<double>(1.99, s.Price);
            Assert.Equal<uint>(32, s.Calories);
            s.Size = Size.Medium;
            Assert.Equal<double>(1.49, s.Price);
            Assert.Equal<uint>(16, s.Calories);
            s.Size = Size.Small;
            Assert.Equal<double>(.99, s.Price);
            Assert.Equal<uint>(8, s.Calories);
        }


        [Fact]
        public void CorrectPriceCaloriesAfterSizeChangesWithSweetness()
        {
            Tyrannotea s = new Tyrannotea();
            s.Sweet = true;
            s.Size = Size.Large;
            Assert.Equal<double>(1.99, s.Price);
            Assert.Equal<uint>(64, s.Calories);
            s.Size = Size.Medium;
            Assert.Equal<double>(1.49, s.Price);
            Assert.Equal<uint>(32, s.Calories);
            s.Size = Size.Small;
            Assert.Equal<double>(.99, s.Price);
            Assert.Equal<uint>(16, s.Calories);
        }

        [Fact]
        public void CorrectPriceCaloriesAfterSizeChangesWithoutSweetness()
        {
            Tyrannotea s = new Tyrannotea();
            s.Sweet = true;
            s.Sweet = false;
            s.Size = Size.Large;
            Assert.Equal<double>(1.99, s.Price);
            Assert.Equal<uint>(32, s.Calories);
            s.Size = Size.Medium;
            Assert.Equal<double>(1.49, s.Price);
            Assert.Equal<uint>(64, s.Calories);
            s.Size = Size.Small;
            Assert.Equal<double>(.99, s.Price);
            Assert.Equal<uint>(8, s.Calories);
        }

        [Fact]
        public void CorrectHoldIce()
        {
            Tyrannotea s = new Tyrannotea();
            s.HoldIce();
            Assert.False(s.Ice);
        }

        [Fact]
        public void CorrectAddLemon()
        {
            Tyrannotea s = new Tyrannotea();
            s.AddLemon();
            Assert.True(s.Lemon);
        }

        [Fact]
        public void CorrectIngredients()
        {
            Tyrannotea s = new Tyrannotea();
            Assert.Contains("Water", s.Ingredients);
            Assert.Contains("Tea", s.Ingredients);
            Assert.DoesNotContain("Cane Sugar", s.Ingredients);
            Assert.DoesNotContain("Lemon", s.Ingredients);
            s.Sweet = true;
            Assert.Contains("Cane Sugar", s.Ingredients);
            s.Lemon = true;
            Assert.Contains("Lemon", s.Ingredients);
        }
    }
}

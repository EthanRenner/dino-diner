using Xunit;
using DinoDiner.Menu;
using System.Collections.Generic;

namespace DinoDiner.MenuTest.Drinks
{
    public class JurassicJavaTest
    {

        [Fact]
        public void CorrectDefaultState()
        {
            JurassicJava s = new JurassicJava();
            Assert.Equal<double>(.59, s.Price);
            Assert.Equal<uint>(2, s.Calories);
            Assert.Equal<Size>(Size.Small, s.Size);
            Assert.False(s.RoomForCream);
            Assert.False(s.Ice);
        }

        [Fact]
        public void CorrectPriceCaloriesAfterSizeChanges()
        {
            JurassicJava s = new JurassicJava();
            s.Size = Size.Large;
            Assert.Equal<double>(1.49, s.Price);
            Assert.Equal<uint>(8, s.Calories);
            s.Size = Size.Medium;
            Assert.Equal<double>(.99, s.Price);
            Assert.Equal<uint>(4, s.Calories);
            s.Size = Size.Small;
            Assert.Equal<double>(.59, s.Price);
            Assert.Equal<uint>(2, s.Calories);
        }

        [Fact]
        public void CorrectAddIce()
        {
            JurassicJava s = new JurassicJava();
            s.AddIce();
            Assert.True(s.Ice);
        }

        [Fact]
        public void CorrectLeaveSpaceForCream()
        {
            JurassicJava s = new JurassicJava();
            s.LeaveRoomForCream();
            Assert.True(s.RoomForCream);
        }

        [Fact]
        public void CorrectIngredients()
        {
            JurassicJava s = new JurassicJava();
            Assert.Contains("Water", s.Ingredients);
            Assert.Contains("Coffee", s.Ingredients);
        }
    }
}

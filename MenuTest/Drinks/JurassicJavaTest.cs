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

        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void JurrasicJavaDescriptionTest(Size size, bool decaf)
        {
            JurassicJava java = new JurassicJava();
            java.Size = size;
            java.Decaf = decaf;
            if (decaf) Assert.Equal($"{size} Decaf Jurassic Java", java.Description);
            else Assert.Equal($"{size} Jurassic Java", java.Description);
        }

        [Fact]
        public void JurrasicJavaSpecialsTest()
        {
            JurassicJava java = new JurassicJava();
            Assert.Empty(java.Special);

            java.LeaveRoomForCream();
            Assert.Contains("Leave Room For Cream", java.Special);

            java.AddIce();
            Assert.Contains("Add Ice", java.Special);
        }

        [Fact]
        public void JurassicJavaNotifyPropertyChanged()
        {
            JurassicJava jj = new JurassicJava();
            string[] sizeProperties = { "Size", "Price", "Calories", "Description" };
            foreach (string property in sizeProperties)
                Assert.PropertyChanged(jj, property, () =>
                {
                    jj.Size = Size.Large;
                });

            string[] roomForCreamProperties = { "RoomForCream", "Special" };
            foreach (string property in roomForCreamProperties)
                Assert.PropertyChanged(jj, property, () =>
                {
                    jj.RoomForCream = true;
                });

            string[] decafProperties = { "Decaf", "Description" };
            foreach (string property in decafProperties)
                Assert.PropertyChanged(jj, property, () =>
                {
                    jj.Decaf = true;
                });

            string[] iceProperties = { "Ice", "Special" };
            foreach (string property in iceProperties)
                Assert.PropertyChanged(jj, property, () =>
                {
                    jj.AddIce();
                });
        }
    }
}

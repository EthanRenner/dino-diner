using Xunit;
using DinoDiner.Menu;
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
        public void CorrectSizeChanges()
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
        public void CorrectWithSweetness()
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
        public void CorrectWithoutSweetness()
        {
            Assert.True(true);

            Tyrannotea s = new Tyrannotea();
            s.Sweet = true;
            s.Sweet = false;
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
            List<string> temp = s.Ingredients;
            Assert.Contains("Water", temp);
            Assert.Contains("Tea", temp);
            Assert.DoesNotContain("Cane Sugar", temp);
            Assert.DoesNotContain("Lemon", temp);
            s.Sweet = true;
            s.AddLemon();
            temp.Clear();
            temp = s.Ingredients;
            Assert.Contains("Cane Sugar", temp);
            Assert.Contains("Lemon", temp);
        }

        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void TyrannoTeaDescriptionTest(Size size, bool sweet)
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = size;
            tea.Sweet = sweet;
            if (sweet) Assert.Equal($"{size} Sweet Tyrannotea", tea.Description);
            else Assert.Equal($"{size} Tyrannotea", tea.Description);
        }

        [Fact]
        public void TyrannoTeaSpecialsTest()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Empty(tea.Special);

            tea.AddLemon();
            Assert.Contains("Add Lemon", tea.Special);

            tea.HoldIce();
            Assert.Contains("Hold Ice", tea.Special);
        }

        [Fact]
        public void TyrannoteaNotifyPropertyChanged()
        {
            Tyrannotea t = new Tyrannotea();
            string[] sizeProperties = { "Size", "Price", "Calories", "Description" };
            foreach (string property in sizeProperties)
                Assert.PropertyChanged(t, property, () =>
                {
                    t.Size = Size.Large;
                });

            string[] sweetProperties = { "Sweet", "Description", "Ingredients" };
            foreach (string property in sweetProperties)
                Assert.PropertyChanged(t, property, () =>
                {
                    t.Sweet = true;
                });
            string[] lemonProperties = { "Lemon", "Special", "Ingredients" };
            foreach (string property in lemonProperties)
                Assert.PropertyChanged(t, property, () =>
                {
                    t.AddLemon();
                });

            string[] iceProperties = { "Ice", "Special" };
            foreach (string property in iceProperties)
                Assert.PropertyChanged(t, property, () =>
                {
                    t.HoldIce();
                });
        }
    }
}

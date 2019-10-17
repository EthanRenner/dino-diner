/* NotifyPropertyChangedTest.cs
 * Author: Ethan Renner
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class NotifyPropertyChangedTest
    {
        #region Drinks
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
            Assert.PropertyChanged(jj, "Description", () =>
            {
                jj.LeaveRoomForCream();
            });
            Assert.PropertyChanged(jj, "Description", () =>
            {
                jj.Decaf = false;
            });
            Assert.PropertyChanged(jj, "Ice", () =>
            {
                jj.AddIce();
            });
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
            string[] flavorProperties = { "Flavor", "Special", "Description" };
            foreach (string property in flavorProperties)
                Assert.PropertyChanged(s, property, () =>
                {
                    s.Flavor = SodasaurusFlavor.Chocolate;
                });
            Assert.PropertyChanged(s, "Ice", () =>
            {
                s.HoldIce();
            });
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
            string[] sweetProperties = { "Sweet", "Special", "Description", "Ingredients" };
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
            Assert.PropertyChanged(t, "Ice", () =>
            {
                t.HoldIce();
            });
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
            Assert.PropertyChanged(w, "Ice", () =>
            {
                w.HoldIce();
            });
        }
        #endregion Drinks

        [Fact]
        public void DinoNuggetsNotifyPropertyChanged()
        {
            DinoNuggets dn = new DinoNuggets();
            string[] properties = { "Special", "Price", "Calories", "Ingredients" };
            foreach (string property in properties)
                Assert.PropertyChanged(dn, property, () =>
                {
                    dn.AddNugget();
                });
        }
    }
}

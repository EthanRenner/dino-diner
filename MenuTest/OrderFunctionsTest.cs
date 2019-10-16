using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using System.IO;

namespace MenuTest
{
    public class OrderItemFunctionsTest
    {
        #region DescriptionTests
        #region Entrees

        [Fact]
        public void BrontowurstDescriptionTests()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal("Brontowurst", bw.Description);
        }


        [Fact]
        public void DinoNuggetDescriptionTests()
        {

            DinoNuggets dn = new DinoNuggets();
            Assert.Equal("Dino-Nuggets", dn.Description);
        }


        [Fact]
        public void PrehistoricPBJDescriptionTests()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal("Prehistoric PB&J", pbj.Description);
        }

        [Fact]
        public void PterodactylWingsDescriptionTests()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Equal("Pterodactyl Wings", pw.Description);
        }

        [Fact]
        public void SteakosaurusBurgerDescriptionTests()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal("Steakosaurus Burger", sb.Description);
        }

        [Fact]
        public void TRexKingBurgerDescriptionTests()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal("T-Rex King Burger", trex.Description);
        }

        [Fact]
        public void VelociWrapDescriptionTests()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal("Veloci-Wrap", vw.Description);
        }

        #endregion

        #region Sides

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void FryceritopsDescriptionTests(Size size)
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = size;
            Assert.Equal($"{size} Fryceritops", ft.Description);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void MeteorMacAndCheeseDescriptionTests(Size size)
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = size;
            Assert.Equal($"{size} Meteor Mac and Cheese", mmc.Description);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void MezzorellaSticksDescriptionTests(Size size)
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = size;
            Assert.Equal($"{size} Mezzorella Sticks", ms.Description);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void TriceritotsDescriptionTests(Size size)
        {
            Triceritots tt = new Triceritots();
            tt.Size = size;
            Assert.Equal($"{size} Triceritots", tt.Description);
        }

        #endregion

        #region Drinks

        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void JurrasicJavaDescriptionTests(Size size, bool decaf)
        {
            JurassicJava java = new JurassicJava();
            java.Size = size;
            java.Decaf = decaf;
            if (decaf) Assert.Equal($"{size} Decaf Jurassic Java", java.Description);
            else Assert.Equal($"{size} Jurassic Java", java.Description);
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
        public void SodaSaurusDescriptionTests(Size size, SodasaurusFlavor flavor)
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = size;
            soda.Flavor = flavor;
            Assert.Equal($"{size} {flavor} Sodasaurus", soda.Description);
        }

        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void TyrannoTeaDescriptionTests(Size size, bool sweet)
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = size;
            tea.Sweet = sweet;
            if (sweet) Assert.Equal($"{size} Sweet Tyrannotea", tea.Description);
            else Assert.Equal($"{size} Tyrannotea", tea.Description);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void WaterDescriptionTests(Size size)
        {
            Water water = new Water();
            water.Size = size;
            Assert.Equal($"{size} Water", water.Description);
        }

        #endregion

        #region Combos

        [Theory]
        [InlineData(typeof(Brontowurst), "Brontowurst Combo")]
        [InlineData(typeof(DinoNuggets), "Dino-Nuggets Combo")]
        [InlineData(typeof(PrehistoricPBJ), "Prehistoric PB&J Combo")]
        [InlineData(typeof(PterodactylWings), "Pterodactyl Wings Combo")]
        [InlineData(typeof(SteakosaurusBurger), "Steakosaurus Burger Combo")]
        [InlineData(typeof(TRexKingBurger), "T-Rex King Burger Combo")]
        [InlineData(typeof(VelociWrap), "Veloci-Wrap Combo")]
        public void CretaceousComboDescriptionTests(Type type, string name)
        {
            Entree entree = (Entree)Activator.CreateInstance(type);
            CretaceousCombo combo = new CretaceousCombo(entree);
            Assert.Equal(name, combo.Description);
        }

        #endregion
        #endregion DescriptionTests


        #region SpecialsTest
        #region Entrees

        [Fact]
        public void BrontowurstSpecialsTest()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Contains("+ Bun", bw.Special);
            Assert.Contains("+ Peppers", bw.Special);
            Assert.Contains("+ Onion", bw.Special);
            bw.HoldBun();
            bw.HoldPeppers();
            bw.HoldOnion();
            Assert.Contains("- Bun", bw.Special);
            Assert.Contains("- Peppers", bw.Special);
            Assert.Contains("- Onion", bw.Special);
        }


        [Fact]
        public void DinoNuggetSpecialsTest()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.Contains("6 Nuggets", dn.Special);
            dn.AddNugget();
            Assert.Contains("7 Nuggets", dn.Special);
        }


        [Fact]
        public void PrehistoricPBJSpecialsTest()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Contains("+ Peanut Butter", pbj.Special);
            Assert.Contains("+ Jelly", pbj.Special);
            pbj.HoldPeanutButter();
            pbj.HoldJelly();
            Assert.Contains("- Peanut Butter", pbj.Special);
            Assert.Contains("- Jelly", pbj.Special);
        }

        [Fact]
        public void PterodactylWingsSpecialsTest()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Empty(pw.Special);
        }

        [Fact]
        public void SteakosaurusBurgerSpecialsTest()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Contains("+ Bun", sb.Special);
            Assert.Contains("+ Pickle", sb.Special);
            Assert.Contains("+ Ketchup", sb.Special);
            Assert.Contains("+ Mustard", sb.Special);
            sb.HoldBun();
            sb.HoldPickle();
            sb.HoldKetchup();
            sb.HoldMustard();
            Assert.Contains("- Bun", sb.Special);
            Assert.Contains("- Pickle", sb.Special);
            Assert.Contains("- Ketchup", sb.Special);
            Assert.Contains("- Mustard", sb.Special);
        }

        [Fact]
        public void TRexKingBurgerSpecialsTest()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Contains("+ Bun", trex.Special);
            Assert.Contains("+ Pickle", trex.Special);
            Assert.Contains("+ Ketchup", trex.Special);
            Assert.Contains("+ Mustard", trex.Special);
            Assert.Contains("+ Tomato", trex.Special);
            Assert.Contains("+ Onion", trex.Special);
            Assert.Contains("+ Mayo", trex.Special);
            Assert.Contains("+ Lettuce", trex.Special);
            trex.HoldBun();
            trex.HoldPickle();
            trex.HoldKetchup();
            trex.HoldMustard();
            trex.HoldTomato();
            trex.HoldOnion();
            trex.HoldMayo();
            trex.HoldLettuce();
            Assert.Contains("- Bun", trex.Special);
            Assert.Contains("- Pickle", trex.Special);
            Assert.Contains("- Ketchup", trex.Special);
            Assert.Contains("- Mustard", trex.Special);
            Assert.Contains("- Tomato", trex.Special);
            Assert.Contains("- Onion", trex.Special);
            Assert.Contains("- Mayo", trex.Special);
            Assert.Contains("- Lettuce", trex.Special);
        }

        [Fact]
        public void VelociWrapSpecialsTest()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Contains("+ Dressing", vw.Special);
            Assert.Contains("+ Cheese", vw.Special);
            Assert.Contains("+ Lettuce", vw.Special);
            vw.HoldDressing();
            vw.HoldCheese();
            vw.HoldLettuce();
            Assert.Contains("- Dressing", vw.Special);
            Assert.Contains("- Cheese", vw.Special);
            Assert.Contains("- Lettuce", vw.Special);
        }

        #endregion

        #region Sides

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void FryceritopsSpecialsTest(Size size)
        {
            Fryceritops ft = new Fryceritops();
            Assert.Empty(ft.Special);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void MeteorMacAndCheeseSpecialsTest(Size size)
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = size;
            Assert.Empty(mmc.Special);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void MezzorellaSticksSpecialsTest(Size size)
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = size;
            Assert.Empty(ms.Special);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void TriceritotsSpecialsTest(Size size)
        {
            Triceritots tt = new Triceritots();
            tt.Size = size;
            Assert.Empty(tt.Special);
        }

        #endregion

        #region Drinks

        [Fact]
        public void JurrasicJavaSpecialsTest()
        {
            JurassicJava java = new JurassicJava();
            Assert.Contains("- Decaf", java.Special);
            java.Decaf = true;
            Assert.Contains("+ Decaf", java.Special);
            java.Decaf = false;
            Assert.Contains("- Decaf", java.Special);

            Assert.Contains("- RoomForCream", java.Special);
            java.LeaveRoomForCream();
            Assert.Contains("+ RoomForCream", java.Special);
            java.RoomForCream = false;
            Assert.Contains("- RoomForCream", java.Special);

            Assert.Contains("- Ice", java.Special);
            java.AddIce();
            Assert.Contains("+ Ice", java.Special);
            java.HoldIce();
            Assert.Contains("- Ice", java.Special);
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
        public void SodaSaurusSpecialsTest(Size size, SodasaurusFlavor flavor)
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = size;
            soda.Flavor = flavor;
            Assert.Contains(flavor.ToString(), soda.Special);
            Assert.Contains("+ Ice", soda.Special);
            soda.HoldIce();
            Assert.Contains("- Ice", soda.Special);
        }

        [Fact]
        public void TyrannoTeaSpecialsTest()
        {
            Tyrannotea tea = new Tyrannotea();

            Assert.Contains("- Sugar", tea.Special);
            Assert.Contains("- Lemon", tea.Special);
            Assert.Contains("+ Ice", tea.Special);
            tea.AddLemon();
            tea.Sweet = true;
            tea.HoldIce();
            Assert.Contains("+ Sugar", tea.Special);
            Assert.Contains("+ Lemon", tea.Special);
            Assert.Contains("- Ice", tea.Special);
        }

        [Fact]
        public void WaterSpecialsTest()
        {
            Water water = new Water();

            Assert.Contains("- Lemon", water.Special);
            Assert.Contains("+ Ice", water.Special);
            water.AddLemon();
            water.HoldIce();
            Assert.Contains("+ Lemon", water.Special);
            Assert.Contains("- Ice", water.Special);
        }

        #endregion

        #region Combos
        [Theory]
        [InlineData(typeof(Brontowurst), "Brontowurst Combo")]
        [InlineData(typeof(DinoNuggets), "Dino-Nuggets Combo")]
        [InlineData(typeof(PrehistoricPBJ), "Prehistoric PB&J Combo")]
        [InlineData(typeof(PterodactylWings), "Pterodactyl Wings Combo")]
        [InlineData(typeof(SteakosaurusBurger), "Steakosaurus Burger Combo")]
        [InlineData(typeof(TRexKingBurger), "T-Rex King Burger Combo")]
        [InlineData(typeof(VelociWrap), "Veloci-Wrap Combo")]
        public void CretaceousComboSepcialsTest(Type type, string name)
        {
            Entree entree = (Entree)Activator.CreateInstance(type);
            CretaceousCombo combo = new CretaceousCombo(entree);
            Assert.Equal(name, combo.Description);
        }
        #endregion
        #endregion SpecialsTest
    }
}

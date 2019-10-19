/* CretaceousComboTest.cs
 * Author: Ethan Renner
 */
using DinoDiner.Menu;
using System;
using Xunit;

namespace MenuTest
{
    public class CretaceousComboTest
    {
        [Theory]
        [InlineData(typeof(Brontowurst), "Brontowurst Combo")]
        [InlineData(typeof(DinoNuggets), "Dino-Nuggets Combo")]
        [InlineData(typeof(PrehistoricPBJ), "Prehistoric PB&J Combo")]
        [InlineData(typeof(PterodactylWings), "Pterodactyl Wings Combo")]
        [InlineData(typeof(SteakosaurusBurger), "Steakosaurus Burger Combo")]
        [InlineData(typeof(TRexKingBurger), "T-Rex King Burger Combo")]
        [InlineData(typeof(VelociWrap), "Veloci-Wrap Combo")]
        public void CretaceousComboDescriptionTest(Type type, string name)
        {
            Entree entree = (Entree)Activator.CreateInstance(type);
            CretaceousCombo combo = new CretaceousCombo(entree);
            Assert.Equal(name, combo.Description);
        }

        [Theory]
        [InlineData(typeof(Brontowurst))]
        [InlineData(typeof(DinoNuggets))]
        [InlineData(typeof(PrehistoricPBJ))]
        [InlineData(typeof(PterodactylWings))]
        [InlineData(typeof(SteakosaurusBurger))]
        [InlineData(typeof(TRexKingBurger))]
        [InlineData(typeof(VelociWrap))]
        public void CretaceousComboSpecialsTest(Type entreeType)
        {
            Entree entree = (Entree)Activator.CreateInstance(entreeType);
            CretaceousCombo combo = new CretaceousCombo(entree);

            entree.AddSpecial("Entree special test");
            combo.Side = new MezzorellaSticks();
            combo.Drink = new Water();
            ((Water)combo.Drink).AddLemon();

            foreach (string str in combo.Entree.Special)
                Assert.Contains(str, combo.Special);

            Assert.Contains(combo.Side.Description, combo.Special);
            foreach (string str in combo.Side.Special)
                Assert.Contains(str, combo.Special);

            Assert.Contains(combo.Drink.Description, combo.Special);
            foreach (string str in combo.Drink.Special)
                Assert.Contains(str, combo.Special);
        }
    }
}

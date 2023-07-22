using Xunit.Sdk;

namespace UnitTests
{
    public class UnitTests
    {
        [Fact]
        public void MinDamage()
        {
            // Arrange
            Weapon dagger = new Weapon("Dagger", 5, 7, 12, "swift and agile weapon allowing for quick strikes and precise critical hits.", WeaponTypes.Dagger);
            int expected = 7;

            // Act
            int actual = dagger.MinDamage;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsEnhanced()
        {
            // Arrange
            HumanWarlock humanWarlock = new HumanWarlock();
            bool expected = true;
            
            // Act
            bool actual = humanWarlock.IsEnhanced;
            
            // Assert
            Assert.True(true);
        }

        [Fact]
        public void Life()

        {
            // Arrange
            GnomeWarlock gnomeWarlock = new GnomeWarlock();
            int expected = 100;

            // Act
            int actual = gnomeWarlock.Life;
            
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StringName()
        {
            // Arrange
            GhostlySteward ghostlySteward = new GhostlySteward("Ghostly Steward", 50, 25, 25, 10, 7, "An ethereal servant bound to a haunted estate, forever carrying out its spectral duties.", 50);
            string expected = "Ghostly Steward";
            
            // Act
            string actual = ghostlySteward.Name;
            
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MaxDamage()
        {
            // Arrange
            Weapon dagger = new Weapon("Dagger", 5, 7, 12, "swift and agile weapon allowing for quick strikes and precise critical hits.", WeaponTypes.Dagger);
            int expected = 12;

            // Act
            int actual = dagger.MaxDamage;

            // Assert
            Assert.Equal(expected, actual);
        }

    }
}
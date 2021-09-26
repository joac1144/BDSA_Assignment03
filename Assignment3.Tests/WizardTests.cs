using Xunit;

namespace BDSA2021.Assignment03.Tests
{
    public class WizardTests
    {
        [Fact]
        public void Wizards_contains_9_wizards()
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Equal(9, wizards.Count);
        }

        [Theory]
        [InlineData("Darth Vader", "Star Wars", 1977, "George Lucas")]
        [InlineData("Sauron", "The Fellowship of the Ring", 1954, "J.R.R. Tolkien")]
        [InlineData("Joachim", "null", 2000, "mother")]
        [InlineData("Harry Potter", "Harry Potter", 1997, "J. K. Rowling")]
        [InlineData("Albus Dumbledore", "Harry Potter", 1997, "J. K. Rowling")]
        [InlineData("Warlic", "AdventureQuest", 2002, "Artix Entertainment")]
        [InlineData("Merlin", "Prophetiæ Merlini", 1135, "Geoffrey of Monmouth")]
        [InlineData("Gandalf", "???", 1937, "J.R.R. Tolkien")]
        [InlineData("Darth Test", "ITU Wars", 2021, "Joachim Kofoed")]
        public void Spot_check_wizards(string name, string medium, int year, string creator)
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Contains(wizards, w =>
                w.Name == name &&
                w.Medium == medium &&
                w.Year == year &&
                w.Creator == creator
            );
        }
    }
}


using Xunit;

namespace BDSA2021.Assignment03.Tests
{
    public class WizardTests
    {
        [Fact]
        public void Wizards_contains_9_wizards()
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Equal(12, wizards.Count);
        }

        [Theory]
        [InlineData("Darth Vader", "Star Wars", 1977, "George Lucas")]
        [InlineData("Sauron", "The Fellowship of the Ring", 1954, "J.R.R. Tolkien")]
        [InlineData("Joachim", "null", 2000, "mother")]
        [InlineData("Harry Potter", "Harry Potter", 1997, "J. K. Rowling")]
        [InlineData("Albus Dumbledore", "Harry Potter", 1997, "J. K. Rowling")]
        [InlineData("Warlic", "AdventureQuest", 2002, "Artix Entertainment")]
        [InlineData("Merlin", "Prophetiæ Merlini", 1135, "Geoffrey of Monmouth")]
        [InlineData("Gandalf", "Lord of the Rings", 1937, "J.R.R. Tolkien")]
        [InlineData("Darth Test", "ITU Wars", 2021, "Joachim Kofoed")]
        [InlineData("Ron Weasly","Harry Potter",1998,"J. K. Rowling")]
        [InlineData("Veigar","League of Legends",2009,"Riot Games")]
        [InlineData("Ryze","League of Legends",2008,"Riot Games")]
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


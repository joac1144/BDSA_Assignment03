using System;
using Xunit;
using System.Collections.Generic;

namespace BDSA2021.Assignment03.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void WizardsInventedByRowlingLINQ_ReturnsNameOfAllWizardsInventedByRowling()
        {
            IEnumerable<string> expected = new List<string>() {"Harry Potter", "Albus Dumbledore", "Ron Weasly"};
            var actual = Queries.WizardsInventedByRowlingLINQ();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void WizardsInventedByRowlingExtensions_ReturnsNameOfAllWizardsInventedByRowling()
        {
            IEnumerable<string> expected = new List<string>() {"Harry Potter", "Albus Dumbledore", "Ron Weasly"};
            var actual = Queries.WizardsInventedByRowlingExtensions();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YearOfTheFirstSithLordLINQ_ReturnsYearOfTheFirstSithLord()
        {
            int? expected = 1977;
            var actual = Queries.YearOfTheFirstSithLordLINQ();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void YearOfTheFirstSithLordExtensions_ReturnsYearOfTheFirstSithLord()
        {
            int? expected = 1977;
            var actual = Queries.YearOfTheFirstSithLordExtensions();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ListOfWizardsFromHarryPotterLINQ_ReturnsListOfTuplesWithNameAndYear()
        {
            IEnumerable<(string, int?)> expected = new List<(string, int?)>() {
                ("Harry Potter", 1997), 
                ("Albus Dumbledore", 1997),
                ("Ron Weasly", 1998)
            };
            var actual = Queries.ListOfWizardsFromHarryPotterLINQ();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ListOfWizardsFromHarryPotterExtensions_ReturnsListOfTuplesWithNameAndYear()
        {
            IEnumerable<(string, int?)> expected = new List<(string, int?)>() {
                ("Harry Potter", 1997), 
                ("Albus Dumbledore", 1997),
                ("Ron Weasly" , 1998)
            };
            var actual = Queries.ListOfWizardsFromHarryPotterExtensions();
            Assert.Equal(expected, actual);
        } 

        [Fact]
        public void ListOfWizardsGroupedByCreatorLINQ_ReturnsListInCorrectOrder()
        {
            IEnumerable<string> expected = new List<string>() {
                "Veigar",
                "Ryze",
                "Joachim",
                "Darth Test",
                "Sauron",
                "Gandalf",
                "Ron Weasly",
                "Harry Potter",
                "Albus Dumbledore",
                "Darth Vader",
                "Merlin",
                "Warlic"
            };
            var actual = Queries.ListOfWizardsGroupedByCreatorLINQ();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ListOfWizardsGroupedByCreatorExtensions_ReturnsListInCorrectOrder()
        {
            IEnumerable<string> expected = new List<string>() {
                "Veigar",
                "Ryze",
                "Joachim",
                "Darth Test",
                "Sauron",
                "Gandalf",
                "Ron Weasly",
                "Harry Potter",
                "Albus Dumbledore",
                "Darth Vader",
                "Merlin",
                "Warlic"
            };
            var actual = Queries.ListOfWizardsGroupedByCreatorExtensions();
            Assert.Equal(expected, actual);
        }
    }
}

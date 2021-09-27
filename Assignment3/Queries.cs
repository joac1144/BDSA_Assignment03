using System.Linq;
using System.Collections.Generic;

namespace BDSA2021.Assignment03
{
    public class Queries
    {
        //Wizards invented by Rowling. Only return the names.
        public static IEnumerable<string> WizardsInventedByRowlingLINQ()
        {
            var wizards = Wizard.Wizards.Value;
            var result = from w in wizards
                         where w.Creator == "J. K. Rowling"
                         select w.Name;
            return result;
        }
        public static IEnumerable<string> WizardsInventedByRowlingExtensions()
        {
            var wizards = Wizard.Wizards.Value;
            var result = wizards.Where(w => w.Creator == "J. K. Rowling")
                                .Select(w => w.Name);
            return result;
        }

        //The year the first sith lord was introduced. Let's define a sith lord to be one named Darth something.
        public static int? YearOfTheFirstSithLordLINQ()
        {
            var wizards = Wizard.Wizards.Value;
            var result = (from w in wizards
                         where w.Name.Contains("Darth ")
                         select w.Year).Min();
            return result;
        }
        public static int? YearOfTheFirstSithLordExtensions()
        {
            var wizards = Wizard.Wizards.Value;
            var result = wizards.Where(w => w.Name.Contains("Darth "))
                                .Select(w => w.Year)
                                .Min();
            return result;
        }

        //Unique list of wizards from the Harry Potter books - only return name and year (as a value tuple).
        public static IEnumerable<(string, int?)> ListOfWizardsFromHarryPotterLINQ()
        {
            var wizards = Wizard.Wizards.Value;
            var result = from w in wizards
                         where w.Medium.Equals("Harry Potter")
                         select (
                             w.Name,
                             w.Year
                         );
            return result;
        }

        public static IEnumerable<(string, int?)> ListOfWizardsFromHarryPotterExtensions()
        {
            var wizards = Wizard.Wizards.Value;
            var result = wizards.Where(w => w.Medium.Equals("Harry Potter"))
                                .Select(w => (w.Name, w.Year)).Distinct();
            return result;
        }
        
        //List of wizard names grouped by creator in reverse order by creator name and then wizard name.
        public static IEnumerable<string> ListOfWizardsGroupedByCreatorLINQ()
        {
            var wizards = Wizard.Wizards.Value;
            var result = from w in wizards
                         orderby w.Creator descending, w.Name descending
                         select w.Name;
            return result;
        }
        public static IEnumerable<string> ListOfWizardsGroupedByCreatorExtensions()
        {
            var wizards = Wizard.Wizards.Value;
            var result = wizards.OrderByDescending(w => w.Creator)
                                .ThenByDescending(w => w.Name)
                                .Select(w => w.Name);
            return result;
        }
    }
}

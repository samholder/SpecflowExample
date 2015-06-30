using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    using TechTalk.SpecFlow;

    [Binding]
    class Steps
    {
        [Given(@"I am on the Initiatives page")]
        public void GivenIAmOnTheInitiativesPage()
        {
            Console.WriteLine("I am on the Initiatives page");

        }

        [When(@"I select the first initiative")]
        public void WhenISelectTheFirstInitiative()
        {
            Console.WriteLine("I select the first initiative");

        }

        [Given(@"I am on the Targets page")]
        public void GivenIAmOnTheTargetsPage()
        {
            Console.WriteLine("I am on the Targets page");
        }

        [When(@"I filter Employment Status by '(.*)'")]
        public void WhenIFilterEmploymentStatusBy(string p0)
        {
            Console.WriteLine("I filter Employment Status by '(.*)'");
        }

        [Given(@"no filters are applied")]
        public void GivenNoFiltersAreApplied()
        {
            Console.WriteLine("no filters are applied");
        }

    }
}

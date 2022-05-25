using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Research
    {
        public Research(Relationships relationships)
        {
        }

        public Research(IRelationshipBrowser browser)
        {
            foreach (var p in browser.FindAllChildrenOf("Kuppusamy"))
            {
                Console.WriteLine($"Kuppusamy has a child called {p.Name}");
            }
        }
    }
}

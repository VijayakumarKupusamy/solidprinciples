using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Relationships : IRelationshipBrowser // low-level design
    {
        
        private readonly List<(Person,Relationship,Person)> _relations= new List<(Person, Relationship, Person)> ();

        public void AddParentAndChild(Person parent, Person child)
        {
            _relations.Add((parent, Relationship.Parent, child));
            _relations.Add((child, Relationship.Child, parent));
        }

        public List<(Person, Relationship, Person)> Relations => _relations;

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return _relations
              .Where(x => x.Item1.Name == name
                          && x.Item2 == Relationship.Parent).Select(r => r.Item3);
        }
    }
}

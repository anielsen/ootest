using System.Collections.Generic;

namespace ootest
{

    // Alias for a list of persons
    public class Children : List<Person>
    {
        public Children() : base() { }
        public Children(Person p) : base(new Person[] { p }) { }
        public Children(Person[] p) : base(p) { }

    }
}
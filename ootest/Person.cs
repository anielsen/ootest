using System;
using System.Collections.Generic;
using System.Linq;

/*
    Pointer:
        Abstrakt klasse
        Indkapsling af data
        Adgang via accessors
*/

namespace ootest
{

    // Alias
    public class Children : List<Person>
    {
        public Children() : base() { }
        public Children(Person p) : base(new Person[] { p }) { }
        public Children(Person[] p) : base(p) { }

    }



    abstract public class Person
    {
        private int _age;
        private string _name;
        private Children _children;

        public Person(int age, string name, Children children)
        {
            _age = age;
            _name = name;
            _children = children;
        }
        public Person(int age, string name) : this(age, name, new Children()) { }

        public virtual string description()
        {
            return this._name;
        }

        public List<string> familyDescription()
        {
            List<string> res = new List<string>(new string[] { this.description() });
            foreach (var c in this._children)
            {
                res.AddRange(c.familyDescription());
            }
            return res;
        }

        protected Tuple<int, int> averageAgeHelper()
        {
            int count = 1;
            int ageSum = this._age;
            foreach (var c in this._children)
            {
                var recursiveResult = c.averageAgeHelper();
                count += recursiveResult.Item1;
                ageSum += recursiveResult.Item2;
            }
            return Tuple.Create(count, ageSum);
        }

        public float averageAge()
        {
            var t = this.averageAgeHelper();
            return (float)t.Item2 / (float)t.Item1;
        }

    }
}



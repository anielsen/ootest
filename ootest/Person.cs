using System;
using System.Collections.Generic;
using System.Linq;

/*
    Pointer:
        Abstrakt klasse
        Indkapsling af data
        Adgang via accessors
        virtual => dynamisk dispatch
*/

namespace ootest
{
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

        public virtual string description() => this._name;

        public List<string> familyDescription()
        {
            List<string> res = new List<string>(new string[] { this.description() });
            foreach (var c in this._children)
            {
                res.AddRange(c.familyDescription());
            }
            return res;
        }

        protected (int count, int ageSum) averageAgeHelper()
        {
            int count = 1;
            int ageSum = this._age;
            foreach (var c in this._children)
            {
                var recursiveResult = c.averageAgeHelper();
                count += recursiveResult.Item1;
                ageSum += recursiveResult.Item2;
            }
            return (count, ageSum);
        }

        public float averageAge()
        {
            var (count, ageSum) = this.averageAgeHelper();
            return (float)ageSum / (float)count;
        }

        protected T traversal<T>(Func<Person, T> nodeHandler, Func<T, T, T> fold)
        {
            T res = nodeHandler(this);
            foreach (var c in this._children)
            {
                res = fold(res, c.traversal<T>(nodeHandler, fold));
            }
            return res;
        }

        public List<string> familyDescription2() => traversal<List<string>>(
            nodeHandler: p => new List<string>(new string[] { p.description() }),
            fold: (l1, l2) => l1.Concat(l2).ToList()
            );

        public int count() => traversal<int>(nodeHandler: p => 1, fold: (x,y) => x+y);
        public int ageSum() => traversal<int>(nodeHandler: p => p._age, fold: (x,y) => x+y);
        public float averageAge2() {
            return (float)this.ageSum() / (float)this.count();
        }

    }
}



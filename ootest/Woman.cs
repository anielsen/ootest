using System.Collections.Generic;

namespace ootest
{
    public class Woman : Person
    {
        private int _shoeSize;

        public Woman(int age, string name, Children children, int shoeSize) : base(age, name, children) => _shoeSize = shoeSize;
        public Woman(int age, string name, int shoeSize) : base(age, name) => _shoeSize = shoeSize;

        public override string description()
        {
            return base.description() + " size " + this._shoeSize;
        }
    }
}

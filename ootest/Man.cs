using System.Collections.Generic;

namespace ootest
{
    public class Man : Person
    {
        private string _favTeam;

        public Man(int age, string name, Children children, string favTeam) : base(age, name, children) => _favTeam = favTeam;

        public Man(int age, string name, string favTeam) : base(age, name) => _favTeam = favTeam;

        public override string description() {
            return base.description() + " follows "+this._favTeam;
        }
    }
}
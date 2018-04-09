using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ootest.Tests
{
    [TestClass]
    public class UnitTest1
    {

        Person getData()
        {
            Person Aida = new Woman(age: 8, name: "Adia", shoeSize: 31);
            Person Dina = new Woman(age: 3, name: "Dina", shoeSize: 23);
            Person Casandra = new Woman(age: 1, name: "Casandra", shoeSize: 15);
            Person Aske = new Man(age: 39, name: "Aske", children: new Children(new Person[] { Aida, Dina, Casandra }), favTeam: "BK FREM");
            return Aske;
        }

        [TestMethod]
        public void family_description()
        {
            Person Aske = getData();
            CollectionAssert.AreEqual(
                expected: new List<string>(new string[] { "Aske follows BK FREM", "Adia size 31", "Dina size 23", "Casandra size 15" }),
                actual: Aske.familyDescription(),
                message: "Askes familiebeskrivelse er som i opgaven"
            );
        }
        [TestMethod]
        public void averageAge()
        {
            Person Aske = getData();
            Assert.AreEqual(
                expected: 12.75,
                actual: Aske.averageAge(),
                message: "Gennemsnitsalderen er 12,75 som beskrevet i opgaven"
            );
        }

       [TestMethod]
        public void family_description2()
        {
            Person Aske = getData();
            CollectionAssert.AreEqual(
                expected: new List<string>(new string[] { "Aske follows BK FREM", "Adia size 31", "Dina size 23", "Casandra size 15" }),
                actual: Aske.familyDescription2(),
                message: "Askes familiebeskrivelse er som i opgaven"
            );
        }
        [TestMethod]
        public void averageAge2()
        {
            Person Aske = getData();
            Assert.AreEqual(
                expected: 12.75,
                actual: Aske.averageAge2(),
                message: "Gennemsnitsalderen er 12,75 som beskrevet i opgaven"
            );
        }


    }
}

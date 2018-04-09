using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ootest.Tests
{
    [TestClass]
    public class UnitTest1
    {

        Person getData()
        {
            Person Aida = new Woman(8, "Adia", 31);
            Person Dina = new Woman(3, "Dina", 23);
            Person Casandra = new Woman(1, "Casandra", 15);
            Person Aske = new Man(39, "Aske", new Children(new Person[] { Aida, Dina, Casandra }), "BK FREM");
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

    }
}

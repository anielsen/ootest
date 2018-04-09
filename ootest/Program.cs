using System;
using System.Collections.Generic;

namespace ootest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Man kan lave en instans af et abstrakt klasse
            // Person Julemanden = new Person(987, "Klaus");

            Man Alvin = new Man(age: 3, name: "Alvin", favTeam: "RSIK");
            Person Martinus = new Man(age: 3, name: "Martinus", favTeam: "RSIK");

            Console.WriteLine("Alvin says: " + Alvin.chant());

            // Man kan ikke tilgå chant metoden gennem et Person reference
            // Console.WriteLine("Martinus says: "+Martinus.chant());

            Person Anders = new Man(42, "Anders", new Children(new Person[] { Martinus, Alvin }), "Brøndbyernes IF");
            Person Sif = new Woman(8, "Sif", 33);
            Person Aslan = new Man(11, "Aslan", "Avarta");
            Person Lonni = new Woman(42, "Lonni", new Children(new Person[] { Aslan, Sif, Martinus, Alvin }), 38);

            Person Lene = new Woman(70, "Lene", new Children(new Person[] { Anders }), 37);

            Console.WriteLine("Anders:");
            Console.WriteLine(Anders.description());
            Console.WriteLine(Anders.averageAge());
            foreach (string s in Lene.familyDescription())
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Lene gennemsnitsalder i familie: " + Lene.averageAge());
        }
    }
}

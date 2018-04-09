using System;
using System.Collections.Generic;

namespace ootest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Man Alvin = new Man(3, "Alvin", "RSIK");
            Man Martinus = new Man(3, "Martinus", "RSIK");

            Man Anders = new Man(42, "Anders", new Children( new Person[] { Martinus, Alvin }), "Brøndby");
            Woman Sif = new Woman(8, "Sif", 33);
            Man Aslan = new Man(11, "Aslan", "Avarta");
            Woman Lonni = new Woman(42, "Lonni", new Children(new Person[] { Aslan, Sif, Martinus, Alvin }), 38);

            Woman Lene = new Woman(70,"Lene", new Children(new Person[] { Anders }), 37);
            Person x = Anders;
            Console.WriteLine("Anders:");
            Console.WriteLine(Anders.description());
            Console.WriteLine(Anders.averageAge());
            foreach ( string s in Lene.familyDescription() ) {
                Console.WriteLine(s);
            }
            Console.WriteLine("Lene gennemsnitsalder i familie: "+Lene.averageAge());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroWithInheritance.models
{
    public class SuperHeroDC : SuperHeroDC
    {
        public SuperHeroDC()
        {
            Universe = "DC";
            Console.WriteLine = ($"SuperHeroDC" { Universe} "constructor called");

        }
    }
}

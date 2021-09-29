using System;
using System.Collections.Generic;
using System.Text;

namespace Superhero
{
    class SuperHero
    {

        public string Alias { get; set; }
        public string HeroName { get; set; }
        public string[] Powers { get; set; }

        public SuperHero(string aka, string name, string[] powers)
        {
            Alias = aka;
            HeroName = name;
            Powers = new string[powers.Length];
            for (int i=0;i<Powers.Length;i++)
            {
                this.Powers[i] = powers[i];
            }
        }

        public SuperHero()
        {

        }

        public override string ToString()
        {
            return $"My name is {Alias} also know as {HeroName}.";  
        }

        public void DisplayPowers()
        {
            foreach (string powers in Powers)
            {
                Console.WriteLine($"I am able to {powers}.");
            }

        }
    }
}

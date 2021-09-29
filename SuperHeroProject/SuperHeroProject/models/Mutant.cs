using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroProject.models
{
    public abstract class Mutant : SuperHero
    {
        public string powers {get;set; }

        public Mutant()
        {
            powers = "super strenght, healing,agility";
        }

    }

    public class Wolwerine : Mutant
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Powers()
        {
            return $"My name is Wolwerine and I these are my powers :  {powers} ";
        }
    }

}

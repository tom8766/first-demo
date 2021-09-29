using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroProject
{
    public abstract class Alien : SuperHero
    {
        public string powers { get; set; }

        public Alien()
        {
            powers = "super strenght, healing,agility, speed, fly";
        }
    }

    public class Superman : Alien
    {
        
public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Powers()
        {
            return $"My name is Superman and these are my powers : {powers} ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroProject.models
{
    public abstract class Plant : SuperHero
    {
        public string powers { get; set; }

        public Plant()
        {
            powers = "absorb organic matter and regenerate my cells";
        }
    }

    public class Groot : Plant
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Powers()
        {
            return $"My name is Groot and I can {powers}";
        }
    }
}

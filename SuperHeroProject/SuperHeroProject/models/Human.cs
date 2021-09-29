using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroProject.models
{
    public abstract class Human : SuperHero
    {
       
    }

    public class Batman : Human
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Powers()
        {
            return $"My name is Batman and I can fight crime, investigate cases without any superpowers";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroProject.models
{
    public abstract class AI : SuperHero
    {

    }

    public class Irobot : AI
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Powers()
        {
            return "My name is Irobot and I can mind control and have the same behaviour as a human";
        }
    }
}

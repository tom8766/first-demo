using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroProject.models
{
    public class SuperHeroGroup : Display
    {
        public List<SuperHero> Group = new List<SuperHero>();

        public SuperHeroGroup()
        {
            Group.Add(new Batman());
            Group.Add(new Superman());
            Group.Add(new Groot());
            Group.Add(new Wolwerine());
            Group.Add(new Irobot());
        }

        public override void Powers()
        {

            foreach (SuperHero super in Group)
            {
                Console.WriteLine(super.Powers());
            }
        }
    }
}

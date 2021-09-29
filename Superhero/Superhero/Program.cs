using System;

namespace Superhero
{
    class Program
    {
        static void Main(string[] args)
        {

            // List<string> Powers = new List<string>() { "invest", "dg"}

            //SuperHero superhero5 = new() 
            //{ 
            //    Alias = "Bruce Banner",
            //    HeroName = "The Hulk",
            //    Powers = new string[] { "Super strenght" }
            //};


            Console.WriteLine("Justice League" +"\n");
            string[] powers = new string[] { "investigate cases", "fights without any superpower" };
            SuperHero Batman = new SuperHero("Batman", "Bruce Wayne", powers);

            SuperHero WonderWoman = new SuperHero();
            WonderWoman.HeroName = "Wonder Woman";
            WonderWoman.Alias = "Diana Prince";
            WonderWoman.Powers = new string[] { "Flight", "Lasso of truth", "Superhuman agility", "Super speed, strenght and healing" };

            string[] supe = new string[] { " X ray vision", "Super speed and strength", "flight" };
            SuperHero SuperMan = new SuperHero("Superman", "Clark Kent", supe);

            string[] green = new string[] { "flight", "hypnotize people", "time travel" };
            SuperHero GreenLantern = new SuperHero("Green Lantern", "Hal Jordan", green);

            string[] arr = new string[] { "bowman", "acrobat", "martial arts" };
            SuperHero Arrow = new SuperHero("Arrow", "Oliver Queen", arr);

            string [] fast = new string[] { " super speed", "can time travel" };
            SuperHero Flash = new SuperHero("Flash", "Barry Allen", fast);




            SuperHero[] JusticeLeague = new SuperHero[] {Batman,WonderWoman,GreenLantern,Arrow,Flash,SuperMan };

            for (int i=0;i<JusticeLeague.Length;i++)
            {
                Console.WriteLine(JusticeLeague[i].ToString()+ "\n");
                JusticeLeague[i].DisplayPowers();
                Console.WriteLine();
            }
            
        }
    }
}

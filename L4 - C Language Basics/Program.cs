using System;
namespace L4
{
    class ProgramL4
    {
        static void Main(string[] args)
        {
            //Hello World Program
            string name = "Earth"; // Actually a reference type, but acts like value type
            Console.WriteLine($"Hello World, We Are On Planet {name}");

            // Value Type
            Planet p1 = new Planet();
            p1.PlanetName = "Mercury";
            p1.PlanetType = "Unhabitable";


            Planet p2 = p1;
            p2.PlanetName = "Venus";

            Console.WriteLine(p2.PlanetName);

            CreatePlanet();

            //Parameter Modifiers        
            //Ref
            int btcholdings = 5; //Refers to this value and modifies it.
            btcHoldings(ref btcholdings);
            Console.WriteLine($"BTC holdings to add: {btcholdings} BTC");


            static void btcHoldings(ref int btcholdings)
            {
                btcholdings = btcholdings + 3;
                Console.WriteLine($"Current BTC holdings: {btcholdings} BTC");
            }

            //Out
            int btcholdingss = 5; //Refers to this value and modifies it.
            int ethholdingss, scrtholdings;
            btcHoldingss(btcholdingss, out ethholdingss, out scrtholdings);
            Console.WriteLine($"BTC holdings to add: {btcholdingss} BTC");


            static void btcHoldingss(int btcholdingss, out int ethholdings, out int scrtholdings)
            {
                ethholdings = 5;
                scrtholdings = 15;
                btcholdingss = btcholdingss + 3;
                Console.WriteLine($"Current BTC holdings: {btcholdingss} BTC");
            }

            //

            //Reference Type - If we change the planet the data for this planet will change in AddDescription() as well and give us another return.

            void CreatePlanet()
            {
                Planet p3 = new Planet() { PlanetName = "Earth", PlanetType = "Habitable" };
                AddDescription(p3);

                Console.WriteLine($"{p3.PlanetName} {p3.PlanetType} {p3.PlanetDescription}");
            }


            void AddDescription(Planet planet)
            {
                string planetDescription = planet.PlanetName + planet.PlanetType;
                planet.PlanetDescription = planetDescription;
            }

            // Boxing Unboxing
            string[] exoplanet = new[] { "Kepler", "HZ345" };
            object exoplanetName = exoplanet[0];
            var getExoplanetName = (string)exoplanetName;
            Console.WriteLine(getExoplanetName);

            int x = 5;
            int y = 6;
            object number = x + y;
            var num = (int)number;
            Console.WriteLine(num);
            //
        }
    }


    public class Planet
    {
        public string PlanetName;
        public string PlanetType;
        public string PlanetDescription;
        public int PlanetRadius;
        public int PlanetDistance = PlanetDistanceEnter();

        //Static Method
        static int PlanetDistanceEnter()
        {
            var x = 1000;
            var y = 1500;
            var distance = x * y;
            return distance;
        }
    }
}
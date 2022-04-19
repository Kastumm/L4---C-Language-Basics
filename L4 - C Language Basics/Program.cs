using System;
namespace L4
{
    class ProgramL4
    {
        static void Main(string[] args)
        {
            var a = 1;
            //Hello World Program
            var name = "Earth";
            Console.WriteLine($"Hello World, We Are On Planet {name}");

            // Value Type
            Planet p1 = new Planet();
            p1.PlanetName = "Mercury";
            p1.PlanetType = "Unhabitable";

            PassByValueRef(ref a, ref p1);
            Console.WriteLine(a);
            Console.WriteLine(p1.PlanetName + p1.PlanetType);

            PassByValueOut(out a, out p1);
            Console.WriteLine(a);
            Console.WriteLine(p1.PlanetName + p1.PlanetType);

            Planet p2 = p1;
            p2.PlanetName = "Venus";

            Console.WriteLine(p2.PlanetName);

            CreatePlanet();

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

            //Parameter Modifiers

            static void PassByValueRef(ref int a, ref Planet planet)
            {
                a = a + 1;
                planet = new Planet();
            }

            static void PassByValueOut(out int a, out Planet planet)
            {
                a = 1;
                planet = new Planet();
            }


            Planet planet = new Planet() { PlanetName = "HZ", PlanetType = "HZ2" };
            Console.WriteLine(planet.PlanetDistance);

            // Boxing Unboxing
            int x = 5;
            int y = 6;
            object number = x + y;
            var num = (int)number;
            Console.WriteLine(num);

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
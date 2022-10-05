using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Civic: RaceCar
    {
        public Civic()
        {
            Name = "Civic";
            TopSpeed = 155;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} engine quickly starts!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} screeches to a halt!");
            Console.WriteLine($"The {Name} ends in position {Position}!");
        }
    }
}


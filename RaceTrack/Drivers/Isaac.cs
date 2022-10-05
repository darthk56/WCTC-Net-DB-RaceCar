using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Isaac : Driver
    {
        public Isaac(RaceCar car) : base(car)
        {
            Name = "Isaac";
            SkillLevel = 50;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }

    }
}
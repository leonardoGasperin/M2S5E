using System.Collections.Generic;

namespace M2S5E1.Enteties
{
    internal class StarBussShip : StarShip
    {
        private int maxPassengers;
        private CelestialStars location;
        private CelestialStars destination;

        public StarBussShip(ShipClass ship, int maxHealthPoints, int currentHealthPoints, double maxVelocity,
                            int maxPassengers, CelestialStars location, CelestialStars destination) 
                            : base(ship, maxHealthPoints, currentHealthPoints, maxVelocity)
        {
            this.maxPassengers = maxPassengers;
            this.location = location;
            this.destination = destination;
        }

        //exercicie 6
        public void Travel()
        {
            CelestialStars returning = location;
            this.location = this.destination;
            this.destination = returning;
        }
    }
}

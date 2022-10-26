namespace M2S5E1.Enteties
{
    internal class StarGatherShip : StarShip
    {
        private int maxCargo;
        private int currentCargo;

        public StarGatherShip(ShipClass ship, int maxHealthPoints, int currentHealthPoints, double maxVelocity, int maxCargo, int currentCgargo) 
                              : base(ship, maxHealthPoints, currentHealthPoints, maxVelocity)
        {
            this.maxCargo = maxCargo;
            this.currentCargo = currentCgargo;
        }

        public bool Landing(CelestialStars star)
        {
            if (star is StarPlanets)
                return true;

            return false;
        }

        public void Collect(int quantity)
        {
            this.currentCargo += quantity;
        }

        private int CheckCargo(int quantity)
        {
            if (currentCargo < maxCargo)
                return maxCargo - this.currentCargo;
            return 0;
        }
    }
}

namespace M2S5E1.Enteties
{
    internal class StarGatherShip : StarShip
    {
        private int maxCargo;
        private int currentCargo;

        public int MaxCargo { get { return maxCargo; } }
        public int CurrentCargo { get { return currentCargo; } }

        public StarGatherShip(ShipClass ship, int maxHealthPoints, int currentHealthPoints, double maxVelocity, int maxCargo, int currentCgargo) 
                              : base(ship, maxHealthPoints, currentHealthPoints, maxVelocity)
        {
            this.maxCargo = maxCargo;
            this.currentCargo = currentCgargo;
        }

        public override bool IsOrbting(CelestialStars orbit)
        {
            if (orbit is Stars)
                return true;
            return false;
        }

        public bool Landing(CelestialStars star)
        {
            if (star is StarPlanets)
                return true;

            return false;
        }

        public void Collect(int quantity)
        {
            if (CheckCargo(quantity))
            {
                this.currentCargo += quantity;
            }
            else
            {
                Console.WriteLine("Limite de carga muito proximo inpossivel coletar");
            }
            
        }

        private bool CheckCargo(int quantity)
        {
            if (currentCargo + quantity < maxCargo)
                return true;
            return false;
        }
    }
}

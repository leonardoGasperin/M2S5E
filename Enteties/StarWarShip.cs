namespace M2S5E1.Enteties
{
    internal class StarWarShip : StarShip
    {
        private int damage;

        public StarWarShip(ShipClass ship, int maxHealthPoints, int currentHealthPoints, double maxVelocity, int damage)
                            : base(ship, maxHealthPoints, currentHealthPoints, maxVelocity)
        {
            this.damage = damage;
        }

        //exercicie 7
        public void Atack(StarShip target) 
        { 
            target.TakeDamage(damage);
        }
    }
}

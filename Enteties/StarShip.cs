﻿namespace M2S5E1.Enteties
{
    internal class StarShip
    {
        protected ShipClass ship;
        protected int maxHealthPoints;
        protected int currentHealthPoints;
        protected double maxVelocity;
        protected bool isActive;

        public StarShip(ShipClass ship, int maxHealthPoints, int currentHealthPoints, double maxVelocity)
        {
            this.ship = ship;
            this.maxHealthPoints = maxHealthPoints;
            this.currentHealthPoints = currentHealthPoints;
            this.maxVelocity = maxVelocity;
            this.isActive = true;
        }

        protected virtual bool isOrbting()
        {
            return false;
        }

        protected virtual CelestialStars DetectStar()
        {
            return new CelestialStars("teste", 1, 50, 95, 888);
        }

        public void TakeDamage(int damage)
        {
            this.currentHealthPoints -= damage;
            CheckIsActive();
        }

        public void CheckIsActive() 
        {
            int limitPercentageHP = (int)(maxHealthPoints * 0.20);
            if(this.currentHealthPoints < limitPercentageHP)
            {
                isActive = false;
            }
        }
    }
}

namespace M2S5E1.Enteties
{
    internal class StarPlanets : CelestialStars
    {
        private Dictionary<Resources, int> resources = new Dictionary<Resources, int>();
        private bool isHabitable = false;

        public StarPlanets(string name, double size, double mass, double gravity, int approximateAge, 
                           Dictionary<Resources, int> resources) : base(name, size, mass, gravity, approximateAge)
        {
            this.resources = resources;
        }

        public void LossResource(int quantity, Resources resource)
        {
           foreach(var item in resources)
            {
                if(item.Key.ToString() == resources.ToString())
                {
                    int valor = item.Value - quantity;
                    resources.Remove(item.Key);
                    resources.Add(resource, valor);
                    break;
                }
            }
        }
    }
}


namespace M2S5E1.Enteties
{
    internal class Stars : CelestialStars
    {
        private float averageTemperature;
        private double brightness;
        private StarClass classification;
        public Stars(string name, double size, double mass, double gravity, int approximateAge, float averageTemperature,
                     double brightness, StarClass classification) 
                    : base(name, size, mass, gravity, approximateAge) 
        {
            this.averageTemperature = averageTemperature;
            this.brightness = brightness;
            this.classification = classification; 
        }
    }
}

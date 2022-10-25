namespace M2S5E1.Enteties
{
	public class CelestialStars
	{
		protected string name;
		protected double size;
		protected double mass;
		protected double gravity;
		protected int approximateAge = 0;

		public CelestialStars(string name, double size, double mass, double gravity, int approximateAge)
		{
			this.name = name;
			this.size = size;
			this.mass = mass;
			this.gravity = gravity;
			this.approximateAge = approximateAge;
		}
	}
}
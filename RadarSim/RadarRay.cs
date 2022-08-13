using System;
using System.Drawing;

namespace RadarSim
{
	internal class RadarRay
	{
		public PointF RayCenter { get; } = new PointF();
		public PointF RayRadius { get; } = new PointF();

		public RadarRay()
		{

		}

		internal void Rotate(double v)
		{
			Console.WriteLine(v);
		}
	}
}
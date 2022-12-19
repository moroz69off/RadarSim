using System;
using System.Drawing;

namespace RadarSim
{
	internal class RadarRay
	{
		public PointF RayCenter { get; }
		public PointF RayEnd { get; set; }

		public RadarRay()
		{

		}

		internal void Rotate(double v)
		{
			Console.WriteLine(v);
		}
	}
}
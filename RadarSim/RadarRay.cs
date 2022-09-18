using System;
using System.Drawing;

namespace RadarSim
{
	internal class RadarRay
	{
		public PointF RayCenter { get; }
		public PointF RayRadius { get { return new PointF(); } set { RayRadius = value; }  }

		public RadarRay(PointF center)
		{
			RayCenter = center;
			RayRadius = new PointF(RayCenter.X + 10, RayCenter.Y + 10);
			RadarGraph GRAPH = new RadarGraph();
			GRAPH.graphics.DrawLine(GRAPH.penGreen, RayCenter, RayRadius);
		}

		internal void Rotate(double v)
		{
			Console.WriteLine(v);
		}
	}
}
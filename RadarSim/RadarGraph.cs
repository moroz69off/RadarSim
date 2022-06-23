using System;
using System.Drawing;
using System.Windows.Forms;

namespace RadarSim
{
	class RadarGraph
	{
		const int distanceStepsCount = 15;

		public float distanceStepSize;
		 public float radarRadius;

		Graphics graphics;
		Bitmap bitmap;
		Image image;

		public PointF centerPointF;

		public Pen penGreen = new Pen(Color.FromArgb(100, 0, 255, 0), 0.25F);

		public void InitGraphics(PictureBox pictureBox)
		{
			centerPointF.X = pictureBox.Width / 2;
			centerPointF.Y = pictureBox.Height / 2;
			distanceStepSize = (pictureBox.Height / 2) / 15;
			CalculateRadarGridRadius(pictureBox);
			bitmap = new Bitmap(pictureBox.Width + 1, pictureBox.Height + 1);
			pictureBox.Image = bitmap;
			graphics = Graphics.FromHwnd(pictureBox.Handle);
			graphics.Clear(Color.Black);
		}

		private void CalculateRadarGridRadius(PictureBox pictureBox)
		{
			radarRadius = pictureBox.Height / 2;
		}

		internal void DrawCircle(float xCenter, float yCenter, float radius)
		{
			graphics.DrawEllipse(penGreen, xCenter - radius, yCenter - radius, 2 * radius, 2 * radius);
		}

		internal void GetGraphics(PictureBox pictureBoxRadarSim)
		{
			CalculateRadarGridRadius(pictureBoxRadarSim);
			image = pictureBoxRadarSim.Image;
		}

		internal void DrawRadarGrid(PictureBox pictureBoxRadarSim)
		{
			for (int i = 1; i < distanceStepsCount; i++)
			{
				DrawCircle(centerPointF.X, centerPointF.Y, distanceStepSize * i);
			}
			// horizontale
			graphics.DrawLine(penGreen,
				centerPointF.X,
				centerPointF.Y + (distanceStepSize * (distanceStepsCount - 1)),
				centerPointF.X,
				centerPointF.Y - (distanceStepSize * (distanceStepsCount - 1)));
			// verticale
			graphics.DrawLine(penGreen,
				centerPointF.X + (distanceStepSize * (distanceStepsCount - 1)),
				centerPointF.Y,
				centerPointF.X - (distanceStepSize * (distanceStepsCount - 1)),
				centerPointF.Y);
			//
			graphics.DrawLine(penGreen,
				//
				centerPointF.X + (distanceStepSize * (distanceStepsCount - 1)),
				//
				centerPointF.Y - (distanceStepSize * (distanceStepsCount - 1)),
				//
				centerPointF.X - (distanceStepSize * (distanceStepsCount - 1)),
				//
				centerPointF.Y + (distanceStepSize * (distanceStepsCount - 1)));
			//
			graphics.DrawLine(penGreen,
				//
				centerPointF.X - (distanceStepSize * (distanceStepsCount - 1)),
				//
				centerPointF.Y - (distanceStepSize * (distanceStepsCount - 1)),
				//
				centerPointF.X + (distanceStepSize * (distanceStepsCount - 1)),
				//
				centerPointF.Y + (distanceStepSize * (distanceStepsCount - 1)));
		}
	}
}

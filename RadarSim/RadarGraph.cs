﻿using System;
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
			distanceStepSize = CalculateDistanceStepSize(pictureBox);
			CalculateRadarGridRadius(pictureBox);
			bitmap = new Bitmap(pictureBox.Width + 1, pictureBox.Height + 1);
			pictureBox.Image = bitmap;
			graphics = Graphics.FromHwnd(pictureBox.Handle);
			graphics.Clear(Color.Black);
		}

		internal void DrawCircle(float xCenter, float yCenter, float radius)
		{
			graphics.DrawEllipse(penGreen, xCenter - radius, yCenter - radius, 2 * radius, 2 * radius);
		}

		//internal void GetGraphics(PictureBox pictureBoxRadarSim)
		//{
		//	CalculateRadarGridRadius(pictureBoxRadarSim);
		//	image = pictureBoxRadarSim.Image;
		//}

		private void CalculateRadarGridRadius(PictureBox pictureBox)
		{
			if (pictureBox.Width >= pictureBox.Height)
				radarRadius = pictureBox.Height / 2;
			else
				radarRadius = pictureBox.Width / 2;
		}

		private float CalculateDistanceStepSize(PictureBox pb)
		{
			float stepSize = 0;
			if (pb.Width > pb.Height)
			{
				stepSize = (pb.Height / 2) / 15;
			}
			else
			{
				stepSize = (pb.Width / 2) / 15;
			}
			return stepSize;
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
				centerPointF.Y - (distanceStepSize * (distanceStepsCount - 1))
			);

			// verticale
			graphics.DrawLine(penGreen,
				centerPointF.X + (distanceStepSize * (distanceStepsCount - 1)),
				centerPointF.Y,
				centerPointF.X - (distanceStepSize * (distanceStepsCount - 1)),
				centerPointF.Y
			);

			// diagonale 1
			graphics.DrawLine(penGreen,
				(float)(centerPointF.X + (distanceStepSize * (distanceStepsCount - 1)) * Math.Sin(Math.PI / 4)),
				(float)(centerPointF.Y - (distanceStepSize * (distanceStepsCount - 1)) * Math.Sin(Math.PI / 4)),
				(float)(centerPointF.X - (distanceStepSize * (distanceStepsCount - 1)) * Math.Sin(Math.PI / 4)),
				(float)(centerPointF.Y + (distanceStepSize * (distanceStepsCount - 1)) * Math.Sin(Math.PI / 4))
			);

			// diagonale 2
			graphics.DrawLine(penGreen,
				(float)(centerPointF.X - (distanceStepSize * (distanceStepsCount - 1)) * Math.Sin(Math.PI / 4)),
				(float)(centerPointF.Y - (distanceStepSize * (distanceStepsCount - 1)) * Math.Sin(Math.PI / 4)),
				(float)(centerPointF.X + (distanceStepSize * (distanceStepsCount - 1)) * Math.Sin(Math.PI / 4)),
				(float)(centerPointF.Y + (distanceStepSize * (distanceStepsCount - 1)) * Math.Sin(Math.PI / 4))
			);
		}
	}
}

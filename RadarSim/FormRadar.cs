﻿using System;
using System.Windows.Forms;

namespace RadarSim
{
	public partial class FormRadar : Form
	{
		RadarGraph RADAR = new RadarGraph();
		RadarRay RAY = new RadarRay(new System.Drawing.PointF());

		public FormRadar()
		{
			InitializeComponent();
		}

		private void PictureBoxRadarSim_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			RADAR.ReDrawRaySimulator();
		}

		private void FormRadar_Resize(object sender, EventArgs e)
		{
			ReDrawRadarGrid();
		}

		private void ButtonAddTargets_Click(object sender, EventArgs e)
		{

		}

		private void pictureBoxRadarSim_Layout(object sender, LayoutEventArgs e)
		{

		}

		private void FormRadar_Load(object sender, EventArgs e)
		{

		}

		private void FormRadar_Shown(object sender, EventArgs e)
		{
			ReDrawRadarGrid();
		}

		private void FormRadar_VisibleChanged(object sender, EventArgs e)
		{
			ReDrawRadarGrid();
		}

		private void ReDrawRadarGrid()
		{
			RADAR.InitGraphics(pictureBoxRadarSim);
			pictureBoxRadarSim.Refresh();
			RADAR.GetGraphics(pictureBoxRadarSim);
			RADAR.DrawRadarGrid(pictureBoxRadarSim);
		}

	}
}

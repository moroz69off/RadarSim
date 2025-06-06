﻿using System;
using System.Windows.Forms;

namespace RadarSim
{
	public partial class FormRadar : Form
	{
		readonly RadarGraph RADAR = new RadarGraph();

		public FormRadar()
		{
			InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
		{
            RADAR.DrawRay();
            RADAR.DrawRadarGrid(pictureBoxRadarSim);
        }

        private void ButtonAddTargets_Click(object sender, EventArgs e)
		{

		}

		private void FormRadar_Shown(object sender, EventArgs e)
		{
			DrawRadarGrid();
		}

		private void FormRadar_VisibleChanged(object sender, EventArgs e)
		{
			DrawRadarGrid();
		}

		private void FormRadar_Resize(object sender, EventArgs e)
		{
			DrawRadarGrid();
		}

		private void DrawRadarGrid()
		{
			RADAR.InitGraphics(pictureBoxRadarSim);
			pictureBoxRadarSim.Refresh();
			//RADAR.DrawRadarGrid(pictureBoxRadarSim);
		}

	}
}

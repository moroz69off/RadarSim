using System;
using System.Windows.Forms;

namespace RadarSim
{
	public partial class FormRadar : Form
	{
		RadarGraph RADAR = new RadarGraph();

		public FormRadar()
		{
			InitializeComponent();
		}

		private void PictureBoxRadarSim_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Timer_Tick(object sender, EventArgs e)
		{

		}

		private void FormRadar_Resize(object sender, EventArgs e)
		{
			RADAR.InitGraphics(pictureBoxRadarSim);
			pictureBoxRadarSim.Refresh();
			RADAR.GetGraphics(pictureBoxRadarSim);
			RADAR.DrawRadarGrid(pictureBoxRadarSim);
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
			RADAR.InitGraphics(pictureBoxRadarSim);
			pictureBoxRadarSim.Refresh();
			RADAR.GetGraphics(pictureBoxRadarSim);
			RADAR.DrawRadarGrid(pictureBoxRadarSim);
		}
	}
}

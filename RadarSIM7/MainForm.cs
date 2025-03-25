using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadarSIM7
{
    public partial class MainForm : Form
    {
        float radarRadius = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {

        }

        private void CalculateRadarSize(int width, int height)
        {
            try
            {
                if (width > height)
                {
                    radarRadius = height - 20;
                }
                else
                {
                    radarRadius = width - 20;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            CalculateRadarSize(100, 100);
        }
    }
}

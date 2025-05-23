﻿using System;
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
        private float radarRadius = 0;
        private int widthRadar = 0;
        private int heightRadar = 0;

        RadarGraph RGr = new RadarGraph();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {

        }

        private float CalculateRadarSize(int width, int height)
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
            return radarRadius;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            widthRadar = MainForm.ActiveForm.Width;
            heightRadar = MainForm.ActiveForm.Height;
            radarRadius = CalculateRadarSize(widthRadar, heightRadar);
            RGr.DrawGrid(radarRadius);
        }
    }
}

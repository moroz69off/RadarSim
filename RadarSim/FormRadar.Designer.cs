﻿namespace RadarSim
{
    partial class FormRadar
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRadar));
            this.pictureBoxRadarSim = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonAddTargets = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRadarSim)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxRadarSim
            // 
            this.pictureBoxRadarSim.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBoxRadarSim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRadarSim.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRadarSim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxRadarSim.Name = "pictureBoxRadarSim";
            this.pictureBoxRadarSim.Size = new System.Drawing.Size(832, 641);
            this.pictureBoxRadarSim.TabIndex = 0;
            this.pictureBoxRadarSim.TabStop = false;
            this.pictureBoxRadarSim.Tag = "singlePictureBox";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 16;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // buttonAddTargets
            // 
            this.buttonAddTargets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddTargets.AutoSize = true;
            this.buttonAddTargets.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonAddTargets.FlatAppearance.BorderSize = 2;
            this.buttonAddTargets.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAddTargets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAddTargets.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAddTargets.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonAddTargets.Location = new System.Drawing.Point(688, 15);
            this.buttonAddTargets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddTargets.Name = "buttonAddTargets";
            this.buttonAddTargets.Size = new System.Drawing.Size(128, 37);
            this.buttonAddTargets.TabIndex = 1;
            this.buttonAddTargets.Text = "Add targets";
            this.buttonAddTargets.UseVisualStyleBackColor = true;
            this.buttonAddTargets.Click += new System.EventHandler(this.ButtonAddTargets_Click);
            // 
            // FormRadar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 641);
            this.Controls.Add(this.buttonAddTargets);
            this.Controls.Add(this.pictureBoxRadarSim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(847, 678);
            this.Name = "FormRadar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Radar";
            this.Shown += new System.EventHandler(this.FormRadar_Shown);
            this.VisibleChanged += new System.EventHandler(this.FormRadar_VisibleChanged);
            this.Resize += new System.EventHandler(this.FormRadar_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRadarSim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxRadarSim;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonAddTargets;
    }
}


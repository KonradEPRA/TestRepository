namespace WF_Colors
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_r_min = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_R_max = new System.Windows.Forms.TrackBar();
            this.tb_G_Max = new System.Windows.Forms.TrackBar();
            this.tb_G_Min = new System.Windows.Forms.TrackBar();
            this.tb_B_max = new System.Windows.Forms.TrackBar();
            this.tb_B_min = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tb_r_min)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_R_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_G_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_G_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_B_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_B_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_r_min
            // 
            this.tb_r_min.Location = new System.Drawing.Point(12, 3);
            this.tb_r_min.Maximum = 255;
            this.tb_r_min.Name = "tb_r_min";
            this.tb_r_min.Size = new System.Drawing.Size(806, 56);
            this.tb_r_min.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(830, 576);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.tb_B_max);
            this.panel1.Controls.Add(this.tb_B_min);
            this.panel1.Controls.Add(this.tb_G_Max);
            this.panel1.Controls.Add(this.tb_G_Min);
            this.panel1.Controls.Add(this.tb_R_max);
            this.panel1.Controls.Add(this.tb_r_min);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 288);
            this.panel1.TabIndex = 2;
            // 
            // tb_R_max
            // 
            this.tb_R_max.Location = new System.Drawing.Point(12, 43);
            this.tb_R_max.Maximum = 255;
            this.tb_R_max.Name = "tb_R_max";
            this.tb_R_max.Size = new System.Drawing.Size(791, 56);
            this.tb_R_max.TabIndex = 1;
            this.tb_R_max.Value = 255;
            // 
            // tb_G_Max
            // 
            this.tb_G_Max.Location = new System.Drawing.Point(12, 136);
            this.tb_G_Max.Maximum = 255;
            this.tb_G_Max.Name = "tb_G_Max";
            this.tb_G_Max.Size = new System.Drawing.Size(791, 56);
            this.tb_G_Max.TabIndex = 3;
            this.tb_G_Max.Value = 255;
            // 
            // tb_G_Min
            // 
            this.tb_G_Min.Location = new System.Drawing.Point(12, 96);
            this.tb_G_Min.Maximum = 255;
            this.tb_G_Min.Name = "tb_G_Min";
            this.tb_G_Min.Size = new System.Drawing.Size(806, 56);
            this.tb_G_Min.TabIndex = 2;
            // 
            // tb_B_max
            // 
            this.tb_B_max.Location = new System.Drawing.Point(12, 214);
            this.tb_B_max.Maximum = 255;
            this.tb_B_max.Name = "tb_B_max";
            this.tb_B_max.Size = new System.Drawing.Size(791, 56);
            this.tb_B_max.TabIndex = 5;
            this.tb_B_max.Value = 255;
            // 
            // tb_B_min
            // 
            this.tb_B_min.Location = new System.Drawing.Point(12, 174);
            this.tb_B_min.Maximum = 255;
            this.tb_B_min.Name = "tb_B_min";
            this.tb_B_min.Size = new System.Drawing.Size(806, 56);
            this.tb_B_min.TabIndex = 4;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 252);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(806, 56);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 576);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tb_r_min)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_R_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_G_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_G_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_B_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_B_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar tb_r_min;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar tb_R_max;
        private System.Windows.Forms.TrackBar tb_G_Max;
        private System.Windows.Forms.TrackBar tb_G_Min;
        private System.Windows.Forms.TrackBar tb_B_max;
        private System.Windows.Forms.TrackBar tb_B_min;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}


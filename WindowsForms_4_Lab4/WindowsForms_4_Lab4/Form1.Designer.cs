namespace WindowsForms_4_Lab4
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
            this.p_colors = new System.Windows.Forms.Panel();
            this.p_ustawienia = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tb_R_min = new System.Windows.Forms.TrackBar();
            this.tb_Red_max = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.p_ustawienia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_R_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Red_max)).BeginInit();
            this.SuspendLayout();
            // 
            // p_colors
            // 
            this.p_colors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_colors.Location = new System.Drawing.Point(0, 0);
            this.p_colors.Name = "p_colors";
            this.p_colors.Size = new System.Drawing.Size(800, 299);
            this.p_colors.TabIndex = 0;
            // 
            // p_ustawienia
            // 
            this.p_ustawienia.Controls.Add(this.label2);
            this.p_ustawienia.Controls.Add(this.tb_Red_max);
            this.p_ustawienia.Controls.Add(this.tb_R_min);
            this.p_ustawienia.Controls.Add(this.label1);
            this.p_ustawienia.Controls.Add(this.trackBar1);
            this.p_ustawienia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_ustawienia.Location = new System.Drawing.Point(0, 299);
            this.p_ustawienia.Name = "p_ustawienia";
            this.p_ustawienia.Size = new System.Drawing.Size(800, 151);
            this.p_ustawienia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prędkość";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(82, 6);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(718, 56);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tb_R_min
            // 
            this.tb_R_min.Location = new System.Drawing.Point(82, 44);
            this.tb_R_min.Name = "tb_R_min";
            this.tb_R_min.Size = new System.Drawing.Size(715, 56);
            this.tb_R_min.TabIndex = 2;
            // 
            // tb_Red_max
            // 
            this.tb_Red_max.Location = new System.Drawing.Point(82, 83);
            this.tb_Red_max.Maximum = 255;
            this.tb_Red_max.Name = "tb_Red_max";
            this.tb_Red_max.Size = new System.Drawing.Size(718, 56);
            this.tb_Red_max.TabIndex = 3;
            this.tb_Red_max.Value = 255;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 54);
            this.label2.TabIndex = 4;
            this.label2.Text = "R";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p_colors);
            this.Controls.Add(this.p_ustawienia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.p_ustawienia.ResumeLayout(false);
            this.p_ustawienia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_R_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Red_max)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_colors;
        private System.Windows.Forms.Panel p_ustawienia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar tb_Red_max;
        private System.Windows.Forms.TrackBar tb_R_min;
        private System.Windows.Forms.Label label2;
    }
}


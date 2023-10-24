namespace WindowsForms_Lab4_g
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
            this.p_settings = new System.Windows.Forms.Panel();
            this.p_colors = new System.Windows.Forms.Panel();
            this.tr_speed = new System.Windows.Forms.TrackBar();
            this.tr_columns = new System.Windows.Forms.TrackBar();
            this.tr_rows = new System.Windows.Forms.TrackBar();
            this.tr_R_min = new System.Windows.Forms.TrackBar();
            this.tr_R_max = new System.Windows.Forms.TrackBar();
            this.p_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tr_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr_columns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr_rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr_R_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr_R_max)).BeginInit();
            this.SuspendLayout();
            // 
            // p_settings
            // 
            this.p_settings.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.p_settings.Controls.Add(this.tr_R_max);
            this.p_settings.Controls.Add(this.tr_R_min);
            this.p_settings.Controls.Add(this.tr_rows);
            this.p_settings.Controls.Add(this.tr_columns);
            this.p_settings.Controls.Add(this.tr_speed);
            this.p_settings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_settings.Location = new System.Drawing.Point(0, 327);
            this.p_settings.Name = "p_settings";
            this.p_settings.Size = new System.Drawing.Size(800, 123);
            this.p_settings.TabIndex = 0;
            this.p_settings.Paint += new System.Windows.Forms.PaintEventHandler(this.p_settings_Paint);
            // 
            // p_colors
            // 
            this.p_colors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_colors.Location = new System.Drawing.Point(0, 0);
            this.p_colors.Name = "p_colors";
            this.p_colors.Size = new System.Drawing.Size(800, 327);
            this.p_colors.TabIndex = 1;
            this.p_colors.Resize += new System.EventHandler(this.p_colors_Resize);
            // 
            // tr_speed
            // 
            this.tr_speed.Location = new System.Drawing.Point(27, 7);
            this.tr_speed.Maximum = 2000;
            this.tr_speed.Minimum = 1;
            this.tr_speed.Name = "tr_speed";
            this.tr_speed.Size = new System.Drawing.Size(282, 56);
            this.tr_speed.TabIndex = 0;
            this.tr_speed.Value = 1;
            this.tr_speed.Scroll += new System.EventHandler(this.tr_speed_Scroll);
            // 
            // tr_columns
            // 
            this.tr_columns.Location = new System.Drawing.Point(27, 44);
            this.tr_columns.Maximum = 30;
            this.tr_columns.Name = "tr_columns";
            this.tr_columns.Size = new System.Drawing.Size(282, 56);
            this.tr_columns.TabIndex = 1;
            this.tr_columns.Value = 30;
            this.tr_columns.Scroll += new System.EventHandler(this.tr_columns_Scroll);
            // 
            // tr_rows
            // 
            this.tr_rows.Location = new System.Drawing.Point(27, 83);
            this.tr_rows.Maximum = 30;
            this.tr_rows.Name = "tr_rows";
            this.tr_rows.Size = new System.Drawing.Size(282, 56);
            this.tr_rows.TabIndex = 2;
            this.tr_rows.Scroll += new System.EventHandler(this.tr_rows_Scroll);
            // 
            // tr_R_min
            // 
            this.tr_R_min.Location = new System.Drawing.Point(367, 7);
            this.tr_R_min.Maximum = 255;
            this.tr_R_min.Name = "tr_R_min";
            this.tr_R_min.Size = new System.Drawing.Size(145, 56);
            this.tr_R_min.TabIndex = 3;
            // 
            // tr_R_max
            // 
            this.tr_R_max.Location = new System.Drawing.Point(367, 55);
            this.tr_R_max.Maximum = 255;
            this.tr_R_max.Name = "tr_R_max";
            this.tr_R_max.Size = new System.Drawing.Size(145, 56);
            this.tr_R_max.TabIndex = 4;
            this.tr_R_max.Value = 255;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p_colors);
            this.Controls.Add(this.p_settings);
            this.Name = "Form1";
            this.Text = "Form1";
            this.p_settings.ResumeLayout(false);
            this.p_settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tr_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr_columns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr_rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr_R_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr_R_max)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_settings;
        private System.Windows.Forms.Panel p_colors;
        private System.Windows.Forms.TrackBar tr_speed;
        private System.Windows.Forms.TrackBar tr_rows;
        private System.Windows.Forms.TrackBar tr_columns;
        private System.Windows.Forms.TrackBar tr_R_max;
        private System.Windows.Forms.TrackBar tr_R_min;
    }
}


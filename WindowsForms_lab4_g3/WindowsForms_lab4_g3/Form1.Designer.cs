namespace WindowsForms_lab4_g3
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
            this.label1 = new System.Windows.Forms.Label();
            this.p_settings = new System.Windows.Forms.Panel();
            this.p_colors = new System.Windows.Forms.Panel();
            this.tb_columns = new System.Windows.Forms.TrackBar();
            this.tb_rows = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_speed = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_R_min = new System.Windows.Forms.TrackBar();
            this.tb_R_max = new System.Windows.Forms.TrackBar();
            this.p_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_columns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_R_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_R_max)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(70, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 91);
            this.label1.TabIndex = 0;
            // 
            // p_settings
            // 
            this.p_settings.BackColor = System.Drawing.SystemColors.ControlDark;
            this.p_settings.Controls.Add(this.tb_R_max);
            this.p_settings.Controls.Add(this.tb_R_min);
            this.p_settings.Controls.Add(this.label4);
            this.p_settings.Controls.Add(this.tb_speed);
            this.p_settings.Controls.Add(this.label3);
            this.p_settings.Controls.Add(this.label2);
            this.p_settings.Controls.Add(this.tb_rows);
            this.p_settings.Controls.Add(this.tb_columns);
            this.p_settings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_settings.Location = new System.Drawing.Point(0, 291);
            this.p_settings.Name = "p_settings";
            this.p_settings.Size = new System.Drawing.Size(800, 159);
            this.p_settings.TabIndex = 1;
            // 
            // p_colors
            // 
            this.p_colors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_colors.Location = new System.Drawing.Point(0, 0);
            this.p_colors.Name = "p_colors";
            this.p_colors.Size = new System.Drawing.Size(800, 291);
            this.p_colors.TabIndex = 2;
            this.p_colors.Resize += new System.EventHandler(this.p_colors_Resize);
            // 
            // tb_columns
            // 
            this.tb_columns.Location = new System.Drawing.Point(28, 7);
            this.tb_columns.Maximum = 30;
            this.tb_columns.Minimum = 1;
            this.tb_columns.Name = "tb_columns";
            this.tb_columns.Size = new System.Drawing.Size(148, 56);
            this.tb_columns.TabIndex = 0;
            this.tb_columns.Value = 1;
            this.tb_columns.Scroll += new System.EventHandler(this.tb_columns_Scroll);
            // 
            // tb_rows
            // 
            this.tb_rows.Location = new System.Drawing.Point(28, 69);
            this.tb_rows.Maximum = 30;
            this.tb_rows.Minimum = 1;
            this.tb_rows.Name = "tb_rows";
            this.tb_rows.Size = new System.Drawing.Size(148, 56);
            this.tb_rows.TabIndex = 1;
            this.tb_rows.Value = 1;
            this.tb_rows.Scroll += new System.EventHandler(this.tb_rows_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "R";
            // 
            // tb_speed
            // 
            this.tb_speed.Location = new System.Drawing.Point(208, 7);
            this.tb_speed.Maximum = 1000;
            this.tb_speed.Minimum = 1;
            this.tb_speed.Name = "tb_speed";
            this.tb_speed.Size = new System.Drawing.Size(213, 56);
            this.tb_speed.TabIndex = 3;
            this.tb_speed.Value = 1;
            this.tb_speed.Scroll += new System.EventHandler(this.tb_speed_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(182, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "S";
            // 
            // tb_R_min
            // 
            this.tb_R_min.Location = new System.Drawing.Point(462, 7);
            this.tb_R_min.Maximum = 255;
            this.tb_R_min.Name = "tb_R_min";
            this.tb_R_min.Size = new System.Drawing.Size(126, 56);
            this.tb_R_min.TabIndex = 5;
            // 
            // tb_R_max
            // 
            this.tb_R_max.Location = new System.Drawing.Point(462, 66);
            this.tb_R_max.Maximum = 255;
            this.tb_R_max.Name = "tb_R_max";
            this.tb_R_max.Size = new System.Drawing.Size(126, 56);
            this.tb_R_max.TabIndex = 6;
            this.tb_R_max.Value = 255;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p_colors);
            this.Controls.Add(this.p_settings);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.p_settings.ResumeLayout(false);
            this.p_settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_columns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_R_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_R_max)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel p_settings;
        private System.Windows.Forms.Panel p_colors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tb_rows;
        private System.Windows.Forms.TrackBar tb_columns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tb_speed;
        private System.Windows.Forms.TrackBar tb_R_max;
        private System.Windows.Forms.TrackBar tb_R_min;
    }
}


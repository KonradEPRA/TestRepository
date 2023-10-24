namespace WindowsForms_Lab3
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
            this.bt_Zatwierdz = new System.Windows.Forms.Button();
            this.bt_anuluj = new System.Windows.Forms.Button();
            this.tb_Wiek = new System.Windows.Forms.TextBox();
            this.l_WIek = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Zatwierdz
            // 
            this.bt_Zatwierdz.Location = new System.Drawing.Point(126, 186);
            this.bt_Zatwierdz.Name = "bt_Zatwierdz";
            this.bt_Zatwierdz.Size = new System.Drawing.Size(204, 61);
            this.bt_Zatwierdz.TabIndex = 0;
            this.bt_Zatwierdz.Text = "button1";
            this.bt_Zatwierdz.UseVisualStyleBackColor = true;
            this.bt_Zatwierdz.Click += new System.EventHandler(this.bt_Zatwierdz_Click);
            this.bt_Zatwierdz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bt_Zatwierdz_MouseClick);
            // 
            // bt_anuluj
            // 
            this.bt_anuluj.Location = new System.Drawing.Point(458, 177);
            this.bt_anuluj.Name = "bt_anuluj";
            this.bt_anuluj.Size = new System.Drawing.Size(204, 61);
            this.bt_anuluj.TabIndex = 1;
            this.bt_anuluj.Text = "button2";
            this.bt_anuluj.UseVisualStyleBackColor = true;
            this.bt_anuluj.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bt_Zatwierdz_MouseClick);
            // 
            // tb_Wiek
            // 
            this.tb_Wiek.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_Wiek.Location = new System.Drawing.Point(250, 36);
            this.tb_Wiek.Name = "tb_Wiek";
            this.tb_Wiek.Size = new System.Drawing.Size(150, 38);
            this.tb_Wiek.TabIndex = 2;
            // 
            // l_WIek
            // 
            this.l_WIek.AutoSize = true;
            this.l_WIek.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_WIek.Location = new System.Drawing.Point(126, 36);
            this.l_WIek.Name = "l_WIek";
            this.l_WIek.Size = new System.Drawing.Size(77, 32);
            this.l_WIek.TabIndex = 3;
            this.l_WIek.Text = "Wiek";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(87, 315);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(499, 56);
            this.trackBar1.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(87, 378);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.l_WIek);
            this.Controls.Add(this.tb_Wiek);
            this.Controls.Add(this.bt_anuluj);
            this.Controls.Add(this.bt_Zatwierdz);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Zatwierdz;
        private System.Windows.Forms.Button bt_anuluj;
        private System.Windows.Forms.TextBox tb_Wiek;
        private System.Windows.Forms.Label l_WIek;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}


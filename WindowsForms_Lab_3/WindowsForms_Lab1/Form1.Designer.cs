namespace WindowsForms_Lab1
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
            this.bt_OK = new System.Windows.Forms.Button();
            this.bt_Anuluj = new System.Windows.Forms.Button();
            this.l_Imie = new System.Windows.Forms.Label();
            this.tb_Imie = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_OK
            // 
            this.bt_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_OK.Location = new System.Drawing.Point(158, 188);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(249, 124);
            this.bt_OK.TabIndex = 0;
            this.bt_OK.Text = "OK";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            this.bt_OK.MouseHover += new System.EventHandler(this.bt_OK_MouseHover);
            // 
            // bt_Anuluj
            // 
            this.bt_Anuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_Anuluj.Location = new System.Drawing.Point(422, 188);
            this.bt_Anuluj.Name = "bt_Anuluj";
            this.bt_Anuluj.Size = new System.Drawing.Size(366, 124);
            this.bt_Anuluj.TabIndex = 1;
            this.bt_Anuluj.Text = "Anuluj";
            this.bt_Anuluj.UseVisualStyleBackColor = true;
            this.bt_Anuluj.Click += new System.EventHandler(this.bt_OK_Click);
            this.bt_Anuluj.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bt_Anuluj_MouseMove);
            // 
            // l_Imie
            // 
            this.l_Imie.AutoSize = true;
            this.l_Imie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_Imie.Location = new System.Drawing.Point(12, 13);
            this.l_Imie.Name = "l_Imie";
            this.l_Imie.Size = new System.Drawing.Size(77, 32);
            this.l_Imie.TabIndex = 2;
            this.l_Imie.Text = "Wiek";
            // 
            // tb_Imie
            // 
            this.tb_Imie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_Imie.Location = new System.Drawing.Point(133, 7);
            this.tb_Imie.Name = "tb_Imie";
            this.tb_Imie.Size = new System.Drawing.Size(196, 38);
            this.tb_Imie.TabIndex = 3;
            this.tb_Imie.TextChanged += new System.EventHandler(this.tb_Imie_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(158, 355);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(586, 56);
            this.trackBar1.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(172, 399);
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
            this.Controls.Add(this.tb_Imie);
            this.Controls.Add(this.l_Imie);
            this.Controls.Add(this.bt_Anuluj);
            this.Controls.Add(this.bt_OK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Button bt_Anuluj;
        private System.Windows.Forms.Label l_Imie;
        private System.Windows.Forms.TextBox tb_Imie;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}


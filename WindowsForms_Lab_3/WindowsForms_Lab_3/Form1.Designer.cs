namespace WindowsForms_Lab_3
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
            this.bt_cansel = new System.Windows.Forms.Button();
            this.tb_Test = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_OK
            // 
            this.bt_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_OK.Location = new System.Drawing.Point(85, 50);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(297, 288);
            this.bt_OK.TabIndex = 0;
            this.bt_OK.Text = "button1";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            this.bt_OK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bt_OK_MouseClick);
            this.bt_OK.MouseEnter += new System.EventHandler(this.bt_OK_MouseEnter);
            this.bt_OK.MouseLeave += new System.EventHandler(this.bt_OK_MouseLeave);
            this.bt_OK.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bt_OK_MouseMove);
            // 
            // bt_cansel
            // 
            this.bt_cansel.Location = new System.Drawing.Point(446, 50);
            this.bt_cansel.Name = "bt_cansel";
            this.bt_cansel.Size = new System.Drawing.Size(280, 288);
            this.bt_cansel.TabIndex = 1;
            this.bt_cansel.Text = "button1";
            this.bt_cansel.UseVisualStyleBackColor = true;
            this.bt_cansel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bt_OK_MouseClick);
            this.bt_cansel.MouseEnter += new System.EventHandler(this.bt_OK_MouseEnter);
            this.bt_cansel.MouseLeave += new System.EventHandler(this.bt_OK_MouseLeave);
            // 
            // tb_Test
            // 
            this.tb_Test.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_Test.Location = new System.Drawing.Point(282, 354);
            this.tb_Test.Name = "tb_Test";
            this.tb_Test.Size = new System.Drawing.Size(100, 38);
            this.tb_Test.TabIndex = 2;
            this.tb_Test.TextChanged += new System.EventHandler(this.tb_Test_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(508, 357);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 56);
            this.trackBar1.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(695, 373);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(85, 399);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 20);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.tb_Test);
            this.Controls.Add(this.bt_cansel);
            this.Controls.Add(this.bt_OK);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Button bt_cansel;
        private System.Windows.Forms.TextBox tb_Test;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}


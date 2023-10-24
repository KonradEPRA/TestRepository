using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_4_Lab4
{
    public partial class Form1 : Form
    {
        Timer timer;
        int columns = 1;
        int rows=1;

        public Form1()
        {
            InitializeComponent();
            DoButtons();
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DoColors();
        }

        public void DoButtons()
        {
            int _w = this.p_colors.Width;
            int _h = this.p_colors.Height;

            this.p_colors.Controls.Clear();

            for (int i = 0; i < columns; i++) 
            {
                for (int j = 0; j < rows; j++)
                {
                    Panel button = new Panel();
                    button.Margin = new Padding(0);
                    button.Size = new System.Drawing.Size(_w/columns, _h/rows);
                    button.Location = new System.Drawing.Point(i * _w / columns, j * _h / rows);
                    this.p_colors.Controls.Add(button);
                }
            }
            DoColors();
        }

        private void DoColors()
        {
            Random random = new Random();

            foreach (Panel button in this.p_colors.Controls)
            {
                try
                {
                    button.BackColor = Color.FromArgb
                        (
                        random.Next(tb_R_min.Value, tb_Red_max.Value),
                        random.Next(255),
                        random.Next(255)
                        );
                }catch (Exception) { }
            }
        }
        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            DoButtons();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //timer.Interval = trackBar1.Value;
            rows = columns = trackBar1.Value;
            DoButtons();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Colors
{
    public partial class Form1 : Form
    {
        Timer timer;
        public Form1()
        {
            InitializeComponent();
            DoButtons();
            setColors();
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            setColors();
        }

        private void DoButtons()
        {
            for (int i = 0; i < 50; i++)
            {
                for(int j = 0; j < 50; j++)
                {
                    Panel button = new Panel();
                    button.Size = new Size(5, 5);
                    button.Margin = new Padding(0);
                    //button.Location = new Point(i*50, j*50);
                    flowLayoutPanel1.Controls.Add(button);
                }
            }
        }
        private void setColors()
        {
            Random random = new Random();
            foreach(Panel button in flowLayoutPanel1.Controls)
            {
                //if (random.Next(0, 10) == 0)
                {
                    try
                    {
                        button.BackColor = Color.FromArgb
                            (
                            //random.Next(255),
                            random.Next(tb_r_min.Value, tb_R_max.Value),
                            random.Next(tb_G_Min.Value, tb_G_Max.Value),
                            random.Next(tb_B_min.Value, tb_B_max.Value));
                    }
                    catch { }
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer.Interval = trackBar1.Value;
        }
    }
}

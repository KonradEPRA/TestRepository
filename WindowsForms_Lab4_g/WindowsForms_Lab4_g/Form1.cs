using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Lab4_g
{
    public partial class Form1 : Form
    {
        Timer timer;

        int column = 1;
        int row = 1;

        /// <summary>
        /// int time = 1;
        /// </summary>

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            timer.Start();

            DoPanels();
            DoColors();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DoColors();
        }

        private void DoPanels() 
        {
            int _w = this.p_colors.Width;
            int _h = this.p_colors.Height;

            this.p_colors.Controls.Clear();

            for(int i  = 0; i < column; i++)
            {
                for(int j = 0; j < row; j++) 
                {
                    Panel button = new Panel();
                    button.Margin = new Padding(0);
                    button.Size = new Size(_w/column, _h/row);
                    button.Location = new Point(i*_w/column, j*_h/row);
                    this.p_colors.Controls.Add(button);
                }
            }
        }

        private void DoColors()
        {
            Random random = new Random();

            foreach (Panel button in this.p_colors.Controls)
            {
                try
                {
                    button.BackColor = Color.FromArgb(
                        random.Next(tr_R_min.Value, tr_R_max.Value),
                        random.Next(255),
                        random.Next(255)
                        );
                }catch (Exception e) { }
            }
        }

        private void p_colors_Resize(object sender, EventArgs e)
        {
            DoPanels();
            DoColors();
        }

        private void tr_speed_Scroll(object sender, EventArgs e)
        {
            timer.Interval = tr_speed.Value;
        }

        private void tr_columns_Scroll(object sender, EventArgs e)
        {
            column = tr_columns.Value;
            DoPanels();
        }

        private void p_settings_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tr_rows_Scroll(object sender, EventArgs e)
        {
            row = tr_rows.Value;
            DoPanels();
        }
    }
}

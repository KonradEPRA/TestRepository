using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_lab4_g3
{
    public partial class Form1 : Form
    {
        Timer timer;
        int columns = 5;
        int rows = 5;

        public Form1()
        {
            InitializeComponent();
            DoPanels();
            DoColors();

            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DoColors();
        }

        /// <summary>
        /// Tworzy nowe butony na panelu 
        /// </summary>
        private void DoPanels()
        {
            int _w = this.p_colors.Width;
            int _h = this.p_colors.Height;

            this.p_colors.Controls.Clear();

            for (int i = 0; i < columns; i++) 
            {
                for(int j = 0; j < rows; j++) 
                {
                    Panel button = new Panel();
                    button.Margin = new Padding(0);
                    button.Size = new Size(_w / columns, _h / rows);
                    button.Location = new Point(i*_w/columns, j*_h/rows);
                    this.p_colors.Controls.Add(button);
                }
            }
            DoColors();
        }

        private void DoColors()
        {
            Random random = new Random();

            foreach(Panel button in this.p_colors.Controls)
            {
                try
                {
                    button.BackColor = Color.FromArgb
                        (
                        random.Next(tb_R_min.Value, tb_R_max.Value),
                        random.Next(255),
                        random.Next(255)
                        );
                }
                catch { }
            }
        }

        private void p_colors_Resize(object sender, EventArgs e)
        {
            DoPanels();
        }

        private void tb_columns_Scroll(object sender, EventArgs e)
        {
            columns = (int)tb_columns.Value;
            DoPanels();
        }

        private void tb_rows_Scroll(object sender, EventArgs e)
        {
            rows = (int)tb_rows.Value;
            DoPanels() ;
        }

        private void tb_speed_Scroll(object sender, EventArgs e)
        {
            timer.Interval = tb_speed.Value;
        }
    }
}

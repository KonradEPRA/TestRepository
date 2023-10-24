using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            tb_Test.Text = "OK";
            trackBar1.Value = 10;
            //checkBox1.Checked
            radioButton1.Checked = true;


            double _liczba = Convert.ToDouble("15");
        }

        private void bt_OK_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            //((Button)sender).Location = new Point(((Button)sender).Location.X + 10, ((Button)sender).Location.Y + 10);
        }

        private void bt_OK_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).Text = e.X.ToString()+" "+e.Y.ToString();  
        }

        private void bt_OK_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.LightBlue;
        }

        private void bt_OK_MouseClick(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = Color.Yellow;
        }

       
        private void tb_Test_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(((TextBox)sender).Text);
            }catch 
            {
                ((TextBox)sender).BackColor = Color.Red;

            }
        }
    }
}

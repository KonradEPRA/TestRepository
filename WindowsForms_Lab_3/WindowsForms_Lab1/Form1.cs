using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;

            bt_Anuluj.Text = tb_Imie.Text;

            //trackBar1.Value
            checkBox1.Checked= true;

            double _liczba = Convert.ToDouble("15");

           
        }

        private void bt_OK_MouseHover(object sender, EventArgs e)
        {

            
        }

        private void bt_Anuluj_MouseMove(object sender, MouseEventArgs e)
        {
            bt_Anuluj.Text = e.X.ToString()+" : "+e.Y.ToString();
        }

        private void tb_Imie_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(tb_Imie.Text);
                tb_Imie.BackColor = Color.White;
            }
            catch (Exception ex) 
            {
                tb_Imie.BackColor = Color.Red;
            }
        }
    }
}

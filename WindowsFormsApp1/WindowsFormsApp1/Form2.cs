using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            for( int i = 0; i < 10; i++ )
            {
                for( int j = 0; j < 10; j++ )
                {
                    Button button = new Button();
                    button.Size = new Size(50, 50);
                    button.BackColor = Color.Red;
                    button.Location = new System.Drawing.Point(i*50, j*50);
                    this.Controls.Add( button );
                }
            }
        }
    }
}

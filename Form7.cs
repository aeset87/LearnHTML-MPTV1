using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPTformVersion1
{
    public partial class Form7 : Form
    {
        int m = 0;
        public Form7()
        {

            InitializeComponent();
            
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            this.odgovor1.TabStop = false;
            this.odgovor2.TabStop = false;
            this.odgovor3.TabStop = false;
            this.odgovor4.TabStop = false;
        }
        private void odgovor1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (odgovor1.Checked == true)
            {
                m++;
                Form8 obj1 = new Form8(m);
                obj1.Show();
                this.Hide();
            }
            else
            {
                m = 0;
                var g = new greska();
                g.Show();
            }
        }
    }
}

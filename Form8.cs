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
    public partial class Form8 : Form
    {
        int m;
        public Form8(int n)
        {
            InitializeComponent();
            m = n;
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            this.odgovor1.TabStop = false;
            this.odgovor2.TabStop = false;
            this.odgovor3.TabStop = false;
            this.odgovor4.TabStop = false;
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (odgovor3.Checked == true)
            {
                m++;
                Form9 obj2 = new Form9(m);
                obj2.Show();
                this.Hide();
            }
            else
            {
                m = 0;
                var g = new greska();
                g.Show();
            }
        }

        private void odgovor3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form10 : Form
    {
        int m;
        public Form10(int p)
        {
            InitializeComponent();
            m = p;
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
            if (odgovor4.Checked == true)
            {
                m++;
                Form11 obj4 = new Form11(m);
                obj4.Show();
                this.Hide();
            }
            else
            {
                var g = new greska();
                g.Show();
            }
        }

        private void odgovor4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

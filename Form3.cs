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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void editor_TextChanged(object sender, EventArgs e)
        {
            browser.DocumentText = editor.Text;
        }
        int clickbutton1 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            clickbutton1++;
            if (clickbutton1 == 1)
            {
                html_instruction.Text = "Za poravnavanje teksta koristimo atribut align. \n" +
                    "Ako želimo centrirati prvi naslov, onda pišemo: <h1 align=\"center\">Ovo je naslov</h1>.\n" +
                    "Vrsta poravnanja: left (lijevo), center (centrirano), right (desno), justify (s obje strane).\n \n" +
                    "ZADATAK: Postaviti poravnanje za h1 i h2 naslove lijevo, h3 i h4 desno, a h5 i h6 centrirati. ";
                editor.Text = "<!DOCTYPE html>\n<html>\n" +
                               "        <head>\n" +
                               "                <meta charset=\"UTF-8\" />\n"+
                               "                <title>Početna stranica</title>\n"+
                               "        </head>\n" +
                               "        <body>\n" +
                               "                <h1>Ovo je naslov</h1>\n" +
                               "                <h2>Ovo je naslov</h2>\n" +
                               "                <h3>Ovo je naslov</h3>\n" +
                               "                <h4>Ovo je naslov</h4>\n" +
                               "                <h5>Ovo je naslov</h5>\n" +
                               "                <h6>Ovo je naslov</h6>\n" +
                               "        </body>\n" +
                               "</html>";
            }
            else if (clickbutton1 == 2)
            {
                button1.Text = "ZAVRŠI";
                html_instruction.Text = "U HTML dokumentu komentare pišemo između oznaka <!-- Komentar :) -->.";
                editor.Text = "<!DOCTYPE html>\n<html>\n" +
                               "        <head>\n" +
                               "                <meta charset=\"UTF-8\" />\n" +
                               "                <title>Početna stranica</title>\n" +
                               "        </head>\n" +
                               "        <body>\n" +
                               "<!--Ovo je komentar u html dokumentu-->\n" +
                               "                <h1 align=\"left\">Ovo je naslov</h1>\n" +
                               "                <h2 align=\"left\">Ovo je naslov</h2>\n" +
                               "                <h3 align=\"right\">Ovo je naslov</h3>\n" +
                               "                <h4 align=\"right\">Ovo je naslov</h4>\n" +
                               "                <h5 align=\"center\">Ovo je naslov</h5>\n" +
                               "                <h6 align=\"center\">Ovo je naslov</h6>\n" +
                               "        </body>\n" +
                               "</html>";
            }
            else
            {
                this.Close();
            }
        }
    }
}

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
    public partial class Form5 : Form
    {
        public Form5()
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
                html_instruction.Text = "U HTML dokument link dodajemo pomoću <a> tagova, i to <a href=\"url\">Tekst linka</a> \n";
                editor.Text = "<!DOCTYPE html>\n" +
                            "<html>\n" +
                            "   <head>\n" +
                            "       <meta charset=\"UTF-8\" />\n" +
                            "   </head>\n" +
                            "   <body>\n" +
                            "       <h1>Dodavanje linkova</h1>\n" +
                            "       <p>Za pretraživanje kliknite na <a href=\"http://www.google.ba\">link.</a> </p>\n" +
                            "   </body>\n" +
                            "</html>";
            }
            else if (clickbutton1 == 2)
            {
                button1.Text = "ZAVRŠI";
                editor.Text = "<!DOCTYPE html>\n" +
                            "<html>\n" +
                            "   <head>\n" +
                            "       <meta charset=\"UTF-8\" />\n" +
                            "   </head>\n" +
                            "   <body>\n" +
                            "       <h1>Ugrađivanje google mapa</h1>\n" +
                            "       <p>1. Otvorite <a href=\"http://www.google.ba\">google.</a> </p>\n" +
                            "   </body>\n" +
                            "</html>"; 
                html_instruction.Text = "ZADATAK: \n" +
                                            "1. Otvorite google. \n" +
                                            "2. U pretraživač upišite 'google maps'.\n" +
                                            "3. Nađite proizvoljnu lokaciju na mapama. \n" +
                                            "4. Odaberite opciju Share/Podijeli.\n" +
                                            "5. ZAtim odaberite opciju Embed map/Ugradi mapu.\n" +
                                            "6. Kopirajte link i zalijepite ga ispod <h1> taga.\n" +
                                            "7. Podesite visinu i širinu na 400 i 250.";
            }
            else
            {
                this.Close();
            }
        }
    }
}

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
    public partial class Form6 : Form
    {
        public Form6()
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
                html_instruction.Text = "U HTML dokument sliku dodajemo pomoću <img> tagova, i to <img src=\"smiley.gif\" alt=\"Smiley face\" height=\"42\" width=\"42\"> \n" +
                                        "U atributu src navodimo putanju do slike, atribut alt predstavlja alternativni tekst koji želimo da se prikaže ukoliko web preglednik ne učita sliku, a height i width predstavljaju visinu i širinu slike.";
                editor.Text = "<!DOCTYPE html>\n" +
                            "<html>\n" +
                            "   <head>\n" +
                            "       <meta charset=\"UTF-8\" />\n" +
                            "   </head>\n" +
                            "   <body>\n" +
                            "       <h1>Dodavanje slika</h1>\n" +
                            "       <img src=\"https://shop.universalorlando.com/images/L_4HOUSES_Accessories_Patches_HarryPotter_Accessories_GryffindorCrestPatch_1230054.JPG\" alt=\"Gryffindor\" width=\"150\" height=\"180\" />\n" +
                            "   </body>\n" +
                            "</html>";
            }
            else if (clickbutton1 == 2)
            {
                button1.Text = "ZAVRŠI";
                html_instruction.Text = "ZADATAK Dodati proizvoljnu sliku s računara.";
                editor.Text = "";
            }
            else
            {
                this.Close();
            }
        }
    }
}

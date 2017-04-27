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
    public partial class Form4 : Form
    {
        public Form4()
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
                html_instruction.Text = "Dosad znamo da su tagovi h1, h2, h3, h4, h5 i h6 koriste za definisanje naslova, od najvećeg do najmanjeg," +
                    "te da je p tag za definisanje paragrafa.\n \n" +
                    "Tag br pravi liniju razmaka u tekstu. \n" +
                    "Tag hr kreira horizontalnu liniju koja se najčešće koristi za vizuelno razdvajanje dijelova sadržaja. \n" +
                    "Tag blockquote se koristi za citiranje teksta.\n" +
                    "Tag div dijeli stranicu na sekcije (blokove).\n \n" +
                    "ZADATAK: Pogledati primjer u editoru i dodati ono što nedostaje. ";
                editor.Text = "<!DOCTYPE html>\n<html>\n" +
                               "        <head>\n" +
                               "                <meta charset=\"UTF-8\" />\n" +
                               "                <title>Početna stranica</title>\n" +
                               "        \n" +
                               "        <body>\n" +
                               "                <div>\n" +
                               "                    <h1>Lorem Ipsum\n" +
                               "                    <p>Postoje mnoge varijacije odlomaka iz Lorem Ipsum-a, ali većina je pretrpjela kojekakve promjene s dodanim humorom, ili nasumičnim riječima koje nikako tu ne spadaju. Ako trebate koristiti Lorem Ipsum, morate biti sigurni da tekst ne sadrži skrivene nepodobne riječi ili fraze.</p>\n" +
                               "                </div>\n" +
                               "                <hr />\n" +
                               "                <div>\n" +
                               "                    <blockquote cite=\"Meša Selimović\">Sve će proći. Ali, kakva je to utjeha? Proći će i radost, proći će i ljubav, proći će i život. Zar je nada u tome da sve prođe?</blockquote>\n" +                      
                               "                </div>\n" +
                               "        </body>\n" +
                               "</html>";
            }
            else if (clickbutton1 == 2)
            {
                button1.Text = "Završi";
                html_instruction.Text = "Tag <strong> služi za prikazivanje podebljanog teksta.  \n" +
                    "Tag <em> služi za prikazivanje italic teksta. \n" +
                    "Tag <code> služi za prikazivanje kompjuterskog koda. \n \n" +
                    "ZADATAK: Podebljati riječi ljubav, život i nada, a nakriviti Lorem Ipsum.";
                editor.Text= "<!DOCTYPE html>\n<html>\n" +
                               "        <head>\n" +
                               "                <meta charset=\"UTF-8\" />\n" +
                               "                <title>Početna stranica</title>\n" +
                               "        </head>\n" +
                               "        <body>\n" +
                               "                <div>\n" +
                               "                    <h1>Lorem Ipsum</h1>\n" +
                               "                    <p>Postoje mnoge varijacije odlomaka iz Lorem Ipsum-a, ali većina je pretrpjela kojekakve promjene s dodanim humorom, ili nasumičnim riječima koje nikako tu ne spadaju. Ako trebate koristiti Lorem Ipsum, morate biti sigurni da tekst ne sadrži skrivene nepodobne riječi ili fraze.</p>\n" +
                               "                </div>\n" +
                               "                <hr />\n" +
                               "                <div>\n" +
                               "                    <blockquote>Sve će proći. Ali, kakva je to utjeha? Proći će i radost, proći će i ljubav, proći će i život. Zar je nada u tome da sve prođe?</blockquote>\n" +
                               "                </div>\n" +
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

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
    public partial class Form2 : Form
    {
        public Form2()
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
                html_instruction.Text = "Napišite svoje ime između <p> i </p> tagova.";
                editor.Text = "<!DOCTYPE html>\n<html>\n        <head>\n        </head>\n        <body>\n                <p> </p>\n        </ " +
                "body>\n</html>";
            }
            else if (clickbutton1 == 2)
            {
                button1.Text = "ZAVRŠI";
                html_instruction.Text = "Interno, računari koirste binarne brojeve za reprezentaciju svih podataka i naredbi. Svaki karakter se u memoriji računara pohranjuje kao niz nula i jedinica. " +
                    "Predstavljanje karaktera sa binarnim brojevima se naziva enkodiranje. Način koji definiše kako se enkodiraju karakteri se nazvia šema enkodiranja (npr. UTF-8). " +
                    "U HTML-u je moguće da kažemo web serveru koju će šemu koristiti. To radimo pomoću naredbe <meta charset=\"UTF-8\" /> koju pišemo unutar HEAD dijela. \n" + 
                    "Vidimo da ovaj tag nema završnog taga. Ovakve tagove nazivamo samozatvarajući tagovi. Kod njih nije potrebno stavljati završni tag, zatvaramo ih dodavanje kose crte na njihovom kraju, kao na primjer tag <img /> s kojim ćemo se kasnije upoznati. \n \n " +
                    "U HEAD dijelu definišemo naslov stranice između <title> i </title> tagova. \n \n" + 
                    "ZADATAK: Napisati osnovnu strukturu HTML dokumenta, postaviti šemu enkodiranja na UTF-8, staviti proizvoljan naslov web stranice.";
                editor.Text = "";

                
            }
            else
            {
                this.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Dnes bude vasim ukolem vytvorit formularovou reprezentaci kalkulacky. Priblizny vzhled si nakreslime na tabuli
 * (Pokud jsem to nenakreslil, pripomente mi to prosim!)
 * Inspirujte se kalkulackou ve Windows.
 * Pozadovane prvky/funkcionality:
 * - Tlacitka pro kazde z cisel 0-9
 * - Tlacitka pro operace +, -, *, a /
 * - Tlacitko pro = (vypsani vysledku)
 * - Textbox, do ktereho se propisou cisla/operace pri stisku jejich tlacitek
 * - Textbox s vysledkem operace (mozne sloucit s predeslym, nechavam na vas)
 * - Tlacitko pro vymazani textu v textboxu s cisly a operaci
 * 
 * Volitelne prvky/funkcionality:
 * - Tlacitko pro mazani cisel a operaci v textboxu zprava vzdy po jednom znaku
 * - Pokud mam vypsany vysledek a hned po tom stisknu tlacitko nejake operace, vysledek se vezme jako prvni cislo a
 *   rovnou mohu po zadani operace zadat druhe cislo
 * - Moznost ulozeni vysledku do nekolika preddefinovanych labelu/neinteraktivnich textboxu (treba kombinaci comboboxu a tlacitka, kde
 *   v comboboxu vyberu do ktereho labelu/textboxu se mi to ulozi a tlacitkem provedu ulozeni)
 *   + pridat tlacitko pro kazdy label/neint. textbox, kterym ulozeny vysledek pouziju jako cislo do vypoctu
 * - Pridani mocnin/odmocnin atd. (napr. pomoci dalsich tlacitek, ktere rovnou misto daneho cisla daji jeho (popr. zaokrouhlenou) odmocninu apod.)
 * - Cokoliv dalsiho vas napadne! :)
 * 
 * Snazte se o to, aby byla kalkulacka v ramci moznosti hezka, a aby bylo jeji ovladani intuitivni a aby mel kazdy prvek v okne dobre vyuziti
 */

namespace CalculatorRevisited
{
    public partial class CalculatorRevisited : Form
    {
        public CalculatorRevisited()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox1.Text += 1;
            }
            else
            {
                textBox2.Text += 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            // coma
        }
        private void button11_Click(object sender, EventArgs e)
        {
            // plus
            textBox3.Text = "1";
            if (textBox1.Text == "")
            {
                if (textBox5.Text == "")
                {
                    textBox1.Text= "0";
                }
                else
                {
                    textBox1.Text = textBox5.Text.Remove(0, 2);
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //minus
        }
        private void button12_Click(object sender, EventArgs e)
        {
            // multiply
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // divide
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // equals
            
            if (int.TryParse(this.textBox3.Text, out int value))
            {
                switch (value)
                {
                    case 1:
                        textBox5.Text = ("= " + (Convert.ToInt64(textBox1.Text) + Convert.ToInt64(textBox2.Text))+ "\r\n");
                        break;
                    case 2:
                        textBox5.Text = ("= " + (Convert.ToInt64(textBox1.Text) - Convert.ToInt64(textBox2.Text)) + "\r\n");
                        break;
                }
                textBox4.Text += textBox1.Text + " " + textBox3.Text + " " + textBox2.Text + " " + textBox5.Text;
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            // C
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

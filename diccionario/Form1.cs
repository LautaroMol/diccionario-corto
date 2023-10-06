using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diccionario
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btntrad_Click(object sender, EventArgs e)
        {
            SortedList<string,string> diccio = new SortedList<string, string>
            {
                { "fish", "pescado" },
                { "planet", "planeta" },
                { "computer", "computadora" },
                { "cake", "torta" }
            };
            diccio["fish"] = "pescado";
            diccio["planet"] = "planeta";
            diccio["computer"] = "computadora";
            diccio["cake"] = "torta";
            string palabra = "";
            foreach (char pal in txtcons.Text) {
                
                if (pal.ToString() != " ") { palabra += pal.ToString(); }
                else {  palabra = "";
                    MessageBox.Show("las palabras validas son: fish, planet, computer, cake");
                    txtpal.Text += " ";
                }
                if (diccio.ContainsKey(palabra))
                {
                    txtpal.Text += diccio[palabra];
                } 
            }
        }
    }
}

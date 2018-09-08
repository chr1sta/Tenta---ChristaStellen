using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChristaStellen
{
    public partial class Form1 : Form
    {
        List<Biljett> biljettlista = new List<Biljett>(); //lista med objekt av klassen biljetter.
        Biljett aktuellbiljett = new Biljett();//objekt av klassen biljett, används för att navigera i listboxen.
        double biljetträkanren = 0; //biljetträknaren deklarerad och tilldelad värdet 0.

       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Läktare"); ///från tenta, julmaten.
            comboBox1.Items.Add("Loge");
            comboBox1.Items.Add("Parkett");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double antal = Convert.ToDouble(tbAntal.Text);
          
            if ( biljetträkanren <= 10 && antal <= 10 && (biljetträkanren + antal) <=10)
                //om biljetträknaren, antalet användaren fyller i och om biljetträknaren+antalet är mindre än eller lika med 10.
            {
                //skapa ett nytt objekt av klassen biljett.
                Biljett nyBiljett = new Biljett();

                nyBiljett.Antal = Convert.ToInt32(tbAntal.Text);

              
               
                biljetträkanren = biljetträkanren + antal;
                
                nyBiljett.Namn = comboBox1.Text; //från tenta Julmaten.


                //Hämta priserna och tilldela detta till biljettobjektets property "pris".
                if (comboBox1.Text == "Loge")
                {
                    double pris = antal * 1300;
                    nyBiljett.Pris = pris;

                }
                else if (comboBox1.Text == "Parkett")
                {
                    double pris = antal * 700;
                    nyBiljett.Pris = pris;

                }

                else
                {
                    double pris = antal * 350;
                    nyBiljett.Pris = pris;

                }



                biljettlista.Add(nyBiljett); //lägg till i biljettlistan.
                listBox1.DataSource = null;
                listBox1.DataSource = biljettlista;//läs in biljettlistan i listboxen.
                tbAntal.Clear();//rensa

            }

            else
            {//om det är mer än 10, felmeddelande.
                MessageBox.Show("Du kan inte köpa mer än 10 biljetter!");
            }

        }

        private void btnStartlista_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_3
{
    public partial class tbArtist : Form
    {
        List<Bidrag> bidragslista = new List<Bidrag>();//lista med objekt av klassen bidrag.
        int startnummer = 1;//startnummerräknare.
        Bidrag aktuelltbidrag = new Bidrag();//objekt av klassen bidrag, används för att navigera i listboxen.
       
        public tbArtist()
        {
            InitializeComponent();
        }

        private void tbArtist_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Engelska");//val i comboboxen, hämtad från Julmatstentan.
            comboBox1.Items.Add("Svenska");
        }

        private void btnLäggTill_Click(object sender, EventArgs e)
        {
            Bidrag nyttBidrag = new Bidrag();//skapa nytt objekt av klassen bidrag.
           
            nyttBidrag.Artist = textBoxArtist.Text;//sätt in värden från textboxarna.
            nyttBidrag.Sång = tbSång.Text;
            nyttBidrag.Land = tbLand.Text;
            nyttBidrag.Språk = comboBox1.Text;
            nyttBidrag.Startnummer = startnummer;//är första gången 1, se högst upp i form 1.
            nyttBidrag.Placering = 0;//är vid skapandet av ett nytt bidrag 0.
            nyttBidrag.Poäng = 0;

            bidragslista.Add(nyttBidrag);//lägg till den nya objektet i listan för bidrag.
            startnummer++;//räkna upp startnumret.
            
            listBox1.DataSource = null;
            listBox1.DataSource = bidragslista;//läs in listan.
            textBoxArtist.Clear();
            tbLand.Clear();//rensa.
            tbSång.Clear();
            

        }

        public int bidrag(int antalröster)//https://msdn.microsoft.com/en-us/library/system.math.round(v=vs.110).aspx#Round2_Example
        {
            foreach (Bidrag item in bidragslista)//gå igenom alla objekt i bidragslistan
            {
                if (antalröster == 0) //om man skickar in 0 som parameter.
                {
                    return aktuelltbidrag.Poäng = 1;//så ska aktuellt bidrag vara 1.
                    
                }
                break;
            }
            double antal = Convert.ToDouble(antalröster);
            double andel = antal/ 1500;//beräkning enligt formeln.
            
            double poäng = andel * 473;//beräkning enligt formeln.
         
          // slutgiltigPoäng = Math.Round(poäng);///får inte till den där jävla math.Round!!!
         
           // slutgiltigPoäng = Convert.ToInt32(poäng);
          
            return Convert.ToInt32(poäng);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktuelltbidrag = (Bidrag)(listBox1.SelectedItem);//det objekt av klassen bidrag som är valt i listboxen.
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            int antalröster = Convert.ToInt32(tbAntalRöster.Text);//användaren matar in antal röster.
            
            aktuelltbidrag.Poäng = bidrag(antalröster);//objetet av klassen bidrag som är valt i listboxen ska tilldelas 
                                                       //värdet som metoden skickar tillbaka under egenskapen "poäng"

           // bidragslista.Add(aktuelltbidrag);

            listBox1.DataSource = null;
            listBox1.DataSource = bidragslista;//läs in listan.
        }
    }
}

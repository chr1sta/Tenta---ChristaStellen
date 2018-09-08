using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semifinal
{
    public partial class Form1 : Form
    {
        List<string> slutfinalen = new List<string>(); //genemsam lista för semifinal 1 och 2.

        string[] Semifinal1 = new string[]{ "A Million Voices, 182p",
      "Rhythm Inside, 149p",
      "Goodbye to Yesterday, 105p",
      "Warrior, 98p",
      "De la capăt (All Over Again), 89p",
      "One Last Breath, 81p",
      "Face the Shadow, 77p",
      "Wars for Nothing, 67p",
      "Beauty Never Lies, 63p",
      "I'm Alive, 62p",
      "I Want Your Love, 41p",
      "Time, 39p",
      "The Way You Are, 33p",
      "Walk Along, 33p",
      "Autumn Leaves, 28p",
      "Aina mun pitää, 13p"
  };
        string[] Semifinal2 = new string[]{
    "Heroes, 217p",
    "Love Injected, 155p",
    "Golden boy, 151p",
    "A Monster Like Me, 123p",
    "Here for You, 92p",
    "One Thing That I Should Have Done, 87p",
    "This Time, 67p",
    "In the Name of Love, 57p",
    "Adio, 57p",
    "Hour of the Wolf, 53p",
    "Warrior, 43p",
    "Playing with Numbers, 35p",
    "Hope Never Dies, 33p",
    "Há um mar que nos separa, 19p",
    "Unbroken, 14p",
    "Chain Of Light, 11p"
};
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartlista_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)//börja på 0, så länge i är mindre än 10(array börjar på index 0), i ++.
            {
                slutfinalen.Add(Semifinal1[i]);//slutfinalens lista ska tilldelas samma värde som finns i arrayens index i,
                slutfinalen.Add(Semifinal2[i]);//dvs plats 0-9, sedan stannar loopen.
            }
            //slutfinalen.Sort();
            listBox2.DataSource = slutfinalen;//listboxen visar listan för slutfinalen.
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

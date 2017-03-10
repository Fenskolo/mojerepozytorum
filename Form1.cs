using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace nauka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] nazwy;
            nazwy = Directory.GetFiles(@"C:\Users\Tosia\Downloads");
            FileInfo plik;
            string nazwapliku;
            ListViewItem mm;
            string bez;
            decimal waga;
          //  ListView zz;

            int i;
            for (i = 0; i < nazwy.Length; i++)
            {
                plik = new FileInfo(nazwy[i]);
                nazwapliku = Path.GetFileNameWithoutExtension(nazwy[i]);
                    
                bez = plik.Extension;
                waga =Math.Round(Convert.ToDecimal(plik.Length) / 1048576,2);

                mm = new ListViewItem(new string[] { nazwapliku,waga.ToString(),bez });
                menadzer.Items.Add(mm);
            }
            
         //   for(i=0; i<nazwy.Length; i++)


          //      bez = plik.Extension;
               
           //     menadzer.Items[2].SubItems.Add("dupa");
                //menadzer.Items.Add(dysk);
                //menadzer.Items.Clear();
               
            
         //   menadzer.SelectedIndex = menadzer.Items.IndexOf("C:\\");
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Text = menadzer.SelectedItems[0].Text;
        }
    }
}

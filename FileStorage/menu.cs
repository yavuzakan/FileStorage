using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileStorage
{
    public partial class menu : Form
    {
        public static string yukle = ""; 
        public static string yukle2 = "";
        public menu()
        {
            InitializeComponent();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yukle = "GELEN EVRAK";
            dosyaYukle dosyaYukle = new dosyaYukle();
            dosyaYukle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yukle2 = "GELEN EVRAK";
            bilgiEkle b = new bilgiEkle();
            b.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            evrakAra evrak = new evrakAra();
            evrak.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            yukle = "GIDEN EVRAK";
            dosyaYukle dosyaYukle = new dosyaYukle();
            dosyaYukle.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            yukle2 = "GIDEN EVRAK";
            bilgiEkle b = new bilgiEkle();
            b.Show();
        }
    }
}

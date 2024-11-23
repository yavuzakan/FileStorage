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
    public partial class Menu2 : Form
    {
        public Menu2()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kulEkle k = new kulEkle();
            k.Show();

        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kulDuzenle k = new kulDuzenle();
            k.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dosyaYukle dosyaYukle = new dosyaYukle();
            dosyaYukle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
            evrakAraAdmin ev = new evrakAraAdmin();
            ev.Show();
        }
    }
}

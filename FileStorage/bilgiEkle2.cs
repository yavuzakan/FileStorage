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
    public partial class bilgiEkle2 : Form
    {
        public bilgiEkle2()
        {
            InitializeComponent();
            textBox1.Text = bilgiEkle.id2;
            textBox2.Text = bilgiEkle.dosya2;
            textBox9.Text = bilgiEkle.klasor2;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox9.Visible = false;
            label1.Text = "Evrak - Tarihi";
            label2.Text = "Evrak - Konusu";
            label3.Text = "Birim / Kuruluş";
            label4.Text = "Bilgi 4";
            label5.Text = "Bilgi 5";
            label6.Text = "Bilgi 6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string durum = DateTime.Now.ToString("dd/MM/yyy HH:mm:ss");
            data.evrakSayi(durum, id);
            data.evrakBilgi(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text,Form1.depart, durum ,textBox9.Text,menu.yukle2);
            MessageBox.Show("Tamam");
            this.Close();

        }
    }
}

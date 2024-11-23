using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileStorage
{
    public partial class dosyaYukle : Form
    {
        public static string sonuc = "Hata";
        public dosyaYukle()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void dosyaYukle_Load(object sender, EventArgs e)
        {

        }
        public void yukle2()
        {
            string klasor = DateTime.Now.ToString("yyyyMMddHHmmss");
            string tarih = DateTime.Now.ToString("dd/MM/yyy HH:mm:ss");
            string altdosya2 = textBox1.Text;
            string dosyaadi = System.IO.Path.GetFileName(altdosya2);
            //string asd = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string text = File.ReadAllText(@"folder.txt", Encoding.UTF8);
            System.IO.Directory.CreateDirectory(text + "\\folder\\" + klasor);
            string yol2 = text + "\\folder\\" + klasor + "\\" + dosyaadi;
            copyAll(altdosya2, yol2);
            data.evrakYukle(klasor, dosyaadi, tarih, Form1.mail,menu.yukle);
        }
        public void copyAll(string folder1, string folder2)
        {
            try
            {
                File.Copy(folder1, folder2, true);
                MessageBox.Show("Tamam");
                textBox1.Text = "";
            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message);
            }
        }
        public void knt()
        {
            int knt = textBox1.Text.Count();
            if (knt > 5)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            knt();
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog fbd = new OpenFileDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = fbd.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yukle2();
        }
    }
}

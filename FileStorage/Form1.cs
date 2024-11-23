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
    public partial class Form1 : Form
    {
        public static string userid = "";
        public static string mail = "";
        public static string sifre = "";
        public static string kadro = "";
        public static string ad = "";
        public static string depart = "";
        public static string data1 = "";
        public static string data2 = "";
        public Form1()
        {
            InitializeComponent();
            this.Text = "Dosya Takip";
            this.Icon = new Icon(Path.GetDirectoryName(Application.ExecutablePath) + "\\yca.ico");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            giris();
        }
        private void giris()
        {

            mail = textBox1.Text;

            //  public static string giris(String mail, String sifre)
            string log = "0";
            log = data.giris(textBox1.Text, textBox2.Text);
            if (log == "1")
            {
                if (Form1.kadro == "ADMIN")
                {
                    this.Hide();
                    Menu2 menu2 = new Menu2();
                    menu2.ShowDialog();
                    this.Close();
                }
                else
                { 
                this.Hide();
                menu menu = new menu();
                menu.ShowDialog();
                this.Close();
                }
            }
            else
            {
                MessageBox.Show("Hatalı Giriş.");
            }
            /*
             this.Hide();
             Menu menu = new Menu();
             menu.ShowDialog();
             this.Close();
            */
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                giris();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                giris();
            }
        }
    }
}

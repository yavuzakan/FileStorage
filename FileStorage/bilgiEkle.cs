using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileStorage
{
    public partial class bilgiEkle : Form
    {
        public static string id2 = "0";
        public static string dosya2 = "0";
        public static string tarih2 = "0";
        public static string klasor2 = "0";
        public bilgiEkle()
        {
            InitializeComponent();
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            //dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Arial", 15);
            ara();
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
        }
        public void ara()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            string stm = "select * FROM evrakYukle WHERE yukle LIKE '" + Form1.mail + "' and durum IS NULL and durum2  LIKE '"+menu.yukle2+"'";
            dataGridView1.Rows.Clear();
            var con = new SQLiteConnection(data.cs);
            SQLiteDataReader dr;
            con.Open();

            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetValue(0).ToString(), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3).ToString());
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ara();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = dataGridViewRow.Cells["id"].Value.ToString();
                textBox2.Text = dataGridViewRow.Cells["dosya"].Value.ToString();
                textBox3.Text = dataGridViewRow.Cells["tarih"].Value.ToString();
                textBox4.Text = dataGridViewRow.Cells["klasor"].Value.ToString();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id2 = textBox1.Text;
            dosya2 = textBox2.Text;
            tarih2 = textBox3.Text; 
            klasor2= textBox4.Text;

            if (e.RowIndex >= 0)
            {
                bilgiEkle2 d = new bilgiEkle2();
                d.Show();
            }
        }
    }
}

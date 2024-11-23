using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;

namespace FileStorage
{
    public partial class evrakAra : Form
    {
        public evrakAra()
        {
            InitializeComponent();
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            //dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Arial", 15);
        }

        private void evrakAra_Load(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arama = textBox1.Text;
            if (arama.Length >2)
            {
                ara();
            }
            else
            {
                MessageBox.Show("Arama 3 karakterden kısa olamaz");
            }
        }
        public void ara()
        {
            string arama = textBox1.Text;

            string stm = "select * FROM evrakBilgi WHERE info7 LIKE '" + Form1.depart + "' and (info1 LIKE '%"+arama+ "%' or info2 LIKE '%" + arama + "%' or info3 LIKE '%" + arama + "%'  or info4 LIKE '%" + arama + "%' or info5 LIKE '%" + arama + "%'  or info6 LIKE '%" + arama + "%' or evrakAd LIKE '%" + arama + "%')";
            dataGridView1.Rows.Clear();
            var con = new SQLiteConnection(data.cs);
            SQLiteDataReader dr;
            con.Open();

            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(12).ToString(),  dr.GetValue(3).ToString(),dr.GetValue(4).ToString(), dr.GetValue(5).ToString(), dr.GetValue(6).ToString(), dr.GetValue(7).ToString(), dr.GetValue(8).ToString(), dr.GetValue(10).ToString(), dr.GetValue(11).ToString());
            }
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string text = File.ReadAllText(@"folder.txt", Encoding.UTF8);
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];
                string dosya = dataGridViewRow.Cells["dosya"].Value.ToString();
                string klasor = dataGridViewRow.Cells["klasor"].Value.ToString();

                // çift \\ tek \ değiştirme
                StringBuilder builder = new StringBuilder(text);
                builder.Replace("\\\\", "\\");
                string y = builder.ToString();
                //

                textBox2.Text = y + "folder\\" + klasor + "\\" + dosya;
            }
            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];
                string folder1 = textBox2.Text;

                if (folder1.Length > 5)
                {
                    FolderBrowserDialog fbd = new FolderBrowserDialog();
                    if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        textBox2.Text = fbd.SelectedPath;
                        string dosyaadi = System.IO.Path.GetFileName(folder1);
                        string folder2 = textBox2.Text + "\\" + dosyaadi;
                        File.Copy(folder1, folder2, true);
                        Process.Start("explorer.exe", @textBox2.Text);
                    }
                }
            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message);
            }
        }
    }
}

﻿
namespace FileStorage
{
    partial class evrakAra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klasor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 59);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::FileStorage.Properties.Resources.search_line_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(971, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "ARA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(3, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1043, 29);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dosya,
            this.info10,
            this.info1,
            this.info2,
            this.info3,
            this.info4,
            this.info5,
            this.info6,
            this.info8,
            this.klasor});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 502);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(779, 357);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(97, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(779, 383);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(97, 20);
            this.textBox3.TabIndex = 4;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // dosya
            // 
            this.dosya.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dosya.HeaderText = "Evrak";
            this.dosya.Name = "dosya";
            this.dosya.Width = 60;
            // 
            // info10
            // 
            this.info10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.info10.HeaderText = "Gelen/Giden";
            this.info10.Name = "info10";
            this.info10.Width = 93;
            // 
            // info1
            // 
            this.info1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.info1.HeaderText = "Bilgi 1";
            this.info1.Name = "info1";
            this.info1.Width = 60;
            // 
            // info2
            // 
            this.info2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.info2.HeaderText = "Bilgi 2";
            this.info2.Name = "info2";
            this.info2.Width = 60;
            // 
            // info3
            // 
            this.info3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.info3.HeaderText = "Bilgi 3";
            this.info3.Name = "info3";
            this.info3.Width = 60;
            // 
            // info4
            // 
            this.info4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.info4.HeaderText = "Bilgi 4";
            this.info4.Name = "info4";
            this.info4.Width = 60;
            // 
            // info5
            // 
            this.info5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.info5.HeaderText = "Bilgi 5";
            this.info5.Name = "info5";
            this.info5.Width = 60;
            // 
            // info6
            // 
            this.info6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.info6.HeaderText = "Bilgi 6";
            this.info6.Name = "info6";
            this.info6.Width = 60;
            // 
            // info8
            // 
            this.info8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.info8.HeaderText = "Tarih";
            this.info8.Name = "info8";
            this.info8.Width = 56;
            // 
            // klasor
            // 
            this.klasor.HeaderText = "klasor";
            this.klasor.Name = "klasor";
            this.klasor.Visible = false;
            // 
            // evrakAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel1);
            this.Name = "evrakAra";
            this.Text = "evrakAra";
            this.Load += new System.EventHandler(this.evrakAra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosya;
        private System.Windows.Forms.DataGridViewTextBoxColumn info10;
        private System.Windows.Forms.DataGridViewTextBoxColumn info1;
        private System.Windows.Forms.DataGridViewTextBoxColumn info2;
        private System.Windows.Forms.DataGridViewTextBoxColumn info3;
        private System.Windows.Forms.DataGridViewTextBoxColumn info4;
        private System.Windows.Forms.DataGridViewTextBoxColumn info5;
        private System.Windows.Forms.DataGridViewTextBoxColumn info6;
        private System.Windows.Forms.DataGridViewTextBoxColumn info8;
        private System.Windows.Forms.DataGridViewTextBoxColumn klasor;
    }
}
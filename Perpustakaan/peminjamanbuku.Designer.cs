﻿namespace Perpustakaan
{
    partial class peminjamanbuku
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbnrp = new System.Windows.Forms.TextBox();
            this.tbkodebuku = new System.Windows.Forms.TextBox();
            this.btnpinjam = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.peminjamanBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peminjamanBukuTaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peminjamanCDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengembalianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyPeminjamanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(70, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peminjaman Buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(43, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NRP Peminjam :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(73, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "kode buku :";
            // 
            // tbnrp
            // 
            this.tbnrp.Location = new System.Drawing.Point(156, 84);
            this.tbnrp.Margin = new System.Windows.Forms.Padding(2);
            this.tbnrp.Name = "tbnrp";
            this.tbnrp.Size = new System.Drawing.Size(159, 20);
            this.tbnrp.TabIndex = 3;
            // 
            // tbkodebuku
            // 
            this.tbkodebuku.Location = new System.Drawing.Point(156, 106);
            this.tbkodebuku.Margin = new System.Windows.Forms.Padding(2);
            this.tbkodebuku.Name = "tbkodebuku";
            this.tbkodebuku.Size = new System.Drawing.Size(159, 20);
            this.tbkodebuku.TabIndex = 4;
            // 
            // btnpinjam
            // 
            this.btnpinjam.Location = new System.Drawing.Point(251, 130);
            this.btnpinjam.Margin = new System.Windows.Forms.Padding(2);
            this.btnpinjam.Name = "btnpinjam";
            this.btnpinjam.Size = new System.Drawing.Size(64, 27);
            this.btnpinjam.TabIndex = 5;
            this.btnpinjam.Text = "pinjam";
            this.btnpinjam.UseVisualStyleBackColor = true;
            this.btnpinjam.Click += new System.EventHandler(this.btnpinjam_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 161);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(683, 229);
            this.dataGridView1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peminjamanBukuToolStripMenuItem,
            this.peminjamanBukuTaToolStripMenuItem,
            this.peminjamanCDToolStripMenuItem,
            this.pengembalianToolStripMenuItem,
            this.historyPeminjamanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // peminjamanBukuToolStripMenuItem
            // 
            this.peminjamanBukuToolStripMenuItem.Name = "peminjamanBukuToolStripMenuItem";
            this.peminjamanBukuToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.peminjamanBukuToolStripMenuItem.Text = "peminjaman buku";
            this.peminjamanBukuToolStripMenuItem.Click += new System.EventHandler(this.peminjamanBukuToolStripMenuItem_Click);
            // 
            // peminjamanBukuTaToolStripMenuItem
            // 
            this.peminjamanBukuTaToolStripMenuItem.Name = "peminjamanBukuTaToolStripMenuItem";
            this.peminjamanBukuTaToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.peminjamanBukuTaToolStripMenuItem.Text = "peminjaman buku Ta";
            this.peminjamanBukuTaToolStripMenuItem.Click += new System.EventHandler(this.peminjamanBukuTaToolStripMenuItem_Click);
            // 
            // peminjamanCDToolStripMenuItem
            // 
            this.peminjamanCDToolStripMenuItem.Name = "peminjamanCDToolStripMenuItem";
            this.peminjamanCDToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.peminjamanCDToolStripMenuItem.Text = "peminjaman CD";
            // 
            // pengembalianToolStripMenuItem
            // 
            this.pengembalianToolStripMenuItem.Name = "pengembalianToolStripMenuItem";
            this.pengembalianToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.pengembalianToolStripMenuItem.Text = "pengembalian ";
            this.pengembalianToolStripMenuItem.Click += new System.EventHandler(this.pengembalianToolStripMenuItem_Click);
            // 
            // historyPeminjamanToolStripMenuItem
            // 
            this.historyPeminjamanToolStripMenuItem.Name = "historyPeminjamanToolStripMenuItem";
            this.historyPeminjamanToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.historyPeminjamanToolStripMenuItem.Text = "history peminjaman";
            // 
            // peminjamanbuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 468);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnpinjam);
            this.Controls.Add(this.tbkodebuku);
            this.Controls.Add(this.tbnrp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "peminjamanbuku";
            this.Text = "peminjamanbuku";
            this.Load += new System.EventHandler(this.peminjamanbuku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbnrp;
        private System.Windows.Forms.TextBox tbkodebuku;
        private System.Windows.Forms.Button btnpinjam;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem peminjamanBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peminjamanBukuTaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peminjamanCDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengembalianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyPeminjamanToolStripMenuItem;
    }
}
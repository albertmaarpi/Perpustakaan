namespace Perpustakaan
{
    partial class pencarianTA
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.judul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pengarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pembimbing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peminjam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haripinjam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harikembali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bukuTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.judul,
            this.pengarang,
            this.pembimbing,
            this.tahun,
            this.available,
            this.peminjam,
            this.haripinjam,
            this.harikembali});
            this.dataGridView1.Location = new System.Drawing.Point(12, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(846, 312);
            this.dataGridView1.TabIndex = 14;
            // 
            // judul
            // 
            this.judul.HeaderText = "judul";
            this.judul.Name = "judul";
            // 
            // pengarang
            // 
            this.pengarang.HeaderText = "pengarang";
            this.pengarang.Name = "pengarang";
            // 
            // pembimbing
            // 
            this.pembimbing.HeaderText = "pembimbing";
            this.pembimbing.Name = "pembimbing";
            // 
            // tahun
            // 
            this.tahun.HeaderText = "tahun";
            this.tahun.Name = "tahun";
            // 
            // available
            // 
            this.available.HeaderText = "available";
            this.available.Name = "available";
            // 
            // peminjam
            // 
            this.peminjam.HeaderText = "peminjam";
            this.peminjam.Name = "peminjam";
            // 
            // haripinjam
            // 
            this.haripinjam.HeaderText = "hari peminjaman";
            this.haripinjam.Name = "haripinjam";
            // 
            // harikembali
            // 
            this.harikembali.HeaderText = "hari pengembalian";
            this.harikembali.Name = "harikembali";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "judul",
            "pengarang",
            "pembimbing",
            "tahun terbit",
            "penguji",
            "co-pembimbing"});
            this.comboBox1.Location = new System.Drawing.Point(481, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(408, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "pada :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(96, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "pencarian :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 22);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(420, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "pencarian TA";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bukuToolStripMenuItem,
            this.bukuTAToolStripMenuItem,
            this.cDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bukuToolStripMenuItem
            // 
            this.bukuToolStripMenuItem.Name = "bukuToolStripMenuItem";
            this.bukuToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.bukuToolStripMenuItem.Text = "buku";
            // 
            // bukuTAToolStripMenuItem
            // 
            this.bukuTAToolStripMenuItem.Name = "bukuTAToolStripMenuItem";
            this.bukuTAToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.bukuTAToolStripMenuItem.Text = "buku TA";
            // 
            // cDToolStripMenuItem
            // 
            this.cDToolStripMenuItem.Name = "cDToolStripMenuItem";
            this.cDToolStripMenuItem.Size = new System.Drawing.Size(41, 24);
            this.cDToolStripMenuItem.Text = "CD";
            // 
            // pencarianTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 456);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "pencarianTA";
            this.Text = "pencarianTA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn judul;
        private System.Windows.Forms.DataGridViewTextBoxColumn pengarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn pembimbing;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahun;
        private System.Windows.Forms.DataGridViewTextBoxColumn available;
        private System.Windows.Forms.DataGridViewTextBoxColumn peminjam;
        private System.Windows.Forms.DataGridViewTextBoxColumn haripinjam;
        private System.Windows.Forms.DataGridViewTextBoxColumn harikembali;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bukuTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cDToolStripMenuItem;
    }
}
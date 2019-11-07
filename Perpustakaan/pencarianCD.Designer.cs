namespace Perpustakaan
{
    partial class pencarianCD
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
            this.btnsearch = new System.Windows.Forms.Button();
            this.cbkategori = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpencarian = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bukuTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(647, 110);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(85, 24);
            this.btnsearch.TabIndex = 20;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // cbkategori
            // 
            this.cbkategori.FormattingEnabled = true;
            this.cbkategori.Items.AddRange(new object[] {
            "judul",
            "pengarang",
            "tahun terbit"});
            this.cbkategori.Location = new System.Drawing.Point(454, 110);
            this.cbkategori.Name = "cbkategori";
            this.cbkategori.Size = new System.Drawing.Size(187, 24);
            this.cbkategori.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(381, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "pada :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(69, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "pencarian :";
            // 
            // tbpencarian
            // 
            this.tbpencarian.Location = new System.Drawing.Point(184, 106);
            this.tbpencarian.Name = "tbpencarian";
            this.tbpencarian.Size = new System.Drawing.Size(191, 22);
            this.tbpencarian.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(298, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 46);
            this.label1.TabIndex = 15;
            this.label1.Text = "pencarian CD";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(846, 312);
            this.dataGridView1.TabIndex = 23;
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
            this.menuStrip1.Size = new System.Drawing.Size(872, 28);
            this.menuStrip1.TabIndex = 24;
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
            // pencarianCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 553);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.cbkategori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbpencarian);
            this.Controls.Add(this.label1);
            this.Name = "pencarianCD";
            this.Text = "pencarianCD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.ComboBox cbkategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbpencarian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bukuTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cDToolStripMenuItem;
    }
}
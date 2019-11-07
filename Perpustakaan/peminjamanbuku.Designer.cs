namespace Perpustakaan
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
            this.tbsearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnbayar = new System.Windows.Forms.Button();
            this.btnperpanjang = new System.Windows.Forms.Button();
            this.btnkembalikan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbldenda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(94, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peminjaman Buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(57, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "NRP Peminjam :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(97, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "kode buku :";
            // 
            // tbnrp
            // 
            this.tbnrp.Location = new System.Drawing.Point(208, 103);
            this.tbnrp.Name = "tbnrp";
            this.tbnrp.Size = new System.Drawing.Size(211, 22);
            this.tbnrp.TabIndex = 3;
            // 
            // tbkodebuku
            // 
            this.tbkodebuku.Location = new System.Drawing.Point(208, 131);
            this.tbkodebuku.Name = "tbkodebuku";
            this.tbkodebuku.Size = new System.Drawing.Size(211, 22);
            this.tbkodebuku.TabIndex = 4;
            // 
            // btnpinjam
            // 
            this.btnpinjam.Location = new System.Drawing.Point(245, 159);
            this.btnpinjam.Name = "btnpinjam";
            this.btnpinjam.Size = new System.Drawing.Size(85, 33);
            this.btnpinjam.TabIndex = 5;
            this.btnpinjam.Text = "pinjam";
            this.btnpinjam.UseVisualStyleBackColor = true;
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(336, 159);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(83, 33);
            this.tbsearch.TabIndex = 6;
            this.tbsearch.Text = "search";
            this.tbsearch.UseVisualStyleBackColor = true;
            this.tbsearch.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(581, 282);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnbayar
            // 
            this.btnbayar.Location = new System.Drawing.Point(328, 496);
            this.btnbayar.Name = "btnbayar";
            this.btnbayar.Size = new System.Drawing.Size(110, 33);
            this.btnbayar.TabIndex = 8;
            this.btnbayar.Text = "telah dibayar";
            this.btnbayar.UseVisualStyleBackColor = true;
            // 
            // btnperpanjang
            // 
            this.btnperpanjang.Location = new System.Drawing.Point(444, 496);
            this.btnperpanjang.Name = "btnperpanjang";
            this.btnperpanjang.Size = new System.Drawing.Size(106, 33);
            this.btnperpanjang.TabIndex = 9;
            this.btnperpanjang.Text = "perpanjangan";
            this.btnperpanjang.UseVisualStyleBackColor = true;
            // 
            // btnkembalikan
            // 
            this.btnkembalikan.Location = new System.Drawing.Point(556, 496);
            this.btnkembalikan.Name = "btnkembalikan";
            this.btnkembalikan.Size = new System.Drawing.Size(87, 33);
            this.btnkembalikan.TabIndex = 10;
            this.btnkembalikan.Text = "kembalikan";
            this.btnkembalikan.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(57, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "denda :";
            // 
            // lbldenda
            // 
            this.lbldenda.AutoSize = true;
            this.lbldenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbldenda.Location = new System.Drawing.Point(141, 504);
            this.lbldenda.Name = "lbldenda";
            this.lbldenda.Size = new System.Drawing.Size(132, 25);
            this.lbldenda.TabIndex = 12;
            this.lbldenda.Text = "Rp.1xx.xxx,xx";
            // 
            // peminjamanbuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 576);
            this.Controls.Add(this.lbldenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnkembalikan);
            this.Controls.Add(this.btnperpanjang);
            this.Controls.Add(this.btnbayar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.btnpinjam);
            this.Controls.Add(this.tbkodebuku);
            this.Controls.Add(this.tbnrp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "peminjamanbuku";
            this.Text = "peminjamanbuku";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button tbsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnbayar;
        private System.Windows.Forms.Button btnperpanjang;
        private System.Windows.Forms.Button btnkembalikan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbldenda;
    }
}
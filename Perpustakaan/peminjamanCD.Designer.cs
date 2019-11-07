namespace Perpustakaan
{
    partial class peminjamanCD
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
            this.lbldenda = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnkembalikan = new System.Windows.Forms.Button();
            this.btnbayar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnpinjam = new System.Windows.Forms.Button();
            this.tbkode = new System.Windows.Forms.TextBox();
            this.tbnrp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnperpanjang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldenda
            // 
            this.lbldenda.AutoSize = true;
            this.lbldenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbldenda.Location = new System.Drawing.Point(118, 491);
            this.lbldenda.Name = "lbldenda";
            this.lbldenda.Size = new System.Drawing.Size(132, 25);
            this.lbldenda.TabIndex = 37;
            this.lbldenda.Text = "Rp.1xx.xxx,xx";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(34, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "denda :";
            // 
            // btnkembalikan
            // 
            this.btnkembalikan.Location = new System.Drawing.Point(533, 483);
            this.btnkembalikan.Name = "btnkembalikan";
            this.btnkembalikan.Size = new System.Drawing.Size(87, 33);
            this.btnkembalikan.TabIndex = 35;
            this.btnkembalikan.Text = "kembalikan";
            this.btnkembalikan.UseVisualStyleBackColor = true;
            // 
            // btnbayar
            // 
            this.btnbayar.Location = new System.Drawing.Point(305, 483);
            this.btnbayar.Name = "btnbayar";
            this.btnbayar.Size = new System.Drawing.Size(110, 33);
            this.btnbayar.TabIndex = 34;
            this.btnbayar.Text = "telah dibayar";
            this.btnbayar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(581, 282);
            this.dataGridView1.TabIndex = 33;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(313, 146);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(83, 33);
            this.btnsearch.TabIndex = 32;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // btnpinjam
            // 
            this.btnpinjam.Location = new System.Drawing.Point(222, 146);
            this.btnpinjam.Name = "btnpinjam";
            this.btnpinjam.Size = new System.Drawing.Size(85, 33);
            this.btnpinjam.TabIndex = 31;
            this.btnpinjam.Text = "pinjam";
            this.btnpinjam.UseVisualStyleBackColor = true;
            // 
            // tbkode
            // 
            this.tbkode.Location = new System.Drawing.Point(185, 118);
            this.tbkode.Name = "tbkode";
            this.tbkode.Size = new System.Drawing.Size(211, 22);
            this.tbkode.TabIndex = 30;
            // 
            // tbnrp
            // 
            this.tbnrp.Location = new System.Drawing.Point(185, 90);
            this.tbnrp.Name = "tbnrp";
            this.tbnrp.Size = new System.Drawing.Size(211, 22);
            this.tbnrp.TabIndex = 29;
            this.tbnrp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(88, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "kode CD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(34, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "NRP Peminjam :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(71, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 46);
            this.label1.TabIndex = 26;
            this.label1.Text = "Peminjaman CD";
            // 
            // btnperpanjang
            // 
            this.btnperpanjang.Location = new System.Drawing.Point(421, 483);
            this.btnperpanjang.Name = "btnperpanjang";
            this.btnperpanjang.Size = new System.Drawing.Size(106, 33);
            this.btnperpanjang.TabIndex = 38;
            this.btnperpanjang.Text = "perpanjangan";
            this.btnperpanjang.UseVisualStyleBackColor = true;
            // 
            // peminjamanCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 539);
            this.Controls.Add(this.btnperpanjang);
            this.Controls.Add(this.lbldenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnkembalikan);
            this.Controls.Add(this.btnbayar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnpinjam);
            this.Controls.Add(this.tbkode);
            this.Controls.Add(this.tbnrp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "peminjamanCD";
            this.Text = "peminjamanCD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnkembalikan;
        private System.Windows.Forms.Button btnbayar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnpinjam;
        private System.Windows.Forms.TextBox tbkode;
        private System.Windows.Forms.TextBox tbnrp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnperpanjang;
    }
}
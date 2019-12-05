namespace Perpustakaan
{
    partial class peminjamanTA
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
            this.btnkembali = new System.Windows.Forms.Button();
            this.btnbayar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnpinjam = new System.Windows.Forms.Button();
            this.tbkode = new System.Windows.Forms.TextBox();
            this.tbnrp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldenda
            // 
            this.lbldenda.AutoSize = true;
            this.lbldenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbldenda.Location = new System.Drawing.Point(110, 490);
            this.lbldenda.Name = "lbldenda";
            this.lbldenda.Size = new System.Drawing.Size(132, 25);
            this.lbldenda.TabIndex = 25;
            this.lbldenda.Text = "Rp.1xx.xxx,xx";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(26, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "denda :";
            // 
            // btnkembali
            // 
            this.btnkembali.Location = new System.Drawing.Point(525, 482);
            this.btnkembali.Name = "btnkembali";
            this.btnkembali.Size = new System.Drawing.Size(87, 33);
            this.btnkembali.TabIndex = 23;
            this.btnkembali.Text = "kembalikan";
            this.btnkembali.UseVisualStyleBackColor = true;
            // 
            // btnbayar
            // 
            this.btnbayar.Location = new System.Drawing.Point(409, 482);
            this.btnbayar.Name = "btnbayar";
            this.btnbayar.Size = new System.Drawing.Size(110, 33);
            this.btnbayar.TabIndex = 21;
            this.btnbayar.Text = "telah dibayar";
            this.btnbayar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(581, 282);
            this.dataGridView1.TabIndex = 20;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(305, 145);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(83, 33);
            this.btnsearch.TabIndex = 19;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnpinjam
            // 
            this.btnpinjam.Location = new System.Drawing.Point(214, 145);
            this.btnpinjam.Name = "btnpinjam";
            this.btnpinjam.Size = new System.Drawing.Size(85, 33);
            this.btnpinjam.TabIndex = 18;
            this.btnpinjam.Text = "pinjam";
            this.btnpinjam.UseVisualStyleBackColor = true;
            this.btnpinjam.Click += new System.EventHandler(this.btnpinjam_Click);
            // 
            // tbkode
            // 
            this.tbkode.Location = new System.Drawing.Point(177, 117);
            this.tbkode.Name = "tbkode";
            this.tbkode.Size = new System.Drawing.Size(211, 22);
            this.tbkode.TabIndex = 17;
            // 
            // tbnrp
            // 
            this.tbnrp.Location = new System.Drawing.Point(177, 89);
            this.tbnrp.Name = "tbnrp";
            this.tbnrp.Size = new System.Drawing.Size(211, 22);
            this.tbnrp.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(82, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "kode TA :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(26, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "NRP Peminjam :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(63, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "Peminjaman TA";
            // 
            // peminjamanTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 533);
            this.Controls.Add(this.lbldenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnkembali);
            this.Controls.Add(this.btnbayar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnpinjam);
            this.Controls.Add(this.tbkode);
            this.Controls.Add(this.tbnrp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "peminjamanTA";
            this.Text = "peminjamanTA";
            this.Load += new System.EventHandler(this.peminjamanTA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnkembali;
        private System.Windows.Forms.Button btnbayar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnpinjam;
        private System.Windows.Forms.TextBox tbkode;
        private System.Windows.Forms.TextBox tbnrp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
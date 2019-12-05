namespace Perpustakaan
{
    partial class formpengembalian
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
            this.tbnrp = new System.Windows.Forms.TextBox();
            this.btnkembalikanbuku = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lbdenda = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.cbkat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(73, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "pengembalian";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(75, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NRP :";
            // 
            // tbnrp
            // 
            this.tbnrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbnrp.Location = new System.Drawing.Point(127, 63);
            this.tbnrp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbnrp.Name = "tbnrp";
            this.tbnrp.Size = new System.Drawing.Size(158, 26);
            this.tbnrp.TabIndex = 2;
            // 
            // btnkembalikanbuku
            // 
            this.btnkembalikanbuku.Location = new System.Drawing.Point(549, 431);
            this.btnkembalikanbuku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnkembalikanbuku.Name = "btnkembalikanbuku";
            this.btnkembalikanbuku.Size = new System.Drawing.Size(96, 24);
            this.btnkembalikanbuku.TabIndex = 3;
            this.btnkembalikanbuku.Text = "kembalikan buku";
            this.btnkembalikanbuku.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(79, 105);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(566, 310);
            this.dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(79, 431);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "denda :";
            // 
            // lbdenda
            // 
            this.lbdenda.AutoSize = true;
            this.lbdenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbdenda.Location = new System.Drawing.Point(142, 431);
            this.lbdenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdenda.Name = "lbdenda";
            this.lbdenda.Size = new System.Drawing.Size(48, 20);
            this.lbdenda.TabIndex = 6;
            this.lbdenda.Text = "RP: 0";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(440, 63);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 24);
            this.btnsearch.TabIndex = 7;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // cbkat
            // 
            this.cbkat.FormattingEnabled = true;
            this.cbkat.Items.AddRange(new object[] {
            "Buku",
            "buku ta",
            "cd"});
            this.cbkat.Location = new System.Drawing.Point(301, 65);
            this.cbkat.Name = "cbkat";
            this.cbkat.Size = new System.Drawing.Size(121, 21);
            this.cbkat.TabIndex = 8;
            // 
            // formpengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 498);
            this.Controls.Add(this.cbkat);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.lbdenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnkembalikanbuku);
            this.Controls.Add(this.tbnrp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formpengembalian";
            this.Text = "formpengembalian";
            this.Load += new System.EventHandler(this.formpengembalian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbnrp;
        private System.Windows.Forms.Button btnkembalikanbuku;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbdenda;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.ComboBox cbkat;
    }
}
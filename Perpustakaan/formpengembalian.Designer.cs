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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(97, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "pengembalian";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(100, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "NRP :";
            // 
            // tbnrp
            // 
            this.tbnrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbnrp.Location = new System.Drawing.Point(169, 78);
            this.tbnrp.Name = "tbnrp";
            this.tbnrp.Size = new System.Drawing.Size(209, 30);
            this.tbnrp.TabIndex = 2;
            // 
            // btnkembalikanbuku
            // 
            this.btnkembalikanbuku.Location = new System.Drawing.Point(732, 531);
            this.btnkembalikanbuku.Name = "btnkembalikanbuku";
            this.btnkembalikanbuku.Size = new System.Drawing.Size(128, 30);
            this.btnkembalikanbuku.TabIndex = 3;
            this.btnkembalikanbuku.Text = "kembalikan buku";
            this.btnkembalikanbuku.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(105, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(755, 381);
            this.dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(105, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "denda :";
            // 
            // lbdenda
            // 
            this.lbdenda.AutoSize = true;
            this.lbdenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbdenda.Location = new System.Drawing.Point(189, 531);
            this.lbdenda.Name = "lbdenda";
            this.lbdenda.Size = new System.Drawing.Size(60, 25);
            this.lbdenda.TabIndex = 6;
            this.lbdenda.Text = "RP: 0";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(403, 78);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(100, 30);
            this.btnsearch.TabIndex = 7;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // formpengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 613);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.lbdenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnkembalikanbuku);
            this.Controls.Add(this.tbnrp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formpengembalian";
            this.Text = "formpengembalian";
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
    }
}
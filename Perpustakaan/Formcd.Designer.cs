namespace Perpustakaan
{
    partial class Formcd
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
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bukuTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(561, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(589, 103);
            this.dataGridView1.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(478, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "CD baru";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "CD";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bukuToolStripMenuItem,
            this.bukuTAToolStripMenuItem,
            this.cDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bukuToolStripMenuItem
            // 
            this.bukuToolStripMenuItem.Name = "bukuToolStripMenuItem";
            this.bukuToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.bukuToolStripMenuItem.Text = "Buku";
            // 
            // bukuTAToolStripMenuItem
            // 
            this.bukuTAToolStripMenuItem.Name = "bukuTAToolStripMenuItem";
            this.bukuTAToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.bukuTAToolStripMenuItem.Text = "Buku TA";
            // 
            // cDToolStripMenuItem
            // 
            this.cDToolStripMenuItem.Name = "cDToolStripMenuItem";
            this.cDToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.cDToolStripMenuItem.Text = "CD";
            // 
            // Formcd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Formcd";
            this.Text = "Formcd";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bukuTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cDToolStripMenuItem;
    }
}
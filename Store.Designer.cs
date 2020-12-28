namespace SimpleStorage
{
    partial class Store
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.продатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toAcceptedForm = new System.Windows.Forms.Button();
            this.toSoldForm = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 457);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Наименование";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Количество";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Цена за еденицу";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата поступления";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Стоимость";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ID";
            this.Column6.Name = "Column6";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.продатьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // продатьToolStripMenuItem
            // 
            this.продатьToolStripMenuItem.Name = "продатьToolStripMenuItem";
            this.продатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.продатьToolStripMenuItem.Text = "Продать";
            this.продатьToolStripMenuItem.Click += new System.EventHandler(this.продатьToolStripMenuItem_Click);
            // 
            // toAcceptedForm
            // 
            this.toAcceptedForm.Location = new System.Drawing.Point(510, 475);
            this.toAcceptedForm.Name = "toAcceptedForm";
            this.toAcceptedForm.Size = new System.Drawing.Size(146, 23);
            this.toAcceptedForm.TabIndex = 2;
            this.toAcceptedForm.Text = "Принято";
            this.toAcceptedForm.UseVisualStyleBackColor = true;
            this.toAcceptedForm.Click += new System.EventHandler(this.toAcceptedForm_Click);
            // 
            // toSoldForm
            // 
            this.toSoldForm.Location = new System.Drawing.Point(358, 475);
            this.toSoldForm.Name = "toSoldForm";
            this.toSoldForm.Size = new System.Drawing.Size(146, 23);
            this.toSoldForm.TabIndex = 3;
            this.toSoldForm.Text = "Продано";
            this.toSoldForm.UseVisualStyleBackColor = true;
            this.toSoldForm.Click += new System.EventHandler(this.toSoldForm_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(12, 475);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(221, 23);
            this.btnSell.TabIndex = 4;
            this.btnSell.Text = "Продать товар";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 505);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.toSoldForm);
            this.Controls.Add(this.toAcceptedForm);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Store_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button toAcceptedForm;
        private System.Windows.Forms.Button toSoldForm;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem продатьToolStripMenuItem;
    }
}
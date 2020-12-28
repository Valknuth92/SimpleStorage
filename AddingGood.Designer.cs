namespace SimpleStorage
{
    partial class AddingGood
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
            this.nameField = new System.Windows.Forms.TextBox();
            this.amountField = new System.Windows.Forms.TextBox();
            this.priceField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество едениц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена за еденицу";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(15, 25);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(118, 20);
            this.nameField.TabIndex = 3;
            // 
            // amountField
            // 
            this.amountField.Location = new System.Drawing.Point(152, 25);
            this.amountField.Name = "amountField";
            this.amountField.Size = new System.Drawing.Size(100, 20);
            this.amountField.TabIndex = 4;
            // 
            // priceField
            // 
            this.priceField.Location = new System.Drawing.Point(270, 25);
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(89, 20);
            this.priceField.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddingGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 58);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.priceField);
            this.Controls.Add(this.amountField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddingGood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление товара";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox amountField;
        private System.Windows.Forms.TextBox priceField;
        private System.Windows.Forms.Button button1;
    }
}
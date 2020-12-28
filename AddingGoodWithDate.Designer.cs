namespace SimpleStorage
{
    partial class AddingGoodWithDate
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
            this.button1 = new System.Windows.Forms.Button();
            this.priceField = new System.Windows.Forms.TextBox();
            this.amountField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // priceField
            // 
            this.priceField.Location = new System.Drawing.Point(269, 28);
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(89, 20);
            this.priceField.TabIndex = 12;
            // 
            // amountField
            // 
            this.amountField.Location = new System.Drawing.Point(151, 28);
            this.amountField.Name = "amountField";
            this.amountField.Size = new System.Drawing.Size(100, 20);
            this.amountField.TabIndex = 11;
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(14, 28);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(118, 20);
            this.nameField.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Цена за еденицу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Количество едениц";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Наименование товара";
            // 
            // dateField
            // 
            this.dateField.Location = new System.Drawing.Point(378, 28);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(98, 20);
            this.dateField.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Дата послупления";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "ДД ММ ГГГГ";
            // 
            // AddingGoodWithDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 68);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateField);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.priceField);
            this.Controls.Add(this.amountField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddingGoodWithDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление товара";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox priceField;
        private System.Windows.Forms.TextBox amountField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dateField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
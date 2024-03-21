namespace magicsquaregenerator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.magicSize = new System.Windows.Forms.TextBox();
            this.genBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // magicSize
            // 
            this.magicSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.magicSize.Location = new System.Drawing.Point(12, 12);
            this.magicSize.Name = "magicSize";
            this.magicSize.Size = new System.Drawing.Size(100, 20);
            this.magicSize.TabIndex = 0;
            this.magicSize.Text = "Enter your value";
            this.magicSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.magicSize.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // genBut
            // 
            this.genBut.Location = new System.Drawing.Point(22, 76);
            this.genBut.Name = "genBut";
            this.genBut.Size = new System.Drawing.Size(75, 23);
            this.genBut.TabIndex = 1;
            this.genBut.Text = "Generate!";
            this.genBut.UseVisualStyleBackColor = true;
            this.genBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(123, 119);
            this.Controls.Add(this.genBut);
            this.Controls.Add(this.magicSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox magicSize;
        private System.Windows.Forms.Button genBut;
    }
}


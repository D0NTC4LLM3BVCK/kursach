namespace magicsquaregenerator
{
    partial class reg
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
            this.regLog = new System.Windows.Forms.TextBox();
            this.regPswrd = new System.Windows.Forms.TextBox();
            this.makeReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regLog
            // 
            this.regLog.Location = new System.Drawing.Point(12, 12);
            this.regLog.Name = "regLog";
            this.regLog.Size = new System.Drawing.Size(233, 20);
            this.regLog.TabIndex = 0;
            // 
            // regPswrd
            // 
            this.regPswrd.Location = new System.Drawing.Point(12, 49);
            this.regPswrd.Name = "regPswrd";
            this.regPswrd.PasswordChar = '*';
            this.regPswrd.Size = new System.Drawing.Size(233, 20);
            this.regPswrd.TabIndex = 1;
            // 
            // makeReg
            // 
            this.makeReg.Location = new System.Drawing.Point(12, 89);
            this.makeReg.Name = "makeReg";
            this.makeReg.Size = new System.Drawing.Size(233, 23);
            this.makeReg.TabIndex = 2;
            this.makeReg.Text = "Зарегистрироваться";
            this.makeReg.UseVisualStyleBackColor = true;
            this.makeReg.Click += new System.EventHandler(this.makeReg_Click);
            // 
            // reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 133);
            this.Controls.Add(this.makeReg);
            this.Controls.Add(this.regPswrd);
            this.Controls.Add(this.regLog);
            this.Name = "reg";
            this.Text = "reg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox regLog;
        private System.Windows.Forms.TextBox regPswrd;
        private System.Windows.Forms.Button makeReg;
    }
}
namespace KararYapilari
{
    partial class Form2
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
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.txtDeger1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 284);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(282, 47);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "SATIŞ İŞLEMLERİ";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(12, 231);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(282, 47);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "MARKET KONTROLU";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(12, 178);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(282, 47);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "NOT KONTROLU";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 72);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(282, 47);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "GİRİŞ BİLGİSİ KONTROLU";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // txtDeger
            // 
            this.txtDeger.Location = new System.Drawing.Point(12, 12);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(282, 20);
            this.txtDeger.TabIndex = 4;
            // 
            // txtDeger1
            // 
            this.txtDeger1.Location = new System.Drawing.Point(12, 38);
            this.txtDeger1.Name = "txtDeger1";
            this.txtDeger1.Size = new System.Drawing.Size(282, 20);
            this.txtDeger1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "GİRİŞ BİLGİSİ KONTROLU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDeger1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtDeger);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtDeger;
        private System.Windows.Forms.TextBox txtDeger1;
        private System.Windows.Forms.Button button1;
    }
}
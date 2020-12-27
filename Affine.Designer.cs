namespace Şifreleme
{
    partial class Affine
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.decTxt = new System.Windows.Forms.TextBox();
            this.encTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MetinTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.akey = new System.Windows.Forms.TextBox();
            this.bkey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Şifrele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Çöz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Şifresiz Veri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifreli Veri:";
            // 
            // decTxt
            // 
            this.decTxt.Location = new System.Drawing.Point(176, 178);
            this.decTxt.Name = "decTxt";
            this.decTxt.Size = new System.Drawing.Size(205, 31);
            this.decTxt.TabIndex = 8;
            // 
            // encTxt
            // 
            this.encTxt.Location = new System.Drawing.Point(176, 224);
            this.encTxt.Name = "encTxt";
            this.encTxt.Size = new System.Drawing.Size(205, 31);
            this.encTxt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Şifrelenecek Veri:";
            // 
            // MetinTxt
            // 
            this.MetinTxt.Location = new System.Drawing.Point(176, 11);
            this.MetinTxt.Name = "MetinTxt";
            this.MetinTxt.Size = new System.Drawing.Size(180, 31);
            this.MetinTxt.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "A Anahtarı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "B Anahtarı:";
            // 
            // akey
            // 
            this.akey.Location = new System.Drawing.Point(176, 70);
            this.akey.Name = "akey";
            this.akey.Size = new System.Drawing.Size(100, 31);
            this.akey.TabIndex = 14;
            // 
            // bkey
            // 
            this.bkey.Location = new System.Drawing.Point(176, 109);
            this.bkey.Name = "bkey";
            this.bkey.Size = new System.Drawing.Size(100, 31);
            this.bkey.TabIndex = 15;
            // 
            // Affine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(461, 343);
            this.Controls.Add(this.bkey);
            this.Controls.Add(this.akey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MetinTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.encTxt);
            this.Controls.Add(this.decTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Affine";
            this.Text = "Affine";
            this.Load += new System.EventHandler(this.Affine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox decTxt;
        private System.Windows.Forms.TextBox encTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MetinTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox akey;
        private System.Windows.Forms.TextBox bkey;
    }
}
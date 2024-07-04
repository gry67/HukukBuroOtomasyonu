namespace GaziU.HukukBuroOtomasyonu
{
    partial class Giris
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
            avKimliklbl = new Label();
            avSifrelbl = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            girisBtn = new Button();
            SuspendLayout();
            // 
            // avKimliklbl
            // 
            avKimliklbl.AutoSize = true;
            avKimliklbl.Location = new Point(38, 114);
            avKimliklbl.Name = "avKimliklbl";
            avKimliklbl.Size = new Size(141, 20);
            avKimliklbl.TabIndex = 0;
            avKimliklbl.Text = "Avukat Tc Kimlik No";
            // 
            // avSifrelbl
            // 
            avSifrelbl.AutoSize = true;
            avSifrelbl.Location = new Point(91, 181);
            avSifrelbl.Name = "avSifrelbl";
            avSifrelbl.Size = new Size(88, 20);
            avSifrelbl.TabIndex = 1;
            avSifrelbl.Text = "Avukat Şifre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(185, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // girisBtn
            // 
            girisBtn.Location = new Point(194, 226);
            girisBtn.Name = "girisBtn";
            girisBtn.Size = new Size(94, 29);
            girisBtn.TabIndex = 4;
            girisBtn.Text = "Giriş";
            girisBtn.UseVisualStyleBackColor = true;
            girisBtn.Click += girisBtn_Click;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 318);
            Controls.Add(girisBtn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(avSifrelbl);
            Controls.Add(avKimliklbl);
            Name = "Giris";
            Text = "Giris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label avKimliklbl;
        private Label avSifrelbl;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button girisBtn;
    }
}
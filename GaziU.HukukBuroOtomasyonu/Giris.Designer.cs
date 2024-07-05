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
            avTcTxt = new TextBox();
            avSifreTxt = new TextBox();
            girisBtn = new Button();
            Kayitbtn = new Button();
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
            // avTcTxt
            // 
            avTcTxt.Location = new Point(185, 111);
            avTcTxt.Name = "avTcTxt";
            avTcTxt.Size = new Size(125, 27);
            avTcTxt.TabIndex = 2;
            // 
            // avSifreTxt
            // 
            avSifreTxt.Location = new Point(185, 174);
            avSifreTxt.Name = "avSifreTxt";
            avSifreTxt.PasswordChar = '*';
            avSifreTxt.Size = new Size(125, 27);
            avSifreTxt.TabIndex = 3;
            // 
            // girisBtn
            // 
            girisBtn.Location = new Point(185, 222);
            girisBtn.Name = "girisBtn";
            girisBtn.Size = new Size(94, 29);
            girisBtn.TabIndex = 4;
            girisBtn.Text = "Giriş";
            girisBtn.UseVisualStyleBackColor = true;
            girisBtn.Click += girisBtn_Click;
            // 
            // Kayitbtn
            // 
            Kayitbtn.Location = new Point(185, 257);
            Kayitbtn.Name = "Kayitbtn";
            Kayitbtn.Size = new Size(94, 29);
            Kayitbtn.TabIndex = 5;
            Kayitbtn.Text = "Kaydol";
            Kayitbtn.UseVisualStyleBackColor = true;
            Kayitbtn.Click += Kayitbtn_Click;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 318);
            Controls.Add(Kayitbtn);
            Controls.Add(girisBtn);
            Controls.Add(avSifreTxt);
            Controls.Add(avTcTxt);
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
        private TextBox avTcTxt;
        private TextBox avSifreTxt;
        private Button girisBtn;
        private Button Kayitbtn;
    }
}
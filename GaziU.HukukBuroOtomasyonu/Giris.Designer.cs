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
            label1 = new Label();
            SuspendLayout();
            // 
            // avKimliklbl
            // 
            avKimliklbl.AutoSize = true;
            avKimliklbl.Location = new Point(35, 106);
            avKimliklbl.Name = "avKimliklbl";
            avKimliklbl.Size = new Size(141, 20);
            avKimliklbl.TabIndex = 0;
            avKimliklbl.Text = "Avukat Tc Kimlik No";
            // 
            // avSifrelbl
            // 
            avSifrelbl.AutoSize = true;
            avSifrelbl.Location = new Point(88, 152);
            avSifrelbl.Name = "avSifrelbl";
            avSifrelbl.Size = new Size(88, 20);
            avSifrelbl.TabIndex = 1;
            avSifrelbl.Text = "Avukat Şifre";
            // 
            // avTcTxt
            // 
            avTcTxt.Location = new Point(182, 103);
            avTcTxt.Name = "avTcTxt";
            avTcTxt.Size = new Size(125, 27);
            avTcTxt.TabIndex = 2;
            // 
            // avSifreTxt
            // 
            avSifreTxt.Location = new Point(182, 145);
            avSifreTxt.Name = "avSifreTxt";
            avSifreTxt.PasswordChar = '*';
            avSifreTxt.Size = new Size(125, 27);
            avSifreTxt.TabIndex = 3;
            // 
            // girisBtn
            // 
            girisBtn.Location = new Point(182, 193);
            girisBtn.Name = "girisBtn";
            girisBtn.Size = new Size(94, 29);
            girisBtn.TabIndex = 4;
            girisBtn.Text = "Giriş";
            girisBtn.UseVisualStyleBackColor = true;
            girisBtn.Click += girisBtn_Click;
            // 
            // Kayitbtn
            // 
            Kayitbtn.Location = new Point(182, 228);
            Kayitbtn.Name = "Kayitbtn";
            Kayitbtn.Size = new Size(94, 29);
            Kayitbtn.TabIndex = 5;
            Kayitbtn.Text = "Kaydol";
            Kayitbtn.UseVisualStyleBackColor = true;
            Kayitbtn.Click += Kayitbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(116, 50);
            label1.Name = "label1";
            label1.Size = new Size(146, 35);
            label1.TabIndex = 6;
            label1.Text = "Giriş Ekranı";
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 277);
            Controls.Add(label1);
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
        private Label label1;
    }
}
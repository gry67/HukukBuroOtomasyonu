namespace GaziU.HukukBuroOtomasyonu
{
    partial class AvukatKayit
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
            label1 = new Label();
            label2 = new Label();
            avTcNotxt = new TextBox();
            avSifretxt = new TextBox();
            KayitBtn = new Button();
            label3 = new Label();
            avAdtxt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 115);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 0;
            label1.Text = "Avukat Tc Kimlik No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 160);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Avukat Şifre";
            // 
            // avTcNotxt
            // 
            avTcNotxt.Location = new Point(176, 112);
            avTcNotxt.Name = "avTcNotxt";
            avTcNotxt.Size = new Size(125, 27);
            avTcNotxt.TabIndex = 2;
            // 
            // avSifretxt
            // 
            avSifretxt.Location = new Point(176, 157);
            avSifretxt.Name = "avSifretxt";
            avSifretxt.Size = new Size(125, 27);
            avSifretxt.TabIndex = 3;
            // 
            // KayitBtn
            // 
            KayitBtn.Location = new Point(176, 203);
            KayitBtn.Name = "KayitBtn";
            KayitBtn.Size = new Size(94, 29);
            KayitBtn.TabIndex = 4;
            KayitBtn.Text = "Kaydol";
            KayitBtn.UseVisualStyleBackColor = true;
            KayitBtn.Click += KayitBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 73);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 5;
            label3.Text = "Avukat Adı";
            // 
            // avAdtxt
            // 
            avAdtxt.Location = new Point(176, 70);
            avAdtxt.Name = "avAdtxt";
            avAdtxt.Size = new Size(125, 27);
            avAdtxt.TabIndex = 6;
            // 
            // AvukatKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 243);
            Controls.Add(avAdtxt);
            Controls.Add(label3);
            Controls.Add(KayitBtn);
            Controls.Add(avSifretxt);
            Controls.Add(avTcNotxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AvukatKayit";
            Text = "AvukatKayit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox avTcNotxt;
        private TextBox avSifretxt;
        private Button KayitBtn;
        private Label label3;
        private TextBox avAdtxt;
    }
}
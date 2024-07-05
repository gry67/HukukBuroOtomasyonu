namespace GaziU.HukukBuroOtomasyonu
{
    partial class Davalar
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
            davalarList = new ListView();
            dosyaEkleBtn = new Button();
            YenileBtn = new Button();
            groupBox1 = new GroupBox();
            EsasNoLbl = new Label();
            EsasNoTxt = new TextBox();
            BulBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // davalarList
            // 
            davalarList.FullRowSelect = true;
            davalarList.Location = new Point(12, 154);
            davalarList.Name = "davalarList";
            davalarList.Size = new Size(1408, 357);
            davalarList.TabIndex = 0;
            davalarList.UseCompatibleStateImageBehavior = false;
            davalarList.View = View.Details;
            davalarList.SelectedIndexChanged += davalarList_SelectedIndexChanged;
            // 
            // dosyaEkleBtn
            // 
            dosyaEkleBtn.Location = new Point(249, 71);
            dosyaEkleBtn.Name = "dosyaEkleBtn";
            dosyaEkleBtn.Size = new Size(140, 29);
            dosyaEkleBtn.TabIndex = 1;
            dosyaEkleBtn.Text = "Dava Dosyası Ekle";
            dosyaEkleBtn.UseVisualStyleBackColor = true;
            dosyaEkleBtn.Click += dosyaEkleBtn_Click;
            // 
            // YenileBtn
            // 
            YenileBtn.Location = new Point(249, 119);
            YenileBtn.Name = "YenileBtn";
            YenileBtn.Size = new Size(94, 29);
            YenileBtn.TabIndex = 2;
            YenileBtn.Text = "Yenile";
            YenileBtn.UseVisualStyleBackColor = true;
            YenileBtn.Click += YenileBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BulBtn);
            groupBox1.Controls.Add(EsasNoTxt);
            groupBox1.Controls.Add(EsasNoLbl);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(214, 125);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Esas No'ya Göre Arama";
            // 
            // EsasNoLbl
            // 
            EsasNoLbl.AutoSize = true;
            EsasNoLbl.Location = new Point(6, 52);
            EsasNoLbl.Name = "EsasNoLbl";
            EsasNoLbl.Size = new Size(57, 20);
            EsasNoLbl.TabIndex = 0;
            EsasNoLbl.Text = "EsasNo";
            // 
            // EsasNoTxt
            // 
            EsasNoTxt.Location = new Point(69, 52);
            EsasNoTxt.Name = "EsasNoTxt";
            EsasNoTxt.Size = new Size(125, 27);
            EsasNoTxt.TabIndex = 1;
            // 
            // BulBtn
            // 
            BulBtn.Location = new Point(69, 85);
            BulBtn.Name = "BulBtn";
            BulBtn.Size = new Size(94, 29);
            BulBtn.TabIndex = 4;
            BulBtn.Text = "Bul";
            BulBtn.UseVisualStyleBackColor = true;
            BulBtn.Click += BulBtn_Click;
            // 
            // Davalar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1432, 558);
            Controls.Add(groupBox1);
            Controls.Add(YenileBtn);
            Controls.Add(dosyaEkleBtn);
            Controls.Add(davalarList);
            Name = "Davalar";
            Text = "Davalar";
            FormClosing += Davalar_FormClosing;
            Load += Davalar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView davalarList;
        private Button dosyaEkleBtn;
        private Button YenileBtn;
        private GroupBox groupBox1;
        private Button BulBtn;
        private TextBox EsasNoTxt;
        private Label EsasNoLbl;
    }
}
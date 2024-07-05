namespace GaziU.HukukBuroOtomasyonu
{
    partial class DurusmaEkle
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
            DurusmaYeriTxt = new TextBox();
            DurusmaTarihPick = new DateTimePicker();
            label2 = new Label();
            DurusmaEkleBtn = new Button();
            SilBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 59);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Duruşma Yeri";
            // 
            // DurusmaYeriTxt
            // 
            DurusmaYeriTxt.Location = new Point(122, 59);
            DurusmaYeriTxt.Multiline = true;
            DurusmaYeriTxt.Name = "DurusmaYeriTxt";
            DurusmaYeriTxt.Size = new Size(250, 65);
            DurusmaYeriTxt.TabIndex = 1;
            // 
            // DurusmaTarihPick
            // 
            DurusmaTarihPick.Location = new Point(122, 143);
            DurusmaTarihPick.Name = "DurusmaTarihPick";
            DurusmaTarihPick.Size = new Size(234, 27);
            DurusmaTarihPick.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 148);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 3;
            label2.Text = "Duruşma Tarihi";
            // 
            // DurusmaEkleBtn
            // 
            DurusmaEkleBtn.Location = new Point(122, 185);
            DurusmaEkleBtn.Name = "DurusmaEkleBtn";
            DurusmaEkleBtn.Size = new Size(116, 29);
            DurusmaEkleBtn.TabIndex = 4;
            DurusmaEkleBtn.Text = "Kaydet";
            DurusmaEkleBtn.UseVisualStyleBackColor = true;
            DurusmaEkleBtn.Click += DurusmaEkleBtn_Click;
            // 
            // SilBtn
            // 
            SilBtn.Location = new Point(244, 185);
            SilBtn.Name = "SilBtn";
            SilBtn.Size = new Size(112, 29);
            SilBtn.TabIndex = 5;
            SilBtn.Text = "Sil";
            SilBtn.UseVisualStyleBackColor = true;
            SilBtn.Click += SilBtn_Click;
            // 
            // DurusmaEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 240);
            Controls.Add(SilBtn);
            Controls.Add(DurusmaEkleBtn);
            Controls.Add(label2);
            Controls.Add(DurusmaTarihPick);
            Controls.Add(DurusmaYeriTxt);
            Controls.Add(label1);
            Name = "DurusmaEkle";
            Text = "DurusmaEkle";
            Load += DurusmaEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox DurusmaYeriTxt;
        private DateTimePicker DurusmaTarihPick;
        private Label label2;
        private Button DurusmaEkleBtn;
        private Button SilBtn;
    }
}
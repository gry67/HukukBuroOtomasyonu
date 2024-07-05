namespace GaziU.HukukBuroOtomasyonu
{
    partial class Durusmalar
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
            durusmaList = new ListView();
            YenileBtn = new Button();
            SuspendLayout();
            // 
            // durusmaList
            // 
            durusmaList.FullRowSelect = true;
            durusmaList.Location = new Point(12, 82);
            durusmaList.Name = "durusmaList";
            durusmaList.Size = new Size(535, 202);
            durusmaList.TabIndex = 0;
            durusmaList.UseCompatibleStateImageBehavior = false;
            durusmaList.View = View.Details;
            durusmaList.SelectedIndexChanged += durusmaList_SelectedIndexChanged;
            // 
            // YenileBtn
            // 
            YenileBtn.Location = new Point(12, 33);
            YenileBtn.Name = "YenileBtn";
            YenileBtn.Size = new Size(94, 29);
            YenileBtn.TabIndex = 1;
            YenileBtn.Text = "Yenile";
            YenileBtn.UseVisualStyleBackColor = true;
            YenileBtn.Click += YenileBtn_Click;
            // 
            // Durusmalar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 325);
            Controls.Add(YenileBtn);
            Controls.Add(durusmaList);
            Name = "Durusmalar";
            Text = "Durusmalar";
            Load += Durusmalar_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView durusmaList;
        private Button YenileBtn;
    }
}
namespace GaziU.HukukBuroOtomasyonu
{
    partial class ButunDurusmalar
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
            durusmalarList = new ListView();
            label1 = new Label();
            SuspendLayout();
            // 
            // durusmalarList
            // 
            durusmalarList.Location = new Point(12, 60);
            durusmalarList.Name = "durusmalarList";
            durusmalarList.Size = new Size(705, 203);
            durusmalarList.TabIndex = 0;
            durusmalarList.UseCompatibleStateImageBehavior = false;
            durusmalarList.View = View.Details;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(185, 28);
            label1.TabIndex = 1;
            label1.Text = "Bütün Duruşmalar";
            // 
            // ButunDurusmalar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 290);
            Controls.Add(label1);
            Controls.Add(durusmalarList);
            Name = "ButunDurusmalar";
            Text = "ButunDurusmalar";
            Load += ButunDurusmalar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView durusmalarList;
        private Label label1;
    }
}
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
            SuspendLayout();
            // 
            // davalarList
            // 
            davalarList.FullRowSelect = true;
            davalarList.Location = new Point(12, 154);
            davalarList.Name = "davalarList";
            davalarList.Size = new Size(981, 357);
            davalarList.TabIndex = 0;
            davalarList.UseCompatibleStateImageBehavior = false;
            davalarList.View = View.Details;
            davalarList.SelectedIndexChanged += davalarList_SelectedIndexChanged;
            // 
            // Davalar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 558);
            Controls.Add(davalarList);
            Name = "Davalar";
            Text = "Davalar";
            Load += Davalar_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView davalarList;
    }
}
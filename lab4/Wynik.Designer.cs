namespace Zadanie_04_Boguszewski_Dominik
{
    partial class Wynik
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
            this.Obraz = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Obraz)).BeginInit();
            this.SuspendLayout();
            // 
            // Obraz
            // 
            this.Obraz.Location = new System.Drawing.Point(94, 30);
            this.Obraz.Name = "Obraz";
            this.Obraz.Size = new System.Drawing.Size(598, 374);
            this.Obraz.TabIndex = 0;
            this.Obraz.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Wynik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Obraz);
            this.Name = "Wynik";
            this.Text = "Wynik";
            this.Load += new System.EventHandler(this.Wynik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Obraz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Obraz;
        private System.Windows.Forms.Label label1;
    }
}
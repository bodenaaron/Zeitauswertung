namespace Zeitauswertung
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_Bearbeiter = new System.Windows.Forms.ComboBox();
            this.lbl_bearbeiter = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_von = new System.Windows.Forms.Label();
            this.lbl_bis = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cmb_Bearbeiter
            // 
            this.cmb_Bearbeiter.FormattingEnabled = true;
            this.cmb_Bearbeiter.Location = new System.Drawing.Point(73, 6);
            this.cmb_Bearbeiter.Name = "cmb_Bearbeiter";
            this.cmb_Bearbeiter.Size = new System.Drawing.Size(200, 21);
            this.cmb_Bearbeiter.TabIndex = 0;
            // 
            // lbl_bearbeiter
            // 
            this.lbl_bearbeiter.AutoSize = true;
            this.lbl_bearbeiter.Location = new System.Drawing.Point(12, 9);
            this.lbl_bearbeiter.Name = "lbl_bearbeiter";
            this.lbl_bearbeiter.Size = new System.Drawing.Size(55, 13);
            this.lbl_bearbeiter.TabIndex = 1;
            this.lbl_bearbeiter.Text = "Bearbeiter";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(327, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lbl_von
            // 
            this.lbl_von.AutoSize = true;
            this.lbl_von.Location = new System.Drawing.Point(296, 9);
            this.lbl_von.Name = "lbl_von";
            this.lbl_von.Size = new System.Drawing.Size(25, 13);
            this.lbl_von.TabIndex = 3;
            this.lbl_von.Text = "von";
            // 
            // lbl_bis
            // 
            this.lbl_bis.AutoSize = true;
            this.lbl_bis.Location = new System.Drawing.Point(586, 9);
            this.lbl_bis.Name = "lbl_bis";
            this.lbl_bis.Size = new System.Drawing.Size(20, 13);
            this.lbl_bis.TabIndex = 5;
            this.lbl_bis.Text = "bis";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(612, 7);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 669);
            this.Controls.Add(this.lbl_bis);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lbl_von);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_bearbeiter);
            this.Controls.Add(this.cmb_Bearbeiter);
            this.Name = "MainForm";
            this.Text = "Zeitauswertung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Bearbeiter;
        private System.Windows.Forms.Label lbl_bearbeiter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_von;
        private System.Windows.Forms.Label lbl_bis;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}


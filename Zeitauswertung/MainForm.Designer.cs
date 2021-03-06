﻿namespace Zeitauswertung
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
            this.date_von = new System.Windows.Forms.DateTimePicker();
            this.lbl_von = new System.Windows.Forms.Label();
            this.lbl_bis = new System.Windows.Forms.Label();
            this.date_bis = new System.Windows.Forms.DateTimePicker();
            this.btn_suchen = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.lbl_gesamtstunden = new System.Windows.Forms.Label();
            this.tb_gesamtstunden = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
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
            // date_von
            // 
            this.date_von.Location = new System.Drawing.Point(327, 7);
            this.date_von.Name = "date_von";
            this.date_von.Size = new System.Drawing.Size(200, 20);
            this.date_von.TabIndex = 2;
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
            // date_bis
            // 
            this.date_bis.Location = new System.Drawing.Point(612, 7);
            this.date_bis.Name = "date_bis";
            this.date_bis.Size = new System.Drawing.Size(200, 20);
            this.date_bis.TabIndex = 4;
            // 
            // btn_suchen
            // 
            this.btn_suchen.Location = new System.Drawing.Point(830, 7);
            this.btn_suchen.Name = "btn_suchen";
            this.btn_suchen.Size = new System.Drawing.Size(109, 23);
            this.btn_suchen.TabIndex = 6;
            this.btn_suchen.Text = "suchen";
            this.btn_suchen.UseVisualStyleBackColor = true;
            this.btn_suchen.Click += new System.EventHandler(this.btn_suchen_Click);
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(8, 68);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.Size = new System.Drawing.Size(1131, 589);
            this.table.TabIndex = 7;
            // 
            // lbl_gesamtstunden
            // 
            this.lbl_gesamtstunden.AutoSize = true;
            this.lbl_gesamtstunden.Location = new System.Drawing.Point(14, 43);
            this.lbl_gesamtstunden.Name = "lbl_gesamtstunden";
            this.lbl_gesamtstunden.Size = new System.Drawing.Size(138, 13);
            this.lbl_gesamtstunden.TabIndex = 8;
            this.lbl_gesamtstunden.Text = "Gesamtstunden im Zeitraum";
            // 
            // tb_gesamtstunden
            // 
            this.tb_gesamtstunden.Enabled = false;
            this.tb_gesamtstunden.Location = new System.Drawing.Point(159, 43);
            this.tb_gesamtstunden.Name = "tb_gesamtstunden";
            this.tb_gesamtstunden.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_gesamtstunden.Size = new System.Drawing.Size(70, 20);
            this.tb_gesamtstunden.TabIndex = 9;
            this.tb_gesamtstunden.Text = "0";
            this.tb_gesamtstunden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 669);
            this.Controls.Add(this.tb_gesamtstunden);
            this.Controls.Add(this.lbl_gesamtstunden);
            this.Controls.Add(this.table);
            this.Controls.Add(this.btn_suchen);
            this.Controls.Add(this.lbl_bis);
            this.Controls.Add(this.date_bis);
            this.Controls.Add(this.lbl_von);
            this.Controls.Add(this.date_von);
            this.Controls.Add(this.lbl_bearbeiter);
            this.Controls.Add(this.cmb_Bearbeiter);
            this.Name = "MainForm";
            this.Text = "Zeitauswertung";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Bearbeiter;
        private System.Windows.Forms.Label lbl_bearbeiter;
        private System.Windows.Forms.DateTimePicker date_von;
        private System.Windows.Forms.Label lbl_von;
        private System.Windows.Forms.Label lbl_bis;
        private System.Windows.Forms.DateTimePicker date_bis;
        private System.Windows.Forms.Button btn_suchen;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Label lbl_gesamtstunden;
        public System.Windows.Forms.TextBox tb_gesamtstunden;
    }
}


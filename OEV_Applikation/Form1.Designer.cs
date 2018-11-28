namespace OEV_Applikation
{
    partial class Form1
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
            this.txtStartstation = new System.Windows.Forms.TextBox();
            this.LbStartstation = new System.Windows.Forms.Label();
            this.LbEndstation = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.LbDatum = new System.Windows.Forms.Label();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.btnAuswahlDelete = new System.Windows.Forms.Button();
            this.txtEndstation = new System.Windows.Forms.TextBox();
            this.lstAusgabe = new System.Windows.Forms.ListBox();
            this.lstStartstation = new System.Windows.Forms.ListBox();
            this.lstEndstation = new System.Windows.Forms.ListBox();
            this.btnVorschlaege = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStartstation
            // 
            this.txtStartstation.Location = new System.Drawing.Point(64, 67);
            this.txtStartstation.Name = "txtStartstation";
            this.txtStartstation.Size = new System.Drawing.Size(267, 22);
            this.txtStartstation.TabIndex = 0;
            // 
            // LbStartstation
            // 
            this.LbStartstation.AutoSize = true;
            this.LbStartstation.Location = new System.Drawing.Point(64, 44);
            this.LbStartstation.Name = "LbStartstation";
            this.LbStartstation.Size = new System.Drawing.Size(80, 17);
            this.LbStartstation.TabIndex = 1;
            this.LbStartstation.Text = "Startstation";
            // 
            // LbEndstation
            // 
            this.LbEndstation.AutoSize = true;
            this.LbEndstation.Location = new System.Drawing.Point(366, 44);
            this.LbEndstation.Name = "LbEndstation";
            this.LbEndstation.Size = new System.Drawing.Size(75, 17);
            this.LbEndstation.TabIndex = 3;
            this.LbEndstation.Text = "Endstation";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(61, 268);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(267, 22);
            this.dtpDatum.TabIndex = 4;
            // 
            // LbDatum
            // 
            this.LbDatum.AutoSize = true;
            this.LbDatum.Location = new System.Drawing.Point(64, 245);
            this.LbDatum.Name = "LbDatum";
            this.LbDatum.Size = new System.Drawing.Size(49, 17);
            this.LbDatum.TabIndex = 5;
            this.LbDatum.Text = "Datum";
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(395, 257);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(79, 33);
            this.btnSuchen.TabIndex = 6;
            this.btnSuchen.Text = "Suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // btnAuswahlDelete
            // 
            this.btnAuswahlDelete.Location = new System.Drawing.Point(492, 267);
            this.btnAuswahlDelete.Name = "btnAuswahlDelete";
            this.btnAuswahlDelete.Size = new System.Drawing.Size(141, 23);
            this.btnAuswahlDelete.TabIndex = 7;
            this.btnAuswahlDelete.Text = "Auswahl entfernen";
            this.btnAuswahlDelete.UseVisualStyleBackColor = true;
            this.btnAuswahlDelete.Click += new System.EventHandler(this.btnAuswahlDelete_Click);
            // 
            // txtEndstation
            // 
            this.txtEndstation.Location = new System.Drawing.Point(369, 67);
            this.txtEndstation.Name = "txtEndstation";
            this.txtEndstation.Size = new System.Drawing.Size(267, 22);
            this.txtEndstation.TabIndex = 0;
            // 
            // lstAusgabe
            // 
            this.lstAusgabe.FormattingEnabled = true;
            this.lstAusgabe.ItemHeight = 16;
            this.lstAusgabe.Location = new System.Drawing.Point(67, 323);
            this.lstAusgabe.Name = "lstAusgabe";
            this.lstAusgabe.Size = new System.Drawing.Size(566, 228);
            this.lstAusgabe.TabIndex = 8;
            // 
            // lstStartstation
            // 
            this.lstStartstation.FormattingEnabled = true;
            this.lstStartstation.ItemHeight = 16;
            this.lstStartstation.Location = new System.Drawing.Point(64, 96);
            this.lstStartstation.Name = "lstStartstation";
            this.lstStartstation.Size = new System.Drawing.Size(264, 116);
            this.lstStartstation.TabIndex = 9;
            this.lstStartstation.Click += new System.EventHandler(this.lstStartstation_Click);
            // 
            // lstEndstation
            // 
            this.lstEndstation.FormattingEnabled = true;
            this.lstEndstation.ItemHeight = 16;
            this.lstEndstation.Location = new System.Drawing.Point(369, 96);
            this.lstEndstation.Name = "lstEndstation";
            this.lstEndstation.Size = new System.Drawing.Size(267, 116);
            this.lstEndstation.TabIndex = 10;
            this.lstEndstation.Click += new System.EventHandler(this.lstEndstation_Click);
            // 
            // btnVorschlaege
            // 
            this.btnVorschlaege.Location = new System.Drawing.Point(642, 121);
            this.btnVorschlaege.Name = "btnVorschlaege";
            this.btnVorschlaege.Size = new System.Drawing.Size(115, 51);
            this.btnVorschlaege.TabIndex = 11;
            this.btnVorschlaege.Text = "Vorschläge Anzeigen";
            this.btnVorschlaege.UseVisualStyleBackColor = true;
            this.btnVorschlaege.Click += new System.EventHandler(this.btnVorschlaege_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSuchen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.btnVorschlaege);
            this.Controls.Add(this.lstEndstation);
            this.Controls.Add(this.lstStartstation);
            this.Controls.Add(this.lstAusgabe);
            this.Controls.Add(this.btnAuswahlDelete);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.LbDatum);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.LbEndstation);
            this.Controls.Add(this.LbStartstation);
            this.Controls.Add(this.txtEndstation);
            this.Controls.Add(this.txtStartstation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStartstation;
        private System.Windows.Forms.Label LbStartstation;
        private System.Windows.Forms.Label LbEndstation;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label LbDatum;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.Button btnAuswahlDelete;
        private System.Windows.Forms.TextBox txtEndstation;
        private System.Windows.Forms.ListBox lstAusgabe;
        private System.Windows.Forms.ListBox lstStartstation;
        private System.Windows.Forms.ListBox lstEndstation;
        private System.Windows.Forms.Button btnVorschlaege;
    }
}


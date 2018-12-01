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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.LbDate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSuggestionDelete = new System.Windows.Forms.Button();
            this.txtEndstation = new System.Windows.Forms.TextBox();
            this.lstStartstation = new System.Windows.Forms.ListBox();
            this.lstEndstation = new System.Windows.Forms.ListBox();
            this.btnSuggestion = new System.Windows.Forms.Button();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.ArrivalTimestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platfrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lbTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStartstation
            // 
            this.txtStartstation.Location = new System.Drawing.Point(69, 55);
            this.txtStartstation.Name = "txtStartstation";
            this.txtStartstation.Size = new System.Drawing.Size(267, 22);
            this.txtStartstation.TabIndex = 1;
            // 
            // LbStartstation
            // 
            this.LbStartstation.AutoSize = true;
            this.LbStartstation.Location = new System.Drawing.Point(69, 32);
            this.LbStartstation.Name = "LbStartstation";
            this.LbStartstation.Size = new System.Drawing.Size(80, 17);
            this.LbStartstation.TabIndex = 0;
            this.LbStartstation.Text = "Startstation";
            // 
            // LbEndstation
            // 
            this.LbEndstation.AutoSize = true;
            this.LbEndstation.Location = new System.Drawing.Point(371, 32);
            this.LbEndstation.Name = "LbEndstation";
            this.LbEndstation.Size = new System.Drawing.Size(75, 17);
            this.LbEndstation.TabIndex = 2;
            this.LbEndstation.Text = "Endstation";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(66, 256);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(245, 22);
            this.dtpDate.TabIndex = 8;
            // 
            // LbDate
            // 
            this.LbDate.AutoSize = true;
            this.LbDate.Location = new System.Drawing.Point(69, 233);
            this.LbDate.Name = "LbDate";
            this.LbDate.Size = new System.Drawing.Size(49, 17);
            this.LbDate.TabIndex = 7;
            this.LbDate.Text = "Datum";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(505, 245);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 33);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSuggestionDelete
            // 
            this.btnSuggestionDelete.Location = new System.Drawing.Point(590, 255);
            this.btnSuggestionDelete.Name = "btnSuggestionDelete";
            this.btnSuggestionDelete.Size = new System.Drawing.Size(141, 23);
            this.btnSuggestionDelete.TabIndex = 10;
            this.btnSuggestionDelete.Text = "Auswahl entfernen";
            this.btnSuggestionDelete.UseVisualStyleBackColor = true;
            this.btnSuggestionDelete.Click += new System.EventHandler(this.btnSuggestionDelete_Click);
            // 
            // txtEndstation
            // 
            this.txtEndstation.Location = new System.Drawing.Point(374, 55);
            this.txtEndstation.Name = "txtEndstation";
            this.txtEndstation.Size = new System.Drawing.Size(267, 22);
            this.txtEndstation.TabIndex = 3;
            // 
            // lstStartstation
            // 
            this.lstStartstation.FormattingEnabled = true;
            this.lstStartstation.ItemHeight = 16;
            this.lstStartstation.Location = new System.Drawing.Point(69, 84);
            this.lstStartstation.Name = "lstStartstation";
            this.lstStartstation.Size = new System.Drawing.Size(267, 116);
            this.lstStartstation.TabIndex = 5;
            this.lstStartstation.Click += new System.EventHandler(this.lstStartstation_Click);
            // 
            // lstEndstation
            // 
            this.lstEndstation.FormattingEnabled = true;
            this.lstEndstation.ItemHeight = 16;
            this.lstEndstation.Location = new System.Drawing.Point(374, 84);
            this.lstEndstation.Name = "lstEndstation";
            this.lstEndstation.Size = new System.Drawing.Size(267, 116);
            this.lstEndstation.TabIndex = 6;
            this.lstEndstation.Click += new System.EventHandler(this.lstEndstation_Click);
            // 
            // btnSuggestion
            // 
            this.btnSuggestion.Location = new System.Drawing.Point(647, 109);
            this.btnSuggestion.Name = "btnSuggestion";
            this.btnSuggestion.Size = new System.Drawing.Size(115, 51);
            this.btnSuggestion.TabIndex = 4;
            this.btnSuggestion.Text = "Vorschläge Anzeigen";
            this.btnSuggestion.UseVisualStyleBackColor = true;
            this.btnSuggestion.Click += new System.EventHandler(this.btnSuggestion_Click);
            // 
            // dgvOutput
            // 
            this.dgvOutput.AllowUserToAddRows = false;
            this.dgvOutput.AllowUserToDeleteRows = false;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StationName,
            this.departureTimestamp,
            this.platfrom,
            this.ArrivalTimestamp});
            this.dgvOutput.Location = new System.Drawing.Point(66, 338);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.ReadOnly = true;
            this.dgvOutput.RowTemplate.Height = 24;
            this.dgvOutput.Size = new System.Drawing.Size(665, 196);
            this.dgvOutput.TabIndex = 11;
            // 
            // ArrivalTimestamp
            // 
            this.ArrivalTimestamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ArrivalTimestamp.HeaderText = "Ankunftszeit";
            this.ArrivalTimestamp.Name = "ArrivalTimestamp";
            this.ArrivalTimestamp.ReadOnly = true;
            // 
            // platfrom
            // 
            this.platfrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.platfrom.HeaderText = "Gleis";
            this.platfrom.Name = "platfrom";
            this.platfrom.ReadOnly = true;
            // 
            // departureTimestamp
            // 
            this.departureTimestamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departureTimestamp.HeaderText = "Abfahrtszeit";
            this.departureTimestamp.Name = "departureTimestamp";
            this.departureTimestamp.ReadOnly = true;
            // 
            // StationName
            // 
            this.StationName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StationName.HeaderText = "Station";
            this.StationName.Name = "StationName";
            this.StationName.ReadOnly = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(342, 255);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 22);
            this.numericUpDown1.TabIndex = 12;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(397, 255);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(49, 22);
            this.numericUpDown2.TabIndex = 12;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(342, 232);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(85, 17);
            this.lbTime.TabIndex = 13;
            this.lbTime.Text = "Ankunftszeit";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dgvOutput);
            this.Controls.Add(this.btnSuggestion);
            this.Controls.Add(this.lstEndstation);
            this.Controls.Add(this.lstStartstation);
            this.Controls.Add(this.btnSuggestionDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.LbDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.LbEndstation);
            this.Controls.Add(this.LbStartstation);
            this.Controls.Add(this.txtEndstation);
            this.Controls.Add(this.txtStartstation);
            this.Name = "Form1";
            this.Text = "ÖV-Reisen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStartstation;
        private System.Windows.Forms.Label LbStartstation;
        private System.Windows.Forms.Label LbEndstation;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label LbDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSuggestionDelete;
        private System.Windows.Forms.TextBox txtEndstation;
        private System.Windows.Forms.ListBox lstStartstation;
        private System.Windows.Forms.ListBox lstEndstation;
        private System.Windows.Forms.Button btnSuggestion;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn platfrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTimestamp;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label lbTime;
    }
}


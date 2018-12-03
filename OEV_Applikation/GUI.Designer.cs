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
            this.lblStartstation = new System.Windows.Forms.Label();
            this.lblEndstation = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSuggestionDelete = new System.Windows.Forms.Button();
            this.txtEndstation = new System.Windows.Forms.TextBox();
            this.lstStartstation = new System.Windows.Forms.ListBox();
            this.lstEndstation = new System.Windows.Forms.ListBox();
            this.btnSuggestion = new System.Windows.Forms.Button();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.StationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platfrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTimestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbrHour = new System.Windows.Forms.NumericUpDown();
            this.nbrMinute = new System.Windows.Forms.NumericUpDown();
            this.lblTime = new System.Windows.Forms.Label();
            this.tbcChangeView = new System.Windows.Forms.TabControl();
            this.sdConnection = new System.Windows.Forms.TabPage();
            this.sdStation = new System.Windows.Forms.TabPage();
            this.btnSearchStation = new System.Windows.Forms.Button();
            this.lstSuggestionsStation = new System.Windows.Forms.ListBox();
            this.dgvOutputStation = new System.Windows.Forms.DataGridView();
            this.StationFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStation = new System.Windows.Forms.Label();
            this.txtStation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrMinute)).BeginInit();
            this.tbcChangeView.SuspendLayout();
            this.sdConnection.SuspendLayout();
            this.sdStation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutputStation)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStartstation
            // 
            this.txtStartstation.Location = new System.Drawing.Point(21, 54);
            this.txtStartstation.Name = "txtStartstation";
            this.txtStartstation.Size = new System.Drawing.Size(267, 22);
            this.txtStartstation.TabIndex = 1;
            // 
            // lblStartstation
            // 
            this.lblStartstation.AutoSize = true;
            this.lblStartstation.Location = new System.Drawing.Point(18, 34);
            this.lblStartstation.Name = "lblStartstation";
            this.lblStartstation.Size = new System.Drawing.Size(80, 17);
            this.lblStartstation.TabIndex = 0;
            this.lblStartstation.Text = "Startstation";
            // 
            // lblEndstation
            // 
            this.lblEndstation.AutoSize = true;
            this.lblEndstation.Location = new System.Drawing.Point(307, 34);
            this.lblEndstation.Name = "lblEndstation";
            this.lblEndstation.Size = new System.Drawing.Size(75, 17);
            this.lblEndstation.TabIndex = 2;
            this.lblEndstation.Text = "Endstation";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "";
            this.dtpDate.Location = new System.Drawing.Point(21, 259);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(245, 22);
            this.dtpDate.TabIndex = 8;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(18, 239);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 17);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Datum";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(515, 248);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 33);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSuggestionDelete
            // 
            this.btnSuggestionDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSuggestionDelete.Location = new System.Drawing.Point(600, 258);
            this.btnSuggestionDelete.Name = "btnSuggestionDelete";
            this.btnSuggestionDelete.Size = new System.Drawing.Size(141, 23);
            this.btnSuggestionDelete.TabIndex = 10;
            this.btnSuggestionDelete.Text = "Auswahl entfernen";
            this.btnSuggestionDelete.UseVisualStyleBackColor = true;
            this.btnSuggestionDelete.Click += new System.EventHandler(this.btnSuggestionDelete_Click);
            // 
            // txtEndstation
            // 
            this.txtEndstation.Location = new System.Drawing.Point(310, 54);
            this.txtEndstation.Name = "txtEndstation";
            this.txtEndstation.Size = new System.Drawing.Size(267, 22);
            this.txtEndstation.TabIndex = 3;
            // 
            // lstStartstation
            // 
            this.lstStartstation.FormattingEnabled = true;
            this.lstStartstation.ItemHeight = 16;
            this.lstStartstation.Location = new System.Drawing.Point(21, 82);
            this.lstStartstation.Name = "lstStartstation";
            this.lstStartstation.Size = new System.Drawing.Size(267, 116);
            this.lstStartstation.TabIndex = 5;
            this.lstStartstation.Click += new System.EventHandler(this.lstStartstation_Click);
            // 
            // lstEndstation
            // 
            this.lstEndstation.FormattingEnabled = true;
            this.lstEndstation.ItemHeight = 16;
            this.lstEndstation.Location = new System.Drawing.Point(310, 82);
            this.lstEndstation.Name = "lstEndstation";
            this.lstEndstation.Size = new System.Drawing.Size(267, 116);
            this.lstEndstation.TabIndex = 6;
            this.lstEndstation.Click += new System.EventHandler(this.lstEndstation_Click);
            // 
            // btnSuggestion
            // 
            this.btnSuggestion.Location = new System.Drawing.Point(583, 114);
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
            this.ArrivalTimestamp,
            this.Endstation});
            this.dgvOutput.Location = new System.Drawing.Point(21, 326);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.ReadOnly = true;
            this.dgvOutput.RowTemplate.Height = 24;
            this.dgvOutput.Size = new System.Drawing.Size(665, 196);
            this.dgvOutput.TabIndex = 11;
            // 
            // StationName
            // 
            this.StationName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StationName.HeaderText = "Station";
            this.StationName.Name = "StationName";
            this.StationName.ReadOnly = true;
            // 
            // departureTimestamp
            // 
            this.departureTimestamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departureTimestamp.HeaderText = "Abfahrtszeit";
            this.departureTimestamp.Name = "departureTimestamp";
            this.departureTimestamp.ReadOnly = true;
            // 
            // platfrom
            // 
            this.platfrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.platfrom.HeaderText = "Gleis";
            this.platfrom.Name = "platfrom";
            this.platfrom.ReadOnly = true;
            // 
            // ArrivalTimestamp
            // 
            this.ArrivalTimestamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ArrivalTimestamp.HeaderText = "Ankunftszeit";
            this.ArrivalTimestamp.Name = "ArrivalTimestamp";
            this.ArrivalTimestamp.ReadOnly = true;
            // 
            // Endstation
            // 
            this.Endstation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Endstation.HeaderText = "Endstation";
            this.Endstation.Name = "Endstation";
            this.Endstation.ReadOnly = true;
            // 
            // nbrHour
            // 
            this.nbrHour.Location = new System.Drawing.Point(310, 259);
            this.nbrHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nbrHour.Name = "nbrHour";
            this.nbrHour.Size = new System.Drawing.Size(49, 22);
            this.nbrHour.TabIndex = 12;
            // 
            // nbrMinute
            // 
            this.nbrMinute.Location = new System.Drawing.Point(365, 259);
            this.nbrMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nbrMinute.Name = "nbrMinute";
            this.nbrMinute.Size = new System.Drawing.Size(49, 22);
            this.nbrMinute.TabIndex = 12;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(307, 239);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 17);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "Uhrzeit";
            // 
            // tbcChangeView
            // 
            this.tbcChangeView.Controls.Add(this.sdConnection);
            this.tbcChangeView.Controls.Add(this.sdStation);
            this.tbcChangeView.Location = new System.Drawing.Point(12, 12);
            this.tbcChangeView.Name = "tbcChangeView";
            this.tbcChangeView.SelectedIndex = 0;
            this.tbcChangeView.Size = new System.Drawing.Size(802, 589);
            this.tbcChangeView.TabIndex = 14;
            this.tbcChangeView.SelectedIndexChanged += new System.EventHandler(this.tbcChangeView_SelectedIndexChanged);
            // 
            // sdConnection
            // 
            this.sdConnection.Controls.Add(this.btnSuggestion);
            this.sdConnection.Controls.Add(this.lblStartstation);
            this.sdConnection.Controls.Add(this.lstStartstation);
            this.sdConnection.Controls.Add(this.txtStartstation);
            this.sdConnection.Controls.Add(this.lblTime);
            this.sdConnection.Controls.Add(this.lblDate);
            this.sdConnection.Controls.Add(this.btnSuggestionDelete);
            this.sdConnection.Controls.Add(this.dtpDate);
            this.sdConnection.Controls.Add(this.nbrHour);
            this.sdConnection.Controls.Add(this.lblEndstation);
            this.sdConnection.Controls.Add(this.nbrMinute);
            this.sdConnection.Controls.Add(this.btnSearch);
            this.sdConnection.Controls.Add(this.lstEndstation);
            this.sdConnection.Controls.Add(this.dgvOutput);
            this.sdConnection.Controls.Add(this.txtEndstation);
            this.sdConnection.Location = new System.Drawing.Point(4, 25);
            this.sdConnection.Name = "sdConnection";
            this.sdConnection.Padding = new System.Windows.Forms.Padding(3);
            this.sdConnection.Size = new System.Drawing.Size(794, 560);
            this.sdConnection.TabIndex = 0;
            this.sdConnection.Text = "Verbindungen zwischen Stationen";
            this.sdConnection.UseVisualStyleBackColor = true;
            // 
            // sdStation
            // 
            this.sdStation.Controls.Add(this.btnSearchStation);
            this.sdStation.Controls.Add(this.lstSuggestionsStation);
            this.sdStation.Controls.Add(this.dgvOutputStation);
            this.sdStation.Controls.Add(this.lblStation);
            this.sdStation.Controls.Add(this.txtStation);
            this.sdStation.Location = new System.Drawing.Point(4, 25);
            this.sdStation.Name = "sdStation";
            this.sdStation.Padding = new System.Windows.Forms.Padding(3);
            this.sdStation.Size = new System.Drawing.Size(794, 560);
            this.sdStation.TabIndex = 1;
            this.sdStation.Text = "Anschlüsse von Station";
            this.sdStation.UseVisualStyleBackColor = true;
            // 
            // btnSearchStation
            // 
            this.btnSearchStation.Location = new System.Drawing.Point(360, 161);
            this.btnSearchStation.Name = "btnSearchStation";
            this.btnSearchStation.Size = new System.Drawing.Size(157, 31);
            this.btnSearchStation.TabIndex = 6;
            this.btnSearchStation.Text = "Anschlüsse Anzeigen";
            this.btnSearchStation.UseVisualStyleBackColor = true;
            this.btnSearchStation.Click += new System.EventHandler(this.btnSearchStation_Click);
            // 
            // lstSuggestionsStation
            // 
            this.lstSuggestionsStation.FormattingEnabled = true;
            this.lstSuggestionsStation.ItemHeight = 16;
            this.lstSuggestionsStation.Location = new System.Drawing.Point(64, 76);
            this.lstSuggestionsStation.Name = "lstSuggestionsStation";
            this.lstSuggestionsStation.Size = new System.Drawing.Size(267, 116);
            this.lstSuggestionsStation.TabIndex = 5;
            // 
            // dgvOutputStation
            // 
            this.dgvOutputStation.AllowUserToAddRows = false;
            this.dgvOutputStation.AllowUserToDeleteRows = false;
            this.dgvOutputStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutputStation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StationFrom,
            this.StationTo});
            this.dgvOutputStation.Location = new System.Drawing.Point(64, 250);
            this.dgvOutputStation.Name = "dgvOutputStation";
            this.dgvOutputStation.ReadOnly = true;
            this.dgvOutputStation.RowTemplate.Height = 24;
            this.dgvOutputStation.Size = new System.Drawing.Size(634, 248);
            this.dgvOutputStation.TabIndex = 4;
            // 
            // StationFrom
            // 
            this.StationFrom.HeaderText = "Station";
            this.StationFrom.Name = "StationFrom";
            this.StationFrom.ReadOnly = true;
            // 
            // StationTo
            // 
            this.StationTo.HeaderText = "Zielstation";
            this.StationTo.Name = "StationTo";
            this.StationTo.ReadOnly = true;
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(61, 27);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(52, 17);
            this.lblStation.TabIndex = 3;
            this.lblStation.Text = "Station";
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(64, 47);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(267, 22);
            this.txtStation.TabIndex = 2;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSuggestionDelete;
            this.ClientSize = new System.Drawing.Size(824, 610);
            this.Controls.Add(this.tbcChangeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "ÖV-Reisen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrMinute)).EndInit();
            this.tbcChangeView.ResumeLayout(false);
            this.sdConnection.ResumeLayout(false);
            this.sdConnection.PerformLayout();
            this.sdStation.ResumeLayout(false);
            this.sdStation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutputStation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtStartstation;
        private System.Windows.Forms.Label lblStartstation;
        private System.Windows.Forms.Label lblEndstation;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSuggestionDelete;
        private System.Windows.Forms.TextBox txtEndstation;
        private System.Windows.Forms.ListBox lstStartstation;
        private System.Windows.Forms.ListBox lstEndstation;
        private System.Windows.Forms.Button btnSuggestion;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.NumericUpDown nbrHour;
        private System.Windows.Forms.NumericUpDown nbrMinute;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn platfrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTimestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endstation;
        private System.Windows.Forms.TabControl tbcChangeView;
        private System.Windows.Forms.TabPage sdConnection;
        private System.Windows.Forms.TabPage sdStation;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.DataGridView dgvOutputStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationTo;
        private System.Windows.Forms.ListBox lstSuggestionsStation;
        private System.Windows.Forms.Button btnSearchStation;
    }
}


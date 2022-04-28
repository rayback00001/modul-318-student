namespace SwissTransportGUI
{
    partial class verbindungSuchenforms
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
            this.nachlabel = new System.Windows.Forms.Label();
            this.vonlabel = new System.Windows.Forms.Label();
            this.vonInputcmbx = new System.Windows.Forms.ComboBox();
            this.nachInputcmbx = new System.Windows.Forms.ComboBox();
            this.Verbindungendatagrid = new System.Windows.Forms.DataGridView();
            this.startStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abreise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucheVerbindungbtn = new System.Windows.Forms.Button();
            this.abfahrtsplanbtn = new System.Windows.Forms.Button();
            this.stationSuchenbtn = new System.Windows.Forms.Button();
            this.verbindungSuchenbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Verbindungendatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // nachlabel
            // 
            this.nachlabel.AutoSize = true;
            this.nachlabel.Location = new System.Drawing.Point(524, 219);
            this.nachlabel.Name = "nachlabel";
            this.nachlabel.Size = new System.Drawing.Size(56, 25);
            this.nachlabel.TabIndex = 22;
            this.nachlabel.Text = "Nach:";
            // 
            // vonlabel
            // 
            this.vonlabel.AutoSize = true;
            this.vonlabel.Location = new System.Drawing.Point(166, 219);
            this.vonlabel.Name = "vonlabel";
            this.vonlabel.Size = new System.Drawing.Size(47, 25);
            this.vonlabel.TabIndex = 21;
            this.vonlabel.Text = "Von:";
            // 
            // vonInputcmbx
            // 
            this.vonInputcmbx.FormattingEnabled = true;
            this.vonInputcmbx.Location = new System.Drawing.Point(219, 216);
            this.vonInputcmbx.Name = "vonInputcmbx";
            this.vonInputcmbx.Size = new System.Drawing.Size(254, 33);
            this.vonInputcmbx.TabIndex = 17;
            this.vonInputcmbx.SelectedIndexChanged += new System.EventHandler(this.vonInputcmbx_SelectedIndexChanged);
            // 
            // nachInputcmbx
            // 
            this.nachInputcmbx.FormattingEnabled = true;
            this.nachInputcmbx.Location = new System.Drawing.Point(586, 216);
            this.nachInputcmbx.Name = "nachInputcmbx";
            this.nachInputcmbx.Size = new System.Drawing.Size(254, 33);
            this.nachInputcmbx.TabIndex = 18;
            // 
            // Verbindungendatagrid
            // 
            this.Verbindungendatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Verbindungendatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startStation,
            this.endStation,
            this.abreise,
            this.ankunft,
            this.gleis});
            this.Verbindungendatagrid.Location = new System.Drawing.Point(103, 357);
            this.Verbindungendatagrid.Name = "Verbindungendatagrid";
            this.Verbindungendatagrid.RowHeadersVisible = false;
            this.Verbindungendatagrid.RowHeadersWidth = 62;
            this.Verbindungendatagrid.RowTemplate.Height = 33;
            this.Verbindungendatagrid.Size = new System.Drawing.Size(826, 272);
            this.Verbindungendatagrid.TabIndex = 20;
            // 
            // startStation
            // 
            this.startStation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startStation.HeaderText = "Startstation";
            this.startStation.MinimumWidth = 8;
            this.startStation.Name = "startStation";
            // 
            // endStation
            // 
            this.endStation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endStation.HeaderText = "Endstation";
            this.endStation.MinimumWidth = 8;
            this.endStation.Name = "endStation";
            // 
            // abreise
            // 
            this.abreise.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.abreise.HeaderText = "Abreise";
            this.abreise.MinimumWidth = 8;
            this.abreise.Name = "abreise";
            // 
            // ankunft
            // 
            this.ankunft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ankunft.HeaderText = "Ankunft";
            this.ankunft.MinimumWidth = 8;
            this.ankunft.Name = "ankunft";
            // 
            // gleis
            // 
            this.gleis.HeaderText = "Gleis";
            this.gleis.MinimumWidth = 8;
            this.gleis.Name = "gleis";
            this.gleis.Width = 150;
            // 
            // sucheVerbindungbtn
            // 
            this.sucheVerbindungbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sucheVerbindungbtn.Location = new System.Drawing.Point(662, 264);
            this.sucheVerbindungbtn.Name = "sucheVerbindungbtn";
            this.sucheVerbindungbtn.Size = new System.Drawing.Size(178, 40);
            this.sucheVerbindungbtn.TabIndex = 19;
            this.sucheVerbindungbtn.Text = "Suche Verbindung";
            this.sucheVerbindungbtn.UseVisualStyleBackColor = true;
            this.sucheVerbindungbtn.Click += new System.EventHandler(this.sucheVerbindungbtn_Click);
            // 
            // abfahrtsplanbtn
            // 
            this.abfahrtsplanbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abfahrtsplanbtn.Location = new System.Drawing.Point(646, 98);
            this.abfahrtsplanbtn.Name = "abfahrtsplanbtn";
            this.abfahrtsplanbtn.Size = new System.Drawing.Size(255, 70);
            this.abfahrtsplanbtn.TabIndex = 16;
            this.abfahrtsplanbtn.Text = "Abfahrtsplan";
            this.abfahrtsplanbtn.UseVisualStyleBackColor = true;
            // 
            // stationSuchenbtn
            // 
            this.stationSuchenbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stationSuchenbtn.Location = new System.Drawing.Point(385, 98);
            this.stationSuchenbtn.Name = "stationSuchenbtn";
            this.stationSuchenbtn.Size = new System.Drawing.Size(255, 70);
            this.stationSuchenbtn.TabIndex = 15;
            this.stationSuchenbtn.Text = "Station suchen";
            this.stationSuchenbtn.UseVisualStyleBackColor = true;
            // 
            // verbindungSuchenbtn
            // 
            this.verbindungSuchenbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verbindungSuchenbtn.Location = new System.Drawing.Point(124, 98);
            this.verbindungSuchenbtn.Name = "verbindungSuchenbtn";
            this.verbindungSuchenbtn.Size = new System.Drawing.Size(255, 70);
            this.verbindungSuchenbtn.TabIndex = 14;
            this.verbindungSuchenbtn.Text = "Verbindung suchen";
            this.verbindungSuchenbtn.UseVisualStyleBackColor = true;
            // 
            // verbindungSuchenforms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 673);
            this.Controls.Add(this.nachlabel);
            this.Controls.Add(this.vonlabel);
            this.Controls.Add(this.vonInputcmbx);
            this.Controls.Add(this.nachInputcmbx);
            this.Controls.Add(this.Verbindungendatagrid);
            this.Controls.Add(this.sucheVerbindungbtn);
            this.Controls.Add(this.abfahrtsplanbtn);
            this.Controls.Add(this.stationSuchenbtn);
            this.Controls.Add(this.verbindungSuchenbtn);
            this.Name = "verbindungSuchenforms";
            this.Text = "Menue";
            ((System.ComponentModel.ISupportInitialize)(this.Verbindungendatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nachlabel;
        private Label vonlabel;
        private ComboBox vonInputcmbx;
        private ComboBox nachInputcmbx;
        private DataGridView Verbindungendatagrid;
        private DataGridViewTextBoxColumn startStation;
        private DataGridViewTextBoxColumn endStation;
        private DataGridViewTextBoxColumn abreise;
        private DataGridViewTextBoxColumn ankunft;
        private DataGridViewTextBoxColumn gleis;
        private Button sucheVerbindungbtn;
        private Button abfahrtsplanbtn;
        private Button stationSuchenbtn;
        private Button verbindungSuchenbtn;
    }
}
namespace SwissTransportUI
{
    partial class VerbindungSuchen
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
            this.sucheVerbindungButton = new System.Windows.Forms.Button();
            this.vonInputcmbx = new System.Windows.Forms.ComboBox();
            this.nachInputcmbx = new System.Windows.Forms.ComboBox();
            this.verbindungSucheDatagrid = new System.Windows.Forms.DataGridView();
            this.startStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abreise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vonLabel = new System.Windows.Forms.Label();
            this.nachLabel = new System.Windows.Forms.Label();
            this.gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.verbindungSucheDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sucheVerbindungButton
            // 
            this.sucheVerbindungButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sucheVerbindungButton.Location = new System.Drawing.Point(620, 121);
            this.sucheVerbindungButton.Name = "sucheVerbindungButton";
            this.sucheVerbindungButton.Size = new System.Drawing.Size(173, 63);
            this.sucheVerbindungButton.TabIndex = 0;
            this.sucheVerbindungButton.Text = "Suche Verbindung";
            this.sucheVerbindungButton.UseVisualStyleBackColor = true;
            this.sucheVerbindungButton.Click += new System.EventHandler(this.sucheVerbindungButton_Click);
            // 
            // vonInputcmbx
            // 
            this.vonInputcmbx.FormattingEnabled = true;
            this.vonInputcmbx.Location = new System.Drawing.Point(120, 82);
            this.vonInputcmbx.Name = "vonInputcmbx";
            this.vonInputcmbx.Size = new System.Drawing.Size(278, 33);
            this.vonInputcmbx.TabIndex = 1;
            // 
            // nachInputcmbx
            // 
            this.nachInputcmbx.FormattingEnabled = true;
            this.nachInputcmbx.Location = new System.Drawing.Point(515, 82);
            this.nachInputcmbx.Name = "nachInputcmbx";
            this.nachInputcmbx.Size = new System.Drawing.Size(278, 33);
            this.nachInputcmbx.TabIndex = 2;
            // 
            // verbindungSucheDatagrid
            // 
            this.verbindungSucheDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.verbindungSucheDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startStation,
            this.endStation,
            this.abreise,
            this.ankunft,
            this.gleis});
            this.verbindungSucheDatagrid.Location = new System.Drawing.Point(25, 284);
            this.verbindungSucheDatagrid.Name = "verbindungSucheDatagrid";
            this.verbindungSucheDatagrid.RowHeadersVisible = false;
            this.verbindungSucheDatagrid.RowHeadersWidth = 62;
            this.verbindungSucheDatagrid.RowTemplate.Height = 33;
            this.verbindungSucheDatagrid.Size = new System.Drawing.Size(851, 225);
            this.verbindungSucheDatagrid.TabIndex = 3;
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
            // vonLabel
            // 
            this.vonLabel.AutoSize = true;
            this.vonLabel.Location = new System.Drawing.Point(54, 88);
            this.vonLabel.Name = "vonLabel";
            this.vonLabel.Size = new System.Drawing.Size(47, 25);
            this.vonLabel.TabIndex = 4;
            this.vonLabel.Text = "Von:";
            // 
            // nachLabel
            // 
            this.nachLabel.AutoSize = true;
            this.nachLabel.Location = new System.Drawing.Point(453, 85);
            this.nachLabel.Name = "nachLabel";
            this.nachLabel.Size = new System.Drawing.Size(56, 25);
            this.nachLabel.TabIndex = 5;
            this.nachLabel.Text = "Nach:";
            // 
            // gleis
            // 
            this.gleis.HeaderText = "Gleis";
            this.gleis.MinimumWidth = 8;
            this.gleis.Name = "gleis";
            this.gleis.Width = 150;
            // 
            // VerbindungSuchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 553);
            this.Controls.Add(this.nachLabel);
            this.Controls.Add(this.vonLabel);
            this.Controls.Add(this.verbindungSucheDatagrid);
            this.Controls.Add(this.nachInputcmbx);
            this.Controls.Add(this.vonInputcmbx);
            this.Controls.Add(this.sucheVerbindungButton);
            this.Name = "VerbindungSuchen";
            this.Text = "VerbindungSuchen";
            ((System.ComponentModel.ISupportInitialize)(this.verbindungSucheDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button sucheVerbindungButton;
        private ComboBox vonInputcmbx;
        private ComboBox nachInputcmbx;
        private DataGridView verbindungSucheDatagrid;
        private DataGridViewTextBoxColumn startStation;
        private DataGridViewTextBoxColumn endStation;
        private DataGridViewTextBoxColumn abreise;
        private DataGridViewTextBoxColumn ankunft;
        private Label vonLabel;
        private Label nachLabel;
        private DataGridViewTextBoxColumn gleis;
    }
}
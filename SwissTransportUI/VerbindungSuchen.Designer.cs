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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sucheVerbindungButton = new System.Windows.Forms.Button();
            this.vonInputcmbx = new System.Windows.Forms.ComboBox();
            this.nachInputcmbx = new System.Windows.Forms.ComboBox();
            this.verbindungSucheDatagrid = new System.Windows.Forms.DataGridView();
            this.vonLabel = new System.Windows.Forms.Label();
            this.nachLabel = new System.Windows.Forms.Label();
            this.verbindungSuchenLabel = new System.Windows.Forms.Label();
            this.startStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abreise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.verbindungSucheDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sucheVerbindungButton
            // 
            this.sucheVerbindungButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(78)))), ((int)(((byte)(142)))));
            this.sucheVerbindungButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sucheVerbindungButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sucheVerbindungButton.Location = new System.Drawing.Point(626, 185);
            this.sucheVerbindungButton.Name = "sucheVerbindungButton";
            this.sucheVerbindungButton.Size = new System.Drawing.Size(194, 68);
            this.sucheVerbindungButton.TabIndex = 3;
            this.sucheVerbindungButton.Text = "Suche Verbindung";
            this.sucheVerbindungButton.UseVisualStyleBackColor = false;
            this.sucheVerbindungButton.Click += new System.EventHandler(this.sucheVerbindungButton_Click);
            // 
            // vonInputcmbx
            // 
            this.vonInputcmbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.vonInputcmbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.vonInputcmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.vonInputcmbx.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vonInputcmbx.FormattingEnabled = true;
            this.vonInputcmbx.ItemHeight = 50;
            this.vonInputcmbx.Location = new System.Drawing.Point(122, 123);
            this.vonInputcmbx.Name = "vonInputcmbx";
            this.vonInputcmbx.Size = new System.Drawing.Size(278, 56);
            this.vonInputcmbx.TabIndex = 1;
            this.vonInputcmbx.SelectedIndexChanged += new System.EventHandler(this.vonInputcmbx_SelectedIndexChanged);
            // 
            // nachInputcmbx
            // 
            this.nachInputcmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.nachInputcmbx.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nachInputcmbx.FormattingEnabled = true;
            this.nachInputcmbx.ItemHeight = 50;
            this.nachInputcmbx.Location = new System.Drawing.Point(542, 123);
            this.nachInputcmbx.Name = "nachInputcmbx";
            this.nachInputcmbx.Size = new System.Drawing.Size(278, 56);
            this.nachInputcmbx.TabIndex = 2;
            // 
            // verbindungSucheDatagrid
            // 
            this.verbindungSucheDatagrid.BackgroundColor = System.Drawing.Color.White;
            this.verbindungSucheDatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.verbindungSucheDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.verbindungSucheDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.verbindungSucheDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startStation,
            this.endStation,
            this.abreise,
            this.ankunft,
            this.gleis});
            this.verbindungSucheDatagrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verbindungSucheDatagrid.GridColor = System.Drawing.Color.White;
            this.verbindungSucheDatagrid.Location = new System.Drawing.Point(1, 284);
            this.verbindungSucheDatagrid.Name = "verbindungSucheDatagrid";
            this.verbindungSucheDatagrid.RowHeadersVisible = false;
            this.verbindungSucheDatagrid.RowHeadersWidth = 62;
            this.verbindungSucheDatagrid.RowTemplate.Height = 33;
            this.verbindungSucheDatagrid.Size = new System.Drawing.Size(906, 270);
            this.verbindungSucheDatagrid.TabIndex = 4;
            // 
            // vonLabel
            // 
            this.vonLabel.AutoSize = true;
            this.vonLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vonLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.vonLabel.Location = new System.Drawing.Point(51, 131);
            this.vonLabel.Name = "vonLabel";
            this.vonLabel.Size = new System.Drawing.Size(65, 32);
            this.vonLabel.TabIndex = 4;
            this.vonLabel.Text = "Von:";
            // 
            // nachLabel
            // 
            this.nachLabel.AutoSize = true;
            this.nachLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nachLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nachLabel.Location = new System.Drawing.Point(457, 131);
            this.nachLabel.Name = "nachLabel";
            this.nachLabel.Size = new System.Drawing.Size(79, 32);
            this.nachLabel.TabIndex = 5;
            this.nachLabel.Text = "Nach:";
            // 
            // verbindungSuchenLabel
            // 
            this.verbindungSuchenLabel.AutoSize = true;
            this.verbindungSuchenLabel.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.verbindungSuchenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(78)))), ((int)(((byte)(142)))));
            this.verbindungSuchenLabel.Location = new System.Drawing.Point(44, 28);
            this.verbindungSuchenLabel.Name = "verbindungSuchenLabel";
            this.verbindungSuchenLabel.Size = new System.Drawing.Size(360, 48);
            this.verbindungSuchenLabel.TabIndex = 6;
            this.verbindungSuchenLabel.Text = "Verbindung Suchen";
            // 
            // startStation
            // 
            this.startStation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.startStation.DefaultCellStyle = dataGridViewCellStyle2;
            this.startStation.FillWeight = 110F;
            this.startStation.HeaderText = "Startstation";
            this.startStation.MinimumWidth = 110;
            this.startStation.Name = "startStation";
            // 
            // endStation
            // 
            this.endStation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endStation.FillWeight = 110F;
            this.endStation.HeaderText = "Endstation";
            this.endStation.MinimumWidth = 110;
            this.endStation.Name = "endStation";
            // 
            // abreise
            // 
            this.abreise.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.abreise.FillWeight = 110F;
            this.abreise.HeaderText = "Abreise";
            this.abreise.MinimumWidth = 110;
            this.abreise.Name = "abreise";
            // 
            // ankunft
            // 
            this.ankunft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ankunft.FillWeight = 110F;
            this.ankunft.HeaderText = "Ankunft";
            this.ankunft.MinimumWidth = 110;
            this.ankunft.Name = "ankunft";
            // 
            // gleis
            // 
            this.gleis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gleis.FillWeight = 110F;
            this.gleis.HeaderText = "Gleis";
            this.gleis.MinimumWidth = 110;
            this.gleis.Name = "gleis";
            // 
            // VerbindungSuchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(907, 553);
            this.Controls.Add(this.verbindungSuchenLabel);
            this.Controls.Add(this.nachLabel);
            this.Controls.Add(this.vonLabel);
            this.Controls.Add(this.verbindungSucheDatagrid);
            this.Controls.Add(this.nachInputcmbx);
            this.Controls.Add(this.vonInputcmbx);
            this.Controls.Add(this.sucheVerbindungButton);
            this.MaximumSize = new System.Drawing.Size(929, 609);
            this.MinimumSize = new System.Drawing.Size(929, 609);
            this.Name = "VerbindungSuchen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private Label vonLabel;
        private Label nachLabel;
        private Label verbindungSuchenLabel;
        private DataGridViewTextBoxColumn startStation;
        private DataGridViewTextBoxColumn endStation;
        private DataGridViewTextBoxColumn abreise;
        private DataGridViewTextBoxColumn ankunft;
        private DataGridViewTextBoxColumn gleis;
    }
}
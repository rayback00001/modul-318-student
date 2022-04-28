namespace SwissTransportUI
{
    partial class Abfahrtsplan
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
            this.abfahrtsPlanDatagrid = new System.Windows.Forms.DataGridView();
            this.startStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abreise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortInputButton = new System.Windows.Forms.ComboBox();
            this.abfahrtsPlanAnzButton = new System.Windows.Forms.Button();
            this.ortLabel = new System.Windows.Forms.Label();
            this.abfahrtpslanLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.abfahrtsPlanDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // abfahrtsPlanDatagrid
            // 
            this.abfahrtsPlanDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abfahrtsPlanDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startStation,
            this.endStation,
            this.abreise});
            this.abfahrtsPlanDatagrid.Location = new System.Drawing.Point(0, 214);
            this.abfahrtsPlanDatagrid.Name = "abfahrtsPlanDatagrid";
            this.abfahrtsPlanDatagrid.RowHeadersVisible = false;
            this.abfahrtsPlanDatagrid.RowHeadersWidth = 62;
            this.abfahrtsPlanDatagrid.RowTemplate.Height = 33;
            this.abfahrtsPlanDatagrid.Size = new System.Drawing.Size(907, 336);
            this.abfahrtsPlanDatagrid.TabIndex = 7;
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
            // ortInputButton
            // 
            this.ortInputButton.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ortInputButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ortInputButton.FormattingEnabled = true;
            this.ortInputButton.ItemHeight = 50;
            this.ortInputButton.Location = new System.Drawing.Point(181, 118);
            this.ortInputButton.Name = "ortInputButton";
            this.ortInputButton.Size = new System.Drawing.Size(278, 56);
            this.ortInputButton.TabIndex = 5;
            this.ortInputButton.SelectedIndexChanged += new System.EventHandler(this.ortInputButton_SelectedIndexChanged);
            // 
            // abfahrtsPlanAnzButton
            // 
            this.abfahrtsPlanAnzButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(78)))), ((int)(((byte)(142)))));
            this.abfahrtsPlanAnzButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abfahrtsPlanAnzButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.abfahrtsPlanAnzButton.Location = new System.Drawing.Point(482, 121);
            this.abfahrtsPlanAnzButton.Name = "abfahrtsPlanAnzButton";
            this.abfahrtsPlanAnzButton.Size = new System.Drawing.Size(202, 57);
            this.abfahrtsPlanAnzButton.TabIndex = 6;
            this.abfahrtsPlanAnzButton.Text = "Abfahrtsplan anzeigen";
            this.abfahrtsPlanAnzButton.UseVisualStyleBackColor = false;
            this.abfahrtsPlanAnzButton.Click += new System.EventHandler(this.abfahrtsPlanAnzButton_Click);
            // 
            // ortLabel
            // 
            this.ortLabel.AutoSize = true;
            this.ortLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ortLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ortLabel.Location = new System.Drawing.Point(42, 131);
            this.ortLabel.Name = "ortLabel";
            this.ortLabel.Size = new System.Drawing.Size(133, 32);
            this.ortLabel.TabIndex = 7;
            this.ortLabel.Text = "Ortsname:";
            // 
            // abfahrtpslanLabel
            // 
            this.abfahrtpslanLabel.AutoSize = true;
            this.abfahrtpslanLabel.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.abfahrtpslanLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(78)))), ((int)(((byte)(142)))));
            this.abfahrtpslanLabel.Location = new System.Drawing.Point(44, 28);
            this.abfahrtpslanLabel.Name = "abfahrtpslanLabel";
            this.abfahrtpslanLabel.Size = new System.Drawing.Size(241, 48);
            this.abfahrtpslanLabel.TabIndex = 8;
            this.abfahrtpslanLabel.Text = "Abfahrtsplan";
            // 
            // Abfahrtsplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(907, 553);
            this.Controls.Add(this.abfahrtpslanLabel);
            this.Controls.Add(this.ortLabel);
            this.Controls.Add(this.abfahrtsPlanAnzButton);
            this.Controls.Add(this.ortInputButton);
            this.Controls.Add(this.abfahrtsPlanDatagrid);
            this.MaximumSize = new System.Drawing.Size(929, 609);
            this.MinimumSize = new System.Drawing.Size(929, 609);
            this.Name = "Abfahrtsplan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abfahrtsplan";
            ((System.ComponentModel.ISupportInitialize)(this.abfahrtsPlanDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView abfahrtsPlanDatagrid;
        private ComboBox ortInputButton;
        private Button abfahrtsPlanAnzButton;
        private Label ortLabel;
        private DataGridViewTextBoxColumn startStation;
        private DataGridViewTextBoxColumn endStation;
        private DataGridViewTextBoxColumn abreise;
        private Label abfahrtpslanLabel;
    }
}
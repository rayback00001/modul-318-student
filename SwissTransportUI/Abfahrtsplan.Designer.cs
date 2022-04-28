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
            this.ortInputButton = new System.Windows.Forms.ComboBox();
            this.abfahrtsPlanAnzButton = new System.Windows.Forms.Button();
            this.ortLabel = new System.Windows.Forms.Label();
            this.startStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abreise = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.abfahrtsPlanDatagrid.Location = new System.Drawing.Point(26, 274);
            this.abfahrtsPlanDatagrid.Name = "abfahrtsPlanDatagrid";
            this.abfahrtsPlanDatagrid.RowHeadersVisible = false;
            this.abfahrtsPlanDatagrid.RowHeadersWidth = 62;
            this.abfahrtsPlanDatagrid.RowTemplate.Height = 33;
            this.abfahrtsPlanDatagrid.Size = new System.Drawing.Size(851, 225);
            this.abfahrtsPlanDatagrid.TabIndex = 4;
            // 
            // ortInputButton
            // 
            this.ortInputButton.FormattingEnabled = true;
            this.ortInputButton.Location = new System.Drawing.Point(177, 124);
            this.ortInputButton.Name = "ortInputButton";
            this.ortInputButton.Size = new System.Drawing.Size(182, 33);
            this.ortInputButton.TabIndex = 5;
            // 
            // abfahrtsPlanAnzButton
            // 
            this.abfahrtsPlanAnzButton.Location = new System.Drawing.Point(177, 163);
            this.abfahrtsPlanAnzButton.Name = "abfahrtsPlanAnzButton";
            this.abfahrtsPlanAnzButton.Size = new System.Drawing.Size(182, 59);
            this.abfahrtsPlanAnzButton.TabIndex = 6;
            this.abfahrtsPlanAnzButton.Text = "Abfahrtsplan anzeigen";
            this.abfahrtsPlanAnzButton.UseVisualStyleBackColor = true;
            this.abfahrtsPlanAnzButton.Click += new System.EventHandler(this.abfahrtsPlanAnzButton_Click);
            // 
            // ortLabel
            // 
            this.ortLabel.AutoSize = true;
            this.ortLabel.Location = new System.Drawing.Point(68, 124);
            this.ortLabel.Name = "ortLabel";
            this.ortLabel.Size = new System.Drawing.Size(94, 25);
            this.ortLabel.TabIndex = 7;
            this.ortLabel.Text = "Ortsname:";
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
            // Abfahrtsplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 553);
            this.Controls.Add(this.ortLabel);
            this.Controls.Add(this.abfahrtsPlanAnzButton);
            this.Controls.Add(this.ortInputButton);
            this.Controls.Add(this.abfahrtsPlanDatagrid);
            this.Name = "Abfahrtsplan";
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
    }
}
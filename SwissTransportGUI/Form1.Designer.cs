namespace SwissTransportGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abfahrtsplanbtn = new System.Windows.Forms.Button();
            this.verbindungSuchenbtn = new System.Windows.Forms.Button();
            this.stationSuchenbtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sucheVerbindungbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.startStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abreise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 74);
            this.panel1.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // abfahrtsplanbtn
            // 
            this.abfahrtsplanbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abfahrtsplanbtn.Location = new System.Drawing.Point(673, 113);
            this.abfahrtsplanbtn.Name = "abfahrtsplanbtn";
            this.abfahrtsplanbtn.Size = new System.Drawing.Size(255, 70);
            this.abfahrtsplanbtn.TabIndex = 3;
            this.abfahrtsplanbtn.Text = "Abfahrtsplan";
            this.abfahrtsplanbtn.UseVisualStyleBackColor = true;
            this.abfahrtsplanbtn.Click += new System.EventHandler(this.abfahrtsplanbtn_Click);
            // 
            // verbindungSuchenbtn
            // 
            this.verbindungSuchenbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verbindungSuchenbtn.Location = new System.Drawing.Point(151, 113);
            this.verbindungSuchenbtn.Name = "verbindungSuchenbtn";
            this.verbindungSuchenbtn.Size = new System.Drawing.Size(255, 70);
            this.verbindungSuchenbtn.TabIndex = 1;
            this.verbindungSuchenbtn.Text = "Verbindung suchen";
            this.verbindungSuchenbtn.UseVisualStyleBackColor = true;
            this.verbindungSuchenbtn.Click += new System.EventHandler(this.verbindungSuchenbtn_Click);
            // 
            // stationSuchenbtn
            // 
            this.stationSuchenbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stationSuchenbtn.Location = new System.Drawing.Point(412, 113);
            this.stationSuchenbtn.Name = "stationSuchenbtn";
            this.stationSuchenbtn.Size = new System.Drawing.Size(255, 70);
            this.stationSuchenbtn.TabIndex = 2;
            this.stationSuchenbtn.Text = "Station suchen";
            this.stationSuchenbtn.UseVisualStyleBackColor = true;
            this.stationSuchenbtn.Click += new System.EventHandler(this.stationSuchenbtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 233);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 50);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(572, 233);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(308, 50);
            this.textBox2.TabIndex = 9;
            // 
            // sucheVerbindungbtn
            // 
            this.sucheVerbindungbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sucheVerbindungbtn.Location = new System.Drawing.Point(702, 289);
            this.sucheVerbindungbtn.Name = "sucheVerbindungbtn";
            this.sucheVerbindungbtn.Size = new System.Drawing.Size(178, 51);
            this.sucheVerbindungbtn.TabIndex = 10;
            this.sucheVerbindungbtn.Text = "Suche Verbindung";
            this.sucheVerbindungbtn.UseVisualStyleBackColor = true;
            this.sucheVerbindungbtn.Click += new System.EventHandler(this.sucheVerbindungbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startStation,
            this.endStation,
            this.abreise,
            this.ankunft});
            this.dataGridView1.Location = new System.Drawing.Point(54, 374);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(826, 272);
            this.dataGridView1.TabIndex = 11;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 673);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sucheVerbindungbtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.abfahrtsplanbtn);
            this.Controls.Add(this.stationSuchenbtn);
            this.Controls.Add(this.verbindungSuchenbtn);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "ÖV-App";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private ContextMenuStrip contextMenuStrip1;
        private Button abfahrtsplanbtn;
        private Button verbindungSuchenbtn;
        private Button stationSuchenbtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button sucheVerbindungbtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn startStation;
        private DataGridViewTextBoxColumn endStation;
        private DataGridViewTextBoxColumn abreise;
        private DataGridViewTextBoxColumn ankunft;
    }
}
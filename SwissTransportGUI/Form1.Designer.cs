﻿namespace SwissTransportGUI
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
            this.sucheVerbindungbtn = new System.Windows.Forms.Button();
            this.gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abreise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verbindungendatagrid = new System.Windows.Forms.DataGridView();
            this.nachInputcmbx = new System.Windows.Forms.ComboBox();
            this.vonInputcmbx = new System.Windows.Forms.ComboBox();
            this.vonlabel = new System.Windows.Forms.Label();
            this.nachlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Verbindungendatagrid)).BeginInit();
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
            this.abfahrtsplanbtn.Location = new System.Drawing.Point(663, 114);
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
            this.verbindungSuchenbtn.Location = new System.Drawing.Point(141, 114);
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
            this.stationSuchenbtn.Location = new System.Drawing.Point(402, 114);
            this.stationSuchenbtn.Name = "stationSuchenbtn";
            this.stationSuchenbtn.Size = new System.Drawing.Size(255, 70);
            this.stationSuchenbtn.TabIndex = 2;
            this.stationSuchenbtn.Text = "Station suchen";
            this.stationSuchenbtn.UseVisualStyleBackColor = true;
            this.stationSuchenbtn.Click += new System.EventHandler(this.stationSuchenbtn_Click);
            // 
            // sucheVerbindungbtn
            // 
            this.sucheVerbindungbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sucheVerbindungbtn.Location = new System.Drawing.Point(679, 280);
            this.sucheVerbindungbtn.Name = "sucheVerbindungbtn";
            this.sucheVerbindungbtn.Size = new System.Drawing.Size(178, 40);
            this.sucheVerbindungbtn.TabIndex = 6;
            this.sucheVerbindungbtn.Text = "Suche Verbindung";
            this.sucheVerbindungbtn.UseVisualStyleBackColor = true;
         
            // 
            // gleis
            // 
            this.gleis.HeaderText = "Gleis";
            this.gleis.MinimumWidth = 8;
            this.gleis.Name = "gleis";
            this.gleis.Width = 150;
            // 
            // ankunft
            // 
            this.ankunft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ankunft.HeaderText = "Ankunft";
            this.ankunft.MinimumWidth = 8;
            this.ankunft.Name = "ankunft";
            // 
            // abreise
            // 
            this.abreise.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.abreise.HeaderText = "Abreise";
            this.abreise.MinimumWidth = 8;
            this.abreise.Name = "abreise";
            // 
            // endStation
            // 
            this.endStation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endStation.HeaderText = "Endstation";
            this.endStation.MinimumWidth = 8;
            this.endStation.Name = "endStation";
            // 
            // startStation
            // 
            this.startStation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startStation.HeaderText = "Startstation";
            this.startStation.MinimumWidth = 8;
            this.startStation.Name = "startStation";
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
            this.Verbindungendatagrid.Location = new System.Drawing.Point(120, 373);
            this.Verbindungendatagrid.Name = "Verbindungendatagrid";
            this.Verbindungendatagrid.RowHeadersVisible = false;
            this.Verbindungendatagrid.RowHeadersWidth = 62;
            this.Verbindungendatagrid.RowTemplate.Height = 33;
            this.Verbindungendatagrid.Size = new System.Drawing.Size(826, 272);
            this.Verbindungendatagrid.TabIndex = 11;
            // 
            // nachInputcmbx
            // 
            this.nachInputcmbx.FormattingEnabled = true;
            this.nachInputcmbx.Location = new System.Drawing.Point(603, 232);
            this.nachInputcmbx.Name = "nachInputcmbx";
            this.nachInputcmbx.Size = new System.Drawing.Size(254, 33);
            this.nachInputcmbx.TabIndex = 5;
        
            // 
            // vonInputcmbx
            // 
            this.vonInputcmbx.FormattingEnabled = true;
            this.vonInputcmbx.Location = new System.Drawing.Point(236, 232);
            this.vonInputcmbx.Name = "vonInputcmbx";
            this.vonInputcmbx.Size = new System.Drawing.Size(254, 33);
            this.vonInputcmbx.TabIndex = 4;
      
            // 
            // vonlabel
            // 
            this.vonlabel.AutoSize = true;
            this.vonlabel.Location = new System.Drawing.Point(183, 235);
            this.vonlabel.Name = "vonlabel";
            this.vonlabel.Size = new System.Drawing.Size(47, 25);
            this.vonlabel.TabIndex = 12;
            this.vonlabel.Text = "Von:";
            // 
            // nachlabel
            // 
            this.nachlabel.AutoSize = true;
            this.nachlabel.Location = new System.Drawing.Point(541, 235);
            this.nachlabel.Name = "nachlabel";
            this.nachlabel.Size = new System.Drawing.Size(56, 25);
            this.nachlabel.TabIndex = 13;
            this.nachlabel.Text = "Nach:";
            // 
            // Form1
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
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "ÖV-App";
     
            ((System.ComponentModel.ISupportInitialize)(this.Verbindungendatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private ContextMenuStrip contextMenuStrip1;
        private Button abfahrtsplanbtn;
        private Button verbindungSuchenbtn;
        private Button stationSuchenbtn;
        private Button sucheVerbindungbtn;
        private DataGridViewTextBoxColumn gleis;
        private DataGridViewTextBoxColumn ankunft;
        private DataGridViewTextBoxColumn abreise;
        private DataGridViewTextBoxColumn endStation;
        private DataGridViewTextBoxColumn startStation;
        private DataGridView Verbindungendatagrid;
        private ComboBox nachInputcmbx;
        private ComboBox vonInputcmbx;
        private Label vonlabel;
        private Label nachlabel;
    }
}
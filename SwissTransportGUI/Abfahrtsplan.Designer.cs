namespace SwissTransportGUI
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
            this.vonlabel = new System.Windows.Forms.Label();
            this.ortInputcmbx = new System.Windows.Forms.ComboBox();
            this.abfahrtsPlanShowbtn = new System.Windows.Forms.Button();
            this.abfahrtPlandatagrid = new System.Windows.Forms.DataGridView();
            this.startStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abreise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.abfahrtPlandatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // vonlabel
            // 
            this.vonlabel.AutoSize = true;
            this.vonlabel.Location = new System.Drawing.Point(208, 201);
            this.vonlabel.Name = "vonlabel";
            this.vonlabel.Size = new System.Drawing.Size(47, 25);
            this.vonlabel.TabIndex = 14;
            this.vonlabel.Text = "Von:";
            // 
            // ortInputcmbx
            // 
            this.ortInputcmbx.FormattingEnabled = true;
            this.ortInputcmbx.Location = new System.Drawing.Point(261, 198);
            this.ortInputcmbx.Name = "ortInputcmbx";
            this.ortInputcmbx.Size = new System.Drawing.Size(254, 33);
            this.ortInputcmbx.TabIndex = 13;
            // 
            // abfahrtsPlanShowbtn
            // 
            this.abfahrtsPlanShowbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abfahrtsPlanShowbtn.Location = new System.Drawing.Point(562, 198);
            this.abfahrtsPlanShowbtn.Name = "abfahrtsPlanShowbtn";
            this.abfahrtsPlanShowbtn.Size = new System.Drawing.Size(244, 40);
            this.abfahrtsPlanShowbtn.TabIndex = 15;
            this.abfahrtsPlanShowbtn.Text = "Abfahrtsplan anzeigen";
            this.abfahrtsPlanShowbtn.UseVisualStyleBackColor = true;
            this.abfahrtsPlanShowbtn.Click += new System.EventHandler(this.abfahrtsPlanShowbtn_Click);
            // 
            // abfahrtPlandatagrid
            // 
            this.abfahrtPlandatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abfahrtPlandatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startStation,
            this.endStation,
            this.abreise,
            this.ankunft});
            this.abfahrtPlandatagrid.Location = new System.Drawing.Point(106, 341);
            this.abfahrtPlandatagrid.Name = "abfahrtPlandatagrid";
            this.abfahrtPlandatagrid.RowHeadersVisible = false;
            this.abfahrtPlandatagrid.RowHeadersWidth = 62;
            this.abfahrtPlandatagrid.RowTemplate.Height = 33;
            this.abfahrtPlandatagrid.Size = new System.Drawing.Size(810, 272);
            this.abfahrtPlandatagrid.TabIndex = 16;
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
            // Abfahrtsplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 673);
            this.Controls.Add(this.abfahrtPlandatagrid);
            this.Controls.Add(this.abfahrtsPlanShowbtn);
            this.Controls.Add(this.vonlabel);
            this.Controls.Add(this.ortInputcmbx);
            this.Name = "Abfahrtsplan";
            this.Text = "Abfahrtsplan";
            ((System.ComponentModel.ISupportInitialize)(this.abfahrtPlandatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label vonlabel;
        private ComboBox ortInputcmbx;
        private Button abfahrtsPlanShowbtn;
        private DataGridView abfahrtPlandatagrid;
        private DataGridViewTextBoxColumn startStation;
        private DataGridViewTextBoxColumn endStation;
        private DataGridViewTextBoxColumn abreise;
        private DataGridViewTextBoxColumn ankunft;
    }
}
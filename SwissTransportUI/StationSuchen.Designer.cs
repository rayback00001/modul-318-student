namespace SwissTransportUI
{
    partial class StationSuchen
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
            this.vonInputcmbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // vonInputcmbx
            // 
            this.vonInputcmbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.vonInputcmbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.vonInputcmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.vonInputcmbx.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vonInputcmbx.FormattingEnabled = true;
            this.vonInputcmbx.ItemHeight = 50;
            this.vonInputcmbx.Location = new System.Drawing.Point(218, 120);
            this.vonInputcmbx.Name = "vonInputcmbx";
            this.vonInputcmbx.Size = new System.Drawing.Size(278, 56);
            this.vonInputcmbx.TabIndex = 2;
            // 
            // StationSuchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 553);
            this.Controls.Add(this.vonInputcmbx);
            this.Name = "StationSuchen";
            this.Text = "StationSuchen";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox vonInputcmbx;
    }
}
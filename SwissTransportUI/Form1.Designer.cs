namespace SwissTransportUI
{
    partial class menueForms
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
            this.verbindungSuchenButton = new System.Windows.Forms.Button();
            this.stationSuchenButton = new System.Windows.Forms.Button();
            this.abfahrtsplanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // verbindungSuchenButton
            // 
            this.verbindungSuchenButton.Location = new System.Drawing.Point(12, 552);
            this.verbindungSuchenButton.Name = "verbindungSuchenButton";
            this.verbindungSuchenButton.Size = new System.Drawing.Size(383, 87);
            this.verbindungSuchenButton.TabIndex = 0;
            this.verbindungSuchenButton.Text = "Verbindung suchen";
            this.verbindungSuchenButton.UseVisualStyleBackColor = true;
            this.verbindungSuchenButton.Click += new System.EventHandler(this.verbindungSuchenButton_Click);
            // 
            // stationSuchenButton
            // 
            this.stationSuchenButton.Location = new System.Drawing.Point(405, 552);
            this.stationSuchenButton.Name = "stationSuchenButton";
            this.stationSuchenButton.Size = new System.Drawing.Size(383, 87);
            this.stationSuchenButton.TabIndex = 1;
            this.stationSuchenButton.Text = "Station suchen";
            this.stationSuchenButton.UseVisualStyleBackColor = true;
            this.stationSuchenButton.Click += new System.EventHandler(this.stationSuchenButton_Click);
            // 
            // abfahrtsplanButton
            // 
            this.abfahrtsplanButton.Location = new System.Drawing.Point(12, 645);
            this.abfahrtsplanButton.Name = "abfahrtsplanButton";
            this.abfahrtsplanButton.Size = new System.Drawing.Size(776, 87);
            this.abfahrtsplanButton.TabIndex = 2;
            this.abfahrtsplanButton.Text = "Abfahrtsplan";
            this.abfahrtsplanButton.UseVisualStyleBackColor = true;
            this.abfahrtsplanButton.Click += new System.EventHandler(this.abfahrtsplanButton_Click);
            // 
            // menueForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 744);
            this.Controls.Add(this.abfahrtsplanButton);
            this.Controls.Add(this.stationSuchenButton);
            this.Controls.Add(this.verbindungSuchenButton);
            this.Name = "menueForms";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button verbindungSuchenButton;
        private Button stationSuchenButton;
        private Button abfahrtsplanButton;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menueForms));
            this.verbindungSuchenButton = new System.Windows.Forms.Button();
            this.stationSuchenButton = new System.Windows.Forms.Button();
            this.abfahrtsplanButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(709, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(78)))), ((int)(((byte)(142)))));
            this.label1.Location = new System.Drawing.Point(39, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "öV Minus";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
           
            // 
            // menueForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(800, 744);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.abfahrtsplanButton);
            this.Controls.Add(this.stationSuchenButton);
            this.Controls.Add(this.verbindungSuchenButton);
            this.MaximumSize = new System.Drawing.Size(822, 800);
            this.MinimumSize = new System.Drawing.Size(822, 800);
            this.Name = "menueForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖV-Menü ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button verbindungSuchenButton;
        private Button stationSuchenButton;
        private Button abfahrtsplanButton;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
    }
}
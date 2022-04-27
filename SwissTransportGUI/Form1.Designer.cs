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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.verbindungSuchenbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Verbindung suchen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(285, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Station suchen";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(467, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "Abfahrtsplan";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // verbindungSuchenbtn
            // 
            this.verbindungSuchenbtn.Location = new System.Drawing.Point(510, 182);
            this.verbindungSuchenbtn.Name = "verbindungSuchenbtn";
            this.verbindungSuchenbtn.Size = new System.Drawing.Size(203, 34);
            this.verbindungSuchenbtn.TabIndex = 4;
            this.verbindungSuchenbtn.Text = "Suche Verbindung";
            this.verbindungSuchenbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.verbindungSuchenbtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "ÖV-App";
            this.ResumeLayout(false);

        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button4;
        private Button verbindungSuchenbtn;
    }
}
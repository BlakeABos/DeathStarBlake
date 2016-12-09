namespace DeathStarBlake
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.transmissionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // transmissionLabel
            // 
            this.transmissionLabel.BackColor = System.Drawing.SystemColors.Window;
            this.transmissionLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transmissionLabel.ForeColor = System.Drawing.Color.Black;
            this.transmissionLabel.Location = new System.Drawing.Point(117, 280);
            this.transmissionLabel.Name = "transmissionLabel";
            this.transmissionLabel.Size = new System.Drawing.Size(305, 53);
            this.transmissionLabel.TabIndex = 1;
            this.transmissionLabel.Text = "   Transmission incoming! Click anywhere to continue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(529, 422);
            this.Controls.Add(this.transmissionLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Blow Up The Death Star";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label transmissionLabel;
    }
}


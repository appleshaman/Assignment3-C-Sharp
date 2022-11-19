namespace assignment3For158212
{
    partial class Tip
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
            this.Tip1OfTip = new System.Windows.Forms.Label();
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tip1OfTip
            // 
            this.Tip1OfTip.AutoSize = true;
            this.Tip1OfTip.Location = new System.Drawing.Point(12, 38);
            this.Tip1OfTip.Name = "Tip1OfTip";
            this.Tip1OfTip.Size = new System.Drawing.Size(0, 15);
            this.Tip1OfTip.TabIndex = 0;
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(102, 154);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(75, 23);
            this.YesButton.TabIndex = 1;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(269, 154);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(75, 23);
            this.NoButton.TabIndex = 2;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // Tip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 241);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.Tip1OfTip);
            this.Name = "Tip";
            this.Text = "Tip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tip1OfTip;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
    }
}
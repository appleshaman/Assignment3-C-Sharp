namespace assignment3For158212
{
    partial class MainForm
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
            this.MyOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MySaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ageGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EventRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EventLable = new System.Windows.Forms.Label();
            this.SaveAllTeamsAndPlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAllTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAllPlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MainFormMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.chartToolStripMenuItem,
            this.SearchToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.listToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.Size = new System.Drawing.Size(800, 28);
            this.MainFormMenuStrip.TabIndex = 2;
            this.MainFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveAllTeamsAndPlayersToolStripMenuItem,
            this.SaveAllTeamsToolStripMenuItem,
            this.SaveAllPlayersToolStripMenuItem});
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SaveToolStripMenuItem.Text = "Save";
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.weightToolStripMenuItem,
            this.heightToolStripMenuItem,
            this.ageGroupToolStripMenuItem});
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.chartToolStripMenuItem.Text = "Chart";
            // 
            // weightToolStripMenuItem
            // 
            this.weightToolStripMenuItem.Name = "weightToolStripMenuItem";
            this.weightToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.weightToolStripMenuItem.Text = "Weight";
            this.weightToolStripMenuItem.Click += new System.EventHandler(this.WeightToolStripMenuItem_Click);
            // 
            // heightToolStripMenuItem
            // 
            this.heightToolStripMenuItem.Name = "heightToolStripMenuItem";
            this.heightToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.heightToolStripMenuItem.Text = "Height";
            this.heightToolStripMenuItem.Click += new System.EventHandler(this.HeightToolStripMenuItem_Click);
            // 
            // ageGroupToolStripMenuItem
            // 
            this.ageGroupToolStripMenuItem.Name = "ageGroupToolStripMenuItem";
            this.ageGroupToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ageGroupToolStripMenuItem.Text = "Age Group";
            this.ageGroupToolStripMenuItem.Click += new System.EventHandler(this.AgeGroupToolStripMenuItem_Click);
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayerToolStripMenuItem});
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.SearchToolStripMenuItem.Text = "Search";
            // 
            // PlayerToolStripMenuItem
            // 
            this.PlayerToolStripMenuItem.Name = "PlayerToolStripMenuItem";
            this.PlayerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.PlayerToolStripMenuItem.Text = "Player";
            this.PlayerToolStripMenuItem.Click += new System.EventHandler(this.PlayerToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddPlayersToolStripMenuItem,
            this.AddTeamsToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // AddPlayersToolStripMenuItem
            // 
            this.AddPlayersToolStripMenuItem.Name = "AddPlayersToolStripMenuItem";
            this.AddPlayersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.AddPlayersToolStripMenuItem.Text = "AddPlayers";
            this.AddPlayersToolStripMenuItem.Click += new System.EventHandler(this.AddPlayersToolStripMenuItem_Click);
            // 
            // AddTeamsToolStripMenuItem
            // 
            this.AddTeamsToolStripMenuItem.Name = "AddTeamsToolStripMenuItem";
            this.AddTeamsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.AddTeamsToolStripMenuItem.Text = "AddTeams";
            this.AddTeamsToolStripMenuItem.Click += new System.EventHandler(this.AddTeamsToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerToolStripMenuItem1,
            this.teamsToolStripMenuItem});
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.listToolStripMenuItem.Text = "List";
            // 
            // playerToolStripMenuItem1
            // 
            this.playerToolStripMenuItem1.Name = "playerToolStripMenuItem1";
            this.playerToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.playerToolStripMenuItem1.Text = "Players";
            this.playerToolStripMenuItem1.Click += new System.EventHandler(this.PlayerListToolStripMenuItem_Click);
            // 
            // teamsToolStripMenuItem
            // 
            this.teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            this.teamsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.teamsToolStripMenuItem.Text = "Teams";
            this.teamsToolStripMenuItem.Click += new System.EventHandler(this.TeamsListToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // EventRichTextBox
            // 
            this.EventRichTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.EventRichTextBox.Location = new System.Drawing.Point(50, 78);
            this.EventRichTextBox.Name = "EventRichTextBox";
            this.EventRichTextBox.ReadOnly = true;
            this.EventRichTextBox.Size = new System.Drawing.Size(642, 257);
            this.EventRichTextBox.TabIndex = 3;
            this.EventRichTextBox.Text = "";
            this.EventRichTextBox.WordWrap = false;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(511, 341);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(181, 23);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EventLable
            // 
            this.EventLable.AutoSize = true;
            this.EventLable.Location = new System.Drawing.Point(50, 57);
            this.EventLable.Name = "EventLable";
            this.EventLable.Size = new System.Drawing.Size(87, 15);
            this.EventLable.TabIndex = 5;
            this.EventLable.Text = "Event log:";
            // 
            // SaveAllTeamsAndPlayersToolStripMenuItem
            // 
            this.SaveAllTeamsAndPlayersToolStripMenuItem.Name = "SaveAllTeamsAndPlayersToolStripMenuItem";
            this.SaveAllTeamsAndPlayersToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.SaveAllTeamsAndPlayersToolStripMenuItem.Text = "Save all teams and players";
            this.SaveAllTeamsAndPlayersToolStripMenuItem.Click += new System.EventHandler(this.SaveAllTeamsAndPlayersToolStripMenuItem_Click);
            // 
            // SaveAllTeamsToolStripMenuItem
            // 
            this.SaveAllTeamsToolStripMenuItem.Name = "SaveAllTeamsToolStripMenuItem";
            this.SaveAllTeamsToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.SaveAllTeamsToolStripMenuItem.Text = "Save all teams";
            this.SaveAllTeamsToolStripMenuItem.Click += new System.EventHandler(this.SaveAllTeamsToolStripMenuItem_Click);
            // 
            // SaveAllPlayersToolStripMenuItem
            // 
            this.SaveAllPlayersToolStripMenuItem.Name = "SaveAllPlayersToolStripMenuItem";
            this.SaveAllPlayersToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.SaveAllPlayersToolStripMenuItem.Text = "Save all players";
            this.SaveAllPlayersToolStripMenuItem.Click += new System.EventHandler(this.SaveAllPlayersToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EventLable);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.EventRichTextBox);
            this.Controls.Add(this.MainFormMenuStrip);
            this.MainMenuStrip = this.MainFormMenuStrip;
            this.Name = "MainForm";
            this.Text = "Main";
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog MyOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog MySaveFileDialog;
        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddPlayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddTeamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ageGroupToolStripMenuItem;
        private System.Windows.Forms.RichTextBox EventRichTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label EventLable;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAllTeamsAndPlayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAllTeamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAllPlayersToolStripMenuItem;
    }
}


namespace assignment3For158212
{
    partial class SearchResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchResult));
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.TipForSearching = new System.Windows.Forms.Label();
            this.ListOfPlayer = new System.Windows.Forms.ListView();
            this.NameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeamColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AgeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BornPlaceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WeightColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeightColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            resources.ApplyResources(this.SearchTextBox, "SearchTextBox");
            this.SearchTextBox.Name = "SearchTextBox";
            // 
            // SearchButton
            // 
            resources.ApplyResources(this.SearchButton, "SearchButton");
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // TipForSearching
            // 
            resources.ApplyResources(this.TipForSearching, "TipForSearching");
            this.TipForSearching.Name = "TipForSearching";
            // 
            // ListOfPlayer
            // 
            this.ListOfPlayer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumnHeader,
            this.TeamColumnHeader,
            this.IDColumnHeader,
            this.AgeColumnHeader,
            this.BornPlaceColumnHeader,
            this.WeightColumnHeader,
            this.HeightColumnHeader});
            this.ListOfPlayer.FullRowSelect = true;
            this.ListOfPlayer.GridLines = true;
            this.ListOfPlayer.HideSelection = false;
            resources.ApplyResources(this.ListOfPlayer, "ListOfPlayer");
            this.ListOfPlayer.Name = "ListOfPlayer";
            this.ListOfPlayer.UseCompatibleStateImageBehavior = false;
            this.ListOfPlayer.View = System.Windows.Forms.View.Details;
            // 
            // NameColumnHeader
            // 
            resources.ApplyResources(this.NameColumnHeader, "NameColumnHeader");
            // 
            // TeamColumnHeader
            // 
            resources.ApplyResources(this.TeamColumnHeader, "TeamColumnHeader");
            // 
            // IDColumnHeader
            // 
            resources.ApplyResources(this.IDColumnHeader, "IDColumnHeader");
            // 
            // AgeColumnHeader
            // 
            resources.ApplyResources(this.AgeColumnHeader, "AgeColumnHeader");
            // 
            // BornPlaceColumnHeader
            // 
            resources.ApplyResources(this.BornPlaceColumnHeader, "BornPlaceColumnHeader");
            // 
            // WeightColumnHeader
            // 
            resources.ApplyResources(this.WeightColumnHeader, "WeightColumnHeader");
            // 
            // HeightColumnHeader
            // 
            resources.ApplyResources(this.HeightColumnHeader, "HeightColumnHeader");
            // 
            // SearchResult
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListOfPlayer);
            this.Controls.Add(this.TipForSearching);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Name = "SearchResult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label TipForSearching;
        private System.Windows.Forms.ListView ListOfPlayer;
        private System.Windows.Forms.ColumnHeader NameColumnHeader;
        private System.Windows.Forms.ColumnHeader TeamColumnHeader;
        private System.Windows.Forms.ColumnHeader IDColumnHeader;
        private System.Windows.Forms.ColumnHeader AgeColumnHeader;
        private System.Windows.Forms.ColumnHeader BornPlaceColumnHeader;
        private System.Windows.Forms.ColumnHeader WeightColumnHeader;
        private System.Windows.Forms.ColumnHeader HeightColumnHeader;
    }
}
namespace assignment3For158212
{
    partial class ListOfPOrT
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
            this.ListViewForTOrP = new System.Windows.Forms.ListView();
            this.IDOrNumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeamOrGroundColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BirthDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BornPlaceOrCoachColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListNameLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListViewForTOrP
            // 
            this.ListViewForTOrP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumnHeader,
            this.IDOrNumberColumnHeader,
            this.TeamOrGroundColumnHeader,
            this.BirthDateColumnHeader,
            this.BornPlaceOrCoachColumnHeader});
            this.ListViewForTOrP.FullRowSelect = true;
            this.ListViewForTOrP.GridLines = true;
            this.ListViewForTOrP.HideSelection = false;
            this.ListViewForTOrP.Location = new System.Drawing.Point(12, 27);
            this.ListViewForTOrP.Name = "ListViewForTOrP";
            this.ListViewForTOrP.Size = new System.Drawing.Size(775, 399);
            this.ListViewForTOrP.TabIndex = 0;
            this.ListViewForTOrP.UseCompatibleStateImageBehavior = false;
            this.ListViewForTOrP.View = System.Windows.Forms.View.Details;
            this.ListViewForTOrP.SelectedIndexChanged += new System.EventHandler(this.ListViewForTOrP_SelectedIndexChanged);
            // 
            // IDOrNumberColumnHeader
            // 
            this.IDOrNumberColumnHeader.Text = "ID";
            this.IDOrNumberColumnHeader.Width = 105;
            // 
            // NameColumnHeader
            // 
            this.NameColumnHeader.Text = "Name";
            this.NameColumnHeader.Width = 130;
            // 
            // TeamOrGroundColumnHeader
            // 
            this.TeamOrGroundColumnHeader.Text = "Team";
            this.TeamOrGroundColumnHeader.Width = 86;
            // 
            // BirthDateColumnHeader
            // 
            this.BirthDateColumnHeader.Text = "BirthDate";
            this.BirthDateColumnHeader.Width = 206;
            // 
            // BornPlaceOrCoachColumnHeader
            // 
            this.BornPlaceOrCoachColumnHeader.Text = "BornPlace";
            this.BornPlaceOrCoachColumnHeader.Width = 242;
            // 
            // ListNameLable
            // 
            this.ListNameLable.AutoSize = true;
            this.ListNameLable.Location = new System.Drawing.Point(22, 9);
            this.ListNameLable.Name = "ListNameLable";
            this.ListNameLable.Size = new System.Drawing.Size(0, 15);
            this.ListNameLable.TabIndex = 1;
            // 
            // ListOfPOrT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListNameLable);
            this.Controls.Add(this.ListViewForTOrP);
            this.Name = "ListOfPOrT";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListViewForTOrP;
        private System.Windows.Forms.Label ListNameLable;
        private System.Windows.Forms.ColumnHeader IDOrNumberColumnHeader;
        private System.Windows.Forms.ColumnHeader NameColumnHeader;
        private System.Windows.Forms.ColumnHeader TeamOrGroundColumnHeader;
        private System.Windows.Forms.ColumnHeader BirthDateColumnHeader;
        private System.Windows.Forms.ColumnHeader BornPlaceOrCoachColumnHeader;
    }
}
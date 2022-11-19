namespace assignment3For158212
{
    partial class Chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PlayerChartOne = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerChartOne)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerChartOne
            // 
            chartArea1.Name = "ChartArea1";
            this.PlayerChartOne.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PlayerChartOne.Legends.Add(legend1);
            this.PlayerChartOne.Location = new System.Drawing.Point(1, -1);
            this.PlayerChartOne.Name = "PlayerChartOne";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.PlayerChartOne.Series.Add(series1);
            this.PlayerChartOne.Size = new System.Drawing.Size(799, 452);
            this.PlayerChartOne.TabIndex = 0;
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayerChartOne);
            this.Name = "Chart";
            this.Text = "Chart";
            ((System.ComponentModel.ISupportInitialize)(this.PlayerChartOne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart PlayerChartOne;
    }
}
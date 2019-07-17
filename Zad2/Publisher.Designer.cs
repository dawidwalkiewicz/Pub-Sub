namespace PracaMagisterskaPublisher
{
    partial class PracaMagisterskaPublisher
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.ProcessorDataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RAMDataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DiskDataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PageFileDataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ComputerNameLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ComputerNameTextBox = new System.Windows.Forms.TextBox();
            this.DisconnectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessorDataChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAMDataChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiskDataChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageFileDataChart)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(61, 138);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1117, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(17, 231);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(1161, 23);
            this.progressBar2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "0%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "0 MB";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Time1_tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Działanie procesora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dostępna pamięć";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Użycie dysku";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "0%";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(16, 316);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(1162, 23);
            this.progressBar3.TabIndex = 9;
            // 
            // ProcessorDataChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ProcessorDataChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ProcessorDataChart.Legends.Add(legend1);
            this.ProcessorDataChart.Location = new System.Drawing.Point(12, 451);
            this.ProcessorDataChart.Name = "ProcessorDataChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Processor";
            this.ProcessorDataChart.Series.Add(series1);
            this.ProcessorDataChart.Size = new System.Drawing.Size(387, 167);
            this.ProcessorDataChart.TabIndex = 10;
            this.ProcessorDataChart.Text = "Processor Data Chart";
            // 
            // RAMDataChart
            // 
            chartArea2.Name = "ChartArea1";
            this.RAMDataChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.RAMDataChart.Legends.Add(legend2);
            this.RAMDataChart.Location = new System.Drawing.Point(405, 451);
            this.RAMDataChart.Name = "RAMDataChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Red;
            series2.Name = "RAM";
            this.RAMDataChart.Series.Add(series2);
            this.RAMDataChart.Size = new System.Drawing.Size(387, 167);
            this.RAMDataChart.TabIndex = 11;
            this.RAMDataChart.Text = "RAM Data Chart";
            // 
            // DiskDataChart
            // 
            chartArea3.Name = "ChartArea1";
            this.DiskDataChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.DiskDataChart.Legends.Add(legend3);
            this.DiskDataChart.Location = new System.Drawing.Point(798, 451);
            this.DiskDataChart.Name = "DiskDataChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Disk";
            this.DiskDataChart.Series.Add(series3);
            this.DiskDataChart.Size = new System.Drawing.Size(387, 167);
            this.DiskDataChart.TabIndex = 12;
            this.DiskDataChart.Text = "Disk Data Chart";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(16, 410);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(1162, 23);
            this.progressBar4.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "0%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Wykorzystanie pliku stronicowania";
            // 
            // PageFileDataChart
            // 
            chartArea4.Name = "ChartArea1";
            this.PageFileDataChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.PageFileDataChart.Legends.Add(legend4);
            this.PageFileDataChart.Location = new System.Drawing.Point(407, 624);
            this.PageFileDataChart.Name = "PageFileDataChart";
            series4.BorderColor = System.Drawing.Color.DarkGoldenrod;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Paging File";
            this.PageFileDataChart.Series.Add(series4);
            this.PageFileDataChart.Size = new System.Drawing.Size(387, 167);
            this.PageFileDataChart.TabIndex = 16;
            this.PageFileDataChart.Text = "Page File Data Chart";
            // 
            // ComputerNameLabel
            // 
            this.ComputerNameLabel.AutoSize = true;
            this.ComputerNameLabel.Location = new System.Drawing.Point(15, 9);
            this.ComputerNameLabel.Name = "ComputerNameLabel";
            this.ComputerNameLabel.Size = new System.Drawing.Size(129, 17);
            this.ComputerNameLabel.TabIndex = 20;
            this.ComputerNameLabel.Text = "Nazwa komputera: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(360, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Adres serwera:";
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.Location = new System.Drawing.Point(363, 64);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.Size = new System.Drawing.Size(333, 22);
            this.ServerTextBox.TabIndex = 22;
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(720, 64);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(289, 22);
            this.LocationTextBox.TabIndex = 24;
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(717, 43);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(82, 17);
            this.LocationLabel.TabIndex = 23;
            this.LocationLabel.Text = "Lokalizacja:";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(1056, 43);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(122, 23);
            this.ConnectButton.TabIndex = 25;
            this.ConnectButton.Text = "Połącz";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ComputerNameTextBox
            // 
            this.ComputerNameTextBox.Location = new System.Drawing.Point(18, 64);
            this.ComputerNameTextBox.Name = "ComputerNameTextBox";
            this.ComputerNameTextBox.Size = new System.Drawing.Size(289, 22);
            this.ComputerNameTextBox.TabIndex = 26;
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(1056, 72);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(122, 23);
            this.DisconnectButton.TabIndex = 27;
            this.DisconnectButton.Text = "Rozłącz";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // PracaMagisterskaPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 803);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ComputerNameTextBox);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.LocationTextBox);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.ServerTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ComputerNameLabel);
            this.Controls.Add(this.PageFileDataChart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DiskDataChart);
            this.Controls.Add(this.RAMDataChart);
            this.Controls.Add(this.ProcessorDataChart);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Name = "PracaMagisterskaPublisher";
            this.Text = "Publisher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessorDataChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAMDataChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiskDataChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageFileDataChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.DataVisualization.Charting.Chart ProcessorDataChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart RAMDataChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart DiskDataChart;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart PageFileDataChart;
        private System.Windows.Forms.Label ComputerNameLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ServerTextBox;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox ComputerNameTextBox;
        private System.Windows.Forms.Button DisconnectButton;
    }
}


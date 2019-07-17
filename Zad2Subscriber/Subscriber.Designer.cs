namespace PracaMagisterskaSubscriber
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComputersLabel = new System.Windows.Forms.Label();
            this.computersDataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.computersDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(830, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(681, 607);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dane komputerów";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1170, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Komunikaty";
            // 
            // ComputersLabel
            // 
            this.ComputersLabel.AutoSize = true;
            this.ComputersLabel.Location = new System.Drawing.Point(13, 48);
            this.ComputersLabel.Name = "ComputersLabel";
            this.ComputersLabel.Size = new System.Drawing.Size(156, 17);
            this.ComputersLabel.TabIndex = 7;
            this.ComputersLabel.Text = "Podłączone komputery:";
            // 
            // computersDataGridView1
            // 
            this.computersDataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.computersDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.computersDataGridView1.Location = new System.Drawing.Point(2, 84);
            this.computersDataGridView1.Name = "computersDataGridView1";
            this.computersDataGridView1.RowTemplate.Height = 24;
            this.computersDataGridView1.Size = new System.Drawing.Size(822, 560);
            this.computersDataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1523, 656);
            this.Controls.Add(this.computersDataGridView1);
            this.Controls.Add(this.ComputersLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.MinimumSize = new System.Drawing.Size(1541, 497);
            this.Name = "Form1";
            this.Text = "Subscriber";
            ((System.ComponentModel.ISupportInitialize)(this.computersDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ComputersLabel;
        private System.Windows.Forms.DataGridView computersDataGridView1;
    }
}


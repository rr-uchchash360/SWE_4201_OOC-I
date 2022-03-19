namespace File_Handling_in_CS
{
    partial class DataBook
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
            this.CSVFile = new System.Windows.Forms.ListBox();
            this.queryDataListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CSVFile
            // 
            this.CSVFile.FormattingEnabled = true;
            this.CSVFile.Location = new System.Drawing.Point(218, 12);
            this.CSVFile.Name = "CSVFile";
            this.CSVFile.Size = new System.Drawing.Size(559, 173);
            this.CSVFile.TabIndex = 11;
            // 
            // queryDataListBox
            // 
            this.queryDataListBox.FormattingEnabled = true;
            this.queryDataListBox.Location = new System.Drawing.Point(18, 98);
            this.queryDataListBox.Name = "queryDataListBox";
            this.queryDataListBox.Size = new System.Drawing.Size(176, 82);
            this.queryDataListBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data Book";
            // 
            // searchIDTextBox
            // 
            this.searchIDTextBox.Location = new System.Drawing.Point(94, 43);
            this.searchIDTextBox.Name = "searchIDTextBox";
            this.searchIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchIDTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee ID :";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(18, 69);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(176, 23);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // DataBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 204);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.CSVFile);
            this.Controls.Add(this.queryDataListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchIDTextBox);
            this.Controls.Add(this.label1);
            this.Name = "DataBook";
            this.Text = "Data Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CSVFile;
        private System.Windows.Forms.ListBox queryDataListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
    }
}


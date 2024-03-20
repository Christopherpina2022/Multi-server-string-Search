namespace search_script
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
            this.label1 = new System.Windows.Forms.Label();
            this.bulkGroup = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.fileText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchItem = new System.Windows.Forms.TextBox();
            this.manualSearch = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.manualCombo = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importServerNames = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.extensionListBox = new System.Windows.Forms.ListBox();
            this.checkNoFilter = new System.Windows.Forms.CheckBox();
            this.bulkRadio = new System.Windows.Forms.RadioButton();
            this.singleRadio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.bulkGroup.SuspendLayout();
            this.manualSearch.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Step 2: Select method to search item";
            // 
            // bulkGroup
            // 
            this.bulkGroup.Controls.Add(this.linkLabel1);
            this.bulkGroup.Controls.Add(this.label4);
            this.bulkGroup.Controls.Add(this.browseButton);
            this.bulkGroup.Controls.Add(this.fileText);
            this.bulkGroup.Location = new System.Drawing.Point(35, 155);
            this.bulkGroup.Name = "bulkGroup";
            this.bulkGroup.Size = new System.Drawing.Size(420, 81);
            this.bulkGroup.TabIndex = 4;
            this.bulkGroup.TabStop = false;
            this.bulkGroup.Text = "Bulk Execute";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(9, 55);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "CSV File Format";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Looks up multiple servers via a formatted CSV file.";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(273, 29);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(113, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // fileText
            // 
            this.fileText.Location = new System.Drawing.Point(6, 32);
            this.fileText.Name = "fileText";
            this.fileText.Size = new System.Drawing.Size(210, 20);
            this.fileText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Step 1: Select what is needed to be searched";
            // 
            // searchItem
            // 
            this.searchItem.Location = new System.Drawing.Point(41, 92);
            this.searchItem.Name = "searchItem";
            this.searchItem.Size = new System.Drawing.Size(210, 20);
            this.searchItem.TabIndex = 0;
            // 
            // manualSearch
            // 
            this.manualSearch.Controls.Add(this.label10);
            this.manualSearch.Controls.Add(this.manualCombo);
            this.manualSearch.Enabled = false;
            this.manualSearch.Location = new System.Drawing.Point(35, 242);
            this.manualSearch.Name = "manualSearch";
            this.manualSearch.Size = new System.Drawing.Size(420, 66);
            this.manualSearch.TabIndex = 10;
            this.manualSearch.TabStop = false;
            this.manualSearch.Text = "Single Server";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(401, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Looks up a single server. A custom list can also be setup with the above menu ite" +
    "m.";
            // 
            // manualCombo
            // 
            this.manualCombo.FormattingEnabled = true;
            this.manualCombo.Location = new System.Drawing.Point(9, 32);
            this.manualCombo.Name = "manualCombo";
            this.manualCombo.Size = new System.Drawing.Size(207, 21);
            this.manualCombo.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importServerNames,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importServerNames
            // 
            this.importServerNames.Name = "importServerNames";
            this.importServerNames.Size = new System.Drawing.Size(130, 20);
            this.importServerNames.Text = "Import Server Names";
            this.importServerNames.Click += new System.EventHandler(this.importServerNames_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.extensionListBox);
            this.groupBox1.Controls.Add(this.checkNoFilter);
            this.groupBox1.Location = new System.Drawing.Point(15, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 107);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Extension Filter";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(293, 42);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(120, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Start Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // extensionListBox
            // 
            this.extensionListBox.FormattingEnabled = true;
            this.extensionListBox.Items.AddRange(new object[] {
            ".xml",
            ".csv",
            ".dll",
            ".pdb",
            ".json",
            ".exe"});
            this.extensionListBox.Location = new System.Drawing.Point(12, 19);
            this.extensionListBox.Name = "extensionListBox";
            this.extensionListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.extensionListBox.Size = new System.Drawing.Size(265, 82);
            this.extensionListBox.TabIndex = 4;
            // 
            // checkNoFilter
            // 
            this.checkNoFilter.AutoSize = true;
            this.checkNoFilter.Location = new System.Drawing.Point(293, 19);
            this.checkNoFilter.Name = "checkNoFilter";
            this.checkNoFilter.Size = new System.Drawing.Size(65, 17);
            this.checkNoFilter.TabIndex = 5;
            this.checkNoFilter.Text = "No Filter";
            this.checkNoFilter.UseVisualStyleBackColor = true;
            this.checkNoFilter.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // bulkRadio
            // 
            this.bulkRadio.AutoSize = true;
            this.bulkRadio.Checked = true;
            this.bulkRadio.Location = new System.Drawing.Point(15, 187);
            this.bulkRadio.Name = "bulkRadio";
            this.bulkRadio.Size = new System.Drawing.Size(14, 13);
            this.bulkRadio.TabIndex = 1;
            this.bulkRadio.TabStop = true;
            this.bulkRadio.UseVisualStyleBackColor = true;
            this.bulkRadio.CheckedChanged += new System.EventHandler(this.bulkRadio_CheckedChanged);
            // 
            // singleRadio
            // 
            this.singleRadio.AutoSize = true;
            this.singleRadio.Location = new System.Drawing.Point(15, 274);
            this.singleRadio.Name = "singleRadio";
            this.singleRadio.Size = new System.Drawing.Size(14, 13);
            this.singleRadio.TabIndex = 4;
            this.singleRadio.UseVisualStyleBackColor = true;
            this.singleRadio.CheckedChanged += new System.EventHandler(this.singleRadio_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Step 3: Choose filters";
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.Location = new System.Drawing.Point(16, 510);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(324, 13);
            this.resultsLabel.TabIndex = 16;
            this.resultsLabel.Text = "Click Start Search to get your list returned to a CSV File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 545);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.singleRadio);
            this.Controls.Add(this.bulkRadio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.manualSearch);
            this.Controls.Add(this.searchItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bulkGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Server String Lookup";
            this.bulkGroup.ResumeLayout(false);
            this.bulkGroup.PerformLayout();
            this.manualSearch.ResumeLayout(false);
            this.manualSearch.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox bulkGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchItem;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox fileText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox manualSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importServerNames;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ComboBox manualCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkNoFilter;
        public System.Windows.Forms.ListBox extensionListBox;
        private System.Windows.Forms.RadioButton bulkRadio;
        private System.Windows.Forms.RadioButton singleRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label resultsLabel;
    }
}


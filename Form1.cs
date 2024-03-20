using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Security.Principal;

namespace search_script
{
    public partial class Form1 : Form
    {
        // Declare selected items which will update when an item is selected
        public List<object> selectedItems = new List<object>();
        public bool noFilterChecked = false;

        public Form1()
        {
            // Check if the user is an administrator
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);

            bool isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);

            if (!isAdmin)
            {
                MessageBox.Show("Please execute this app as an admin for the app to work correctly.");
            }
            
            // Starts the application
            InitializeComponent();

            // setup combobox to have default server list
            string scriptFile = "defaultServers.csv";
            string scriptPath = Path.GetFullPath(scriptFile);
            manualCombo.DataSource = singleServerComboUpdate(scriptPath);
        }

        private List<string> singleServerComboUpdate(string csvFile)
        {
            // Declare new string list then iterate every item based off of what file was called to the function
            List <string> serverLoad = new List<string>();
            using (StreamReader reader = new StreamReader(csvFile))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    serverLoad.Add(line);
                }
            }
            return serverLoad;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Server List Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                fileText.Text = fileDialog.FileName;
            }
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormatForm newForm = new FormatForm();
            newForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 AboutBox1 = new AboutBox1();
            AboutBox1.ShowDialog();
        }

        private void importServerNames_Click(object sender, EventArgs e)
        {
            string defaultLookup = "/ServerFiles";
            string scriptPath = Path.GetFullPath(defaultLookup);

            OpenFileDialog fileDialog = new OpenFileDialog
            {
                InitialDirectory = scriptPath,
                Title = "Server List Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                manualCombo.DataSource = singleServerComboUpdate(fileDialog.FileName);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNoFilter.Checked == true)
            {
                extensionListBox.Enabled = false;
                noFilterChecked = true;
            }
            else
            {
                extensionListBox.Enabled = true;
                noFilterChecked = false;
            }
        }

        private void bulkRadio_CheckedChanged(object sender, EventArgs e)
        {
            manualSearch.Enabled = false;
            bulkGroup.Enabled = true;
        }

        private void singleRadio_CheckedChanged(object sender, EventArgs e)
        {
            manualSearch.Enabled = true;
            bulkGroup.Enabled = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A powershell script will pop up now. if at any time you need to cancel, close the pop up.");
            List<string> selectedExtensions = new List<string>();

            var selectedItems = extensionListBox.SelectedItems;

            foreach (var item in selectedItems)
            {
                selectedExtensions.Add(item.ToString());
            }

            // Check if there is text in the search text box
            if (searchItem.Text == "" || bulkRadio.Checked == true && fileText.Text == "")
            {
                resultsLabel.Text = "Results failed, try inputting a string to lookup or load a proper file.";
                return;
            }

            SearchString searchString = new SearchString();

            // Execute search function based on what radio button was checked
            if (bulkRadio.Checked == true)
            {
                resultsLabel.Text = "Looking for " + searchItem.Text + " in multiple servers...";
                List<string> serverList = readCSV(fileText.Text);
                foreach (var item in serverList)
                {
                    searchString.ExecuteScript(searchItem.Text, item);
                    searchString.filterFile(selectedExtensions, item, noFilterChecked);
                }
                resultsLabel.Text = "Results complete, file saved to ./results/{Server Name}";
            }

            if (singleRadio.Checked == true)
            {
                resultsLabel.Text = "Looking for " + searchItem.Text + " in server " + manualCombo.Text + "...";
                searchString.ExecuteScript(searchItem.Text, manualCombo.Text);
                searchString.filterFile(selectedExtensions, manualCombo.Text, noFilterChecked);
                resultsLabel.Text = "Results complete, file saved to ./results/{Server Name}";
            }
        }

        public List<string> readCSV(string serverFile)
        {
            List<string> serverList = new List<string>();
            string[] servers = File.ReadAllLines(serverFile);
            for (int i = 0; i < servers.Length; i++)
            {
                string[] items = servers[i].Split(',');
                for (int j = 0; j < items.Length; j++)
                {
                    serverList.Add(j.ToString());     
                }
            }
            return serverList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CreativeArtReach_InventoryManagement
{
    public partial class FindPage : Form
    {
        // Paths to the files
        private readonly string suppliesFilePath = @"C:\Users\writi\source\repos\CreativeArtReach_InventoryManagement\supplies.csv";
        private readonly string projectsFilePath = @"C:\Users\writi\source\repos\CreativeArtReach_InventoryManagement\projects.csv";

        // Dictionaries to store supplies and their quantities
        private Dictionary<string, int> availableSupplies = new Dictionary<string, int>();

        public FindPage()
        {
            InitializeComponent();
        }

        private void FindPage_Load(object sender, EventArgs e)
        {
            txtbxKids.Text = "1";
            LoadSites();      // Load available sites into the ComboBox
            if (combobxSite.Items.Count > 0)
                combobxSite.SelectedIndex = 0;  // Select the first site by default

            LoadSupplies();
            LoadProjects();
        }

        // Load available sites into the ComboBox from the header of the supplies file
        private void LoadSites()
        {
            combobxSite.Items.Clear();  // Clear existing items

            string[] lines = File.ReadAllLines(suppliesFilePath);
            string[] headers = lines[0].Split(',');  // Assume first row contains headers

            // Add site names (starting from the second column, skipping "Supply" header)
            for (int i = 1; i < headers.Length; i++)
            {
                combobxSite.Items.Add(headers[i]);
            }
        }

        // Load supplies for the selected site
        private void LoadSupplies()
        {
            availableSupplies.Clear();  // Clear previous data

            string selectedSite = combobxSite.SelectedItem?.ToString();
            if (selectedSite == null)
            {
                MessageBox.Show("Please select a site.", "Site Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] lines = File.ReadAllLines(suppliesFilePath);
            string[] headers = lines[0].Split(',');
            int siteIndex = Array.IndexOf(headers, selectedSite);  // Find the column for the selected site

            if (siteIndex == -1)
            {
                MessageBox.Show("Selected site not found in the data.", "Site Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var line in lines.Skip(1))  // Skip header row
            {
                var data = line.Split(',');
                string supplyName = data[0];
                int quantity = int.Parse(data[siteIndex]);  // Get quantity for the selected site

                availableSupplies[supplyName] = quantity;
            }
        }

        // Load projects and filter based on available supplies
        private void LoadProjects()
        {
            lstbxProjects.Items.Clear(); // Clear previous entries

            string[] projectLines = File.ReadAllLines(projectsFilePath);
            foreach (var line in projectLines.Skip(1)) // Skip header
            {
                if (CanCompleteProject(line))
                {
                    string projectName = line.Split(',')[0];
                    lstbxProjects.Items.Add(projectName);
                }
            }
        }

        // Check if a project can be completed with available supplies
        private bool CanCompleteProject(string projectData)
        {
            if (!int.TryParse(txtbxKids.Text, out int numberOfKids) || numberOfKids <= 0)
            {
                txtbxKids.Text = "1";
                return false;
            }

            var data = projectData.Split(',');
            for (int i = 1; i < data.Length; i += projectData.Length)
            {
                string supplyName = data[i];
                int baseQuantity = int.Parse(data[i + 1]); // Base quantity per kid
                int requiredQuantity = baseQuantity * numberOfKids;  // Apply multiplier

                // Check if enough supplies are available
                if (!availableSupplies.ContainsKey(supplyName) || availableSupplies[supplyName] < requiredQuantity)
                    return false;
            }
            return true;
        }

        // Display detailed requirements when a project is selected
        private void lstbxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbxProjects.SelectedItem != null)
            {
                string selectedProject = lstbxProjects.SelectedItem.ToString();
                string[] projectLines = File.ReadAllLines(projectsFilePath);

                foreach (var line in projectLines.Skip(1))
                {
                    if (line.StartsWith(selectedProject))
                    {
                        MessageBox.Show($"Project Requirements:\n{line.Replace(",", "\n")}", "Project Details");
                        break;
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbxKids_TextChanged(object sender, EventArgs e)
        {
            LoadProjects();
        }

        private void combobxSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSupplies();
            LoadProjects();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSupplies();
            LoadProjects();
        }
    }
}

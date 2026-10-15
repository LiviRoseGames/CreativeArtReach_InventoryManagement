using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CreativeArtReach_InventoryManagement
{
    public partial class ViewPage : Form
    {
        private readonly string projectsFilePath = @"C:\Users\writi\source\repos\CreativeArtReach_InventoryManagement\projects.csv";
        public ViewPage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadProjects()
        {
            lstbxProjects.Items.Clear();  // Clear previous items

            string[] projectLines = File.ReadAllLines(projectsFilePath);

            // Skip the header row and add each project name to the ListBox
            foreach (var line in projectLines.Skip(1))
            {
                string projectName = line.Split(',')[0];
                lstbxProjects.Items.Add(projectName);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProjects();
        }

        private void txtbxKids_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstbxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbxProjects.SelectedItem != null)
            {
                if (!int.TryParse(txtbxKids.Text, out int numberOfKids) || numberOfKids <= 0)
                {
                    MessageBox.Show("Please enter a valid positive number for the number of kids.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedProject = lstbxProjects.SelectedItem.ToString();
                string[] projectLines = File.ReadAllLines(projectsFilePath);

                foreach (var line in projectLines.Skip(1))
                {
                    if (line.StartsWith(selectedProject + ","))
                    {
                        string[] projectData = line.Split(',');
                        string projectDetails = $"Project: {projectData[0]}\n";

                        // Iterate through supplies and quantities
                        for (int i = 1; i < projectData.Length; i += projectData.Length)
                        {
                            string supplyName = projectData[i];
                            int baseQuantity = int.Parse(projectData[i + 1]); // Base quantity per kid
                            int totalQuantity = baseQuantity * numberOfKids;  // Apply multiplier

                            projectDetails += $"{supplyName}: {totalQuantity}\n";
                        }

                        MessageBox.Show(projectDetails, "Project Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }
        }

        private void ViewPage_Load_1(object sender, EventArgs e)
        {
            txtbxKids.Text = "1";
            LoadProjects();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreativeArtReach_InventoryManagement
{
    public partial class ManagePage : Form
    {
        // Define the file path variable
        private readonly string filePath = @"C:\Users\writi\source\repos\CreativeArtReach_InventoryManagement\supplies.csv";

        public ManagePage()
        {
            InitializeComponent();
        }

        DataTable suppliesTable = new DataTable();

        private void LoadData()
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Supplies data file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Clear existing data to avoid duplicates
            suppliesTable.Clear();

            // Add columns only if they haven't been added yet
            if (suppliesTable.Columns.Count == 0)
            {
                string[] lines = File.ReadAllLines(filePath);
                string[] headers = lines[0].Split(',');

                foreach (string header in headers)
                    suppliesTable.Columns.Add(header);

                for (int i = 1; i < lines.Length; i++)
                    suppliesTable.Rows.Add(lines[i].Split(','));
            }
            else
            {
                // Reload rows if columns are already defined
                string[] lines = File.ReadAllLines(filePath);
                for (int i = 1; i < lines.Length; i++)
                    suppliesTable.Rows.Add(lines[i].Split(','));
            }

            dataGridView1.DataSource = suppliesTable;
        }


        private void SaveData()
        {
            var sb = new StringBuilder();
            var headers = suppliesTable.Columns.Cast<DataColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => column.ColumnName)));

            foreach (DataRow row in suppliesTable.Rows)
                sb.AppendLine(string.Join(",", row.ItemArray));

            File.WriteAllText(filePath, sb.ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagePage_Load(object sender, EventArgs e)
        {
            LoadData();  // Automatically load data when the form opens
            dataGridView1.RowHeadersVisible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Handle cell click events if needed
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreativeArtReach_InventoryManagement
{
    public partial class UpdateSupplyForm : Form
    {
        private string supplyId;
        private int currentQuantity;

        public UpdateSupplyForm(string supplyId, int currentQuantity)
        {
            InitializeComponent();
            this.supplyId = supplyId;
            this.currentQuantity = currentQuantity;

            // Display the current quantity in a TextBox
            //txtbxQuantityAlamo.Text = currentQuantity.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // Assuming you have a method to update the quantity in your database
            //int newQuantity = Convert.ToInt32(txtbxQuantityAlamo.Text);
            //UpdateQuantityInDatabase(supplyId, newQuantity);
            this.Close(); // Close the form after updating
        }

        private void UpdateSupplyForm_Load(object sender, EventArgs e)
        {

        }
    }
}

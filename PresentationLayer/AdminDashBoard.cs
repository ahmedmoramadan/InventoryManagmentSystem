using BLL;
using DAL.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PresentationLayer
{
    public partial class AdminDashBoard : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        SupplierService supplierService;

        public AdminDashBoard()
        {
            InitializeComponent();

            // Apply Material Theme
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey800, Primary.BlueGrey500,
                Accent.LightBlue700, TextShade.WHITE
            );
            supplierService = new SupplierService();
            LoadSuppliers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }














































































































































































































































































































































































        public void LoadSuppliers()
        {
            List<Supplier> suppliers = supplierService.GetAll();

            // Set AutoGenerateColumns to false
            dgv_supplier.AutoGenerateColumns = false;

            // Add columns manually (excluding Id)
            dgv_supplier.Columns.Clear();
            dgv_supplier.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name", DataPropertyName = "Name" });
            dgv_supplier.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Contact", DataPropertyName = "Contact" });
            dgv_supplier.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Address", DataPropertyName = "Address" });

            // Bind the data
            dgv_supplier.DataSource = suppliers;



        }
        public void ResetInputs()
        {
            txt_contact.Text = txt_Address.Text = txt_name.Text = string.Empty;
        }
        public bool CheckEmptyInput(string content, string message)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                MessageBox.Show($"Please enter a supplier {message}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string supplierName = txt_name.Text;
            if (CheckEmptyInput(supplierName, "Name"))
                return;

            string supplierContact = txt_contact.Text;
            if (CheckEmptyInput(supplierContact, "Contact"))
                return;

            string supplierAddress = txt_Address.Text;
            if (CheckEmptyInput(supplierAddress, "Address"))
                return;

            bool isAdded = supplierService.Add(supplierName, supplierAddress, supplierContact);
            if (isAdded)
            {
                MessageBox.Show("Supplier added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSuppliers();
            }
            else
            {
                MessageBox.Show("Failed to add supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ResetInputs();
        }

        private void dgv_supplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_supplier.Rows[e.RowIndex];

                txt_name.Text = row.Cells[0].Value.ToString();
                txt_contact.Text = row.Cells[1].Value.ToString();
                txt_Address.Text = row.Cells[2].Value.ToString();

                lbl_Id.Text = supplierService.GetAll()[e.RowIndex].Id.ToString();
            }
            btn_Add.Enabled = false;
            btn_Update.Enabled = true;
            btn_Delete.Enabled = true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbl_Id.Text))
            {
                string supplierName = txt_name.Text;
                if (CheckEmptyInput(supplierName, "Name"))
                    return;

                string supplierContact = txt_contact.Text;
                if (CheckEmptyInput(supplierContact, "Contact"))
                    return;

                string supplierAddress = txt_Address.Text;
                if (CheckEmptyInput(supplierAddress, "Address"))
                    return;

                int supplierId = int.Parse(lbl_Id.Text);

                bool isUpdated = supplierService.update(supplierId, supplierName, supplierAddress, supplierContact);

                if (isUpdated)
                {
                    MessageBox.Show("Supplier updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSuppliers();
                    ResetInputs();
                    btn_Add.Enabled = true;
                    btn_Update.Enabled = false;
                    btn_Delete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Failed to update supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please select a supplier first.");
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int supplierId = int.Parse(lbl_Id.Text);

            if (supplierService.Delete(supplierId))
            {
                MessageBox.Show("Supplier is deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSuppliers();
            }
            else
            {
                MessageBox.Show("Failed to delete supplier information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetInputs();
        }
    }
}

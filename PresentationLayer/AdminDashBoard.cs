using BLL;
using DAL.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;
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














































































































































































































































































































































































        #region Helper methods
        public void LoadSuppliers()
        {
            List<Supplier> suppliers = supplierService.GetAll();


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

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetInputs();
            btn_Add.Enabled = true;
            btn_Update.Enabled = false;
            btn_Delete.Enabled = false;
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\+?\d{10,15}$");
        }
        #endregion

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string supplierName = txt_name.Text.Trim();
            string supplierContact = txt_contact.Text.Trim();
            string supplierAddress = txt_Address.Text.Trim();


            if (CheckEmptyInput(supplierName, "Name") ||
                CheckEmptyInput(supplierContact, "Contact") ||
                CheckEmptyInput(supplierAddress, "Address"))
            {
                return;
            }
            if (!IsValidPhoneNumber(supplierContact))
            {
                MessageBox.Show("Invalid phone number. Please enter a valid number (10-15 digits).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var existingSupplier = supplierService.GetSupplierByname(supplierName);
            if (existingSupplier != null)
            {
                MessageBox.Show("Supplier with this name already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            bool isAdded = supplierService.Add(supplierName, supplierAddress, supplierContact);
            if (isAdded)
            {
                MessageBox.Show("Supplier added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSuppliers();
                ResetInputs();
            }
            else
            {
                MessageBox.Show("Failed to add supplier. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string originalName = "";
        private string originalContact = "";
        private string originalAddress = "";

        private void dgv_supplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_supplier.Rows[e.RowIndex];

                txt_name.Text = row.Cells[0].Value.ToString();
                txt_contact.Text = row.Cells[1].Value.ToString();
                txt_Address.Text = row.Cells[2].Value.ToString();

                originalName = txt_name.Text;
                originalContact = txt_contact.Text;
                originalAddress = txt_Address.Text;

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
                string supplierName = txt_name.Text.Trim();
                string supplierContact = txt_contact.Text.Trim();
                string supplierAddress = txt_Address.Text.Trim();

                if (CheckEmptyInput(supplierName, "Name") ||
                    CheckEmptyInput(supplierContact, "Contact") ||
                    CheckEmptyInput(supplierAddress, "Address"))
                {
                    return;
                }
                if (!IsValidPhoneNumber(supplierContact))
                {
                    MessageBox.Show("Invalid phone number. Please enter a valid number (10-15 digits).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int supplierId = int.Parse(lbl_Id.Text);


                if (supplierName == originalName && supplierContact == originalContact && supplierAddress == originalAddress)
                {
                    MessageBox.Show("No changes detected. Please modify some fields before updating.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

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

            DialogResult result = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (supplierService.Delete(supplierId))
                    {
                        MessageBox.Show("Supplier deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSuppliers();
                        ResetInputs();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string lastDisplayedReport = "ProductStock";
        public string GetUrl(string name)
        {
            return $"http://localhost/ReportServer?/Report%20Project/{name}&rs:Command=Render&rc:Toolbar=false&rc:Parameters=false&rc:Zoom=Page%20Width";
        }

        private void btn_currentStock_Click(object sender, EventArgs e)
        {
            string url = GetUrl("ProductStock");
            webView21.EnsureCoreWebView2Async(null);
            webView21.Visible = true;
            webView21.Source = new Uri(url);
        }

        private void btn_salesPerformance_Click(object sender, EventArgs e)
        {
            string url = GetUrl("SalesPerformance");

            webView21.EnsureCoreWebView2Async(null);
            webView21.Visible = true;
            webView21.Source = new Uri(url);
            lastDisplayedReport = "SalesPerformance";
        }

        private void btn_lowStock_Click(object sender, EventArgs e)
        {
            string url = GetUrl("LowStockLevel");

            webView21.EnsureCoreWebView2Async(null);
            webView21.Visible = true;
            webView21.Source = new Uri(url);
            lastDisplayedReport = "LowStockLevel";
        }

        private void btn_mostSold_Click(object sender, EventArgs e)
        {
            string url = GetUrl("MostSoldProduct");

            webView21.EnsureCoreWebView2Async(null);
            webView21.Visible = true;
            webView21.Source = new Uri(url);
            lastDisplayedReport = "MostSoldProduct";
        }
        private async Task DownloadReport(string format, string fileExtension)
        {
            try
            {
                string downloadUrl = GetUrl(lastDisplayedReport) + $"&rs:Format={format}";


                HttpClientHandler handler = new HttpClientHandler
                {
                    Credentials = CredentialCache.DefaultCredentials // Use logged-in user's credentials
                };

                using (HttpClient client = new HttpClient(handler))
                {
                    HttpResponseMessage response = await client.GetAsync(downloadUrl);

                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}", "Download Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    byte[] reportBytes = await response.Content.ReadAsByteArrayAsync();



                    // Ensure the file contains valid Excel data
                    if (reportBytes.Length < 1000) // Arbitrary small file size check
                    {
                        MessageBox.Show("Downloaded file is too small. The report may not have been generated correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = $"{format} files|*.{fileExtension}",
                        Title = $"Save Report as {format}",
                        FileName = $"Report.{fileExtension}"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        await File.WriteAllBytesAsync(saveFileDialog.FileName, reportBytes);
                        MessageBox.Show("Report downloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error downloading report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_DownloadPdf_Click(object sender, EventArgs e)
        {
            await DownloadReport("PDF", "pdf");
        }

        private async void btn_downloadExcel_Click(object sender, EventArgs e)
        {
            await DownloadReport("EXCELOPENXML", "xlsx");
        }
    }
}

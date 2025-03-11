using BLL;
using DAL.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms.DataVisualization.Charting;


namespace PresentationLayer
{
    public partial class AdminDashBoard : MaterialForm
    {
        int ProductId;
        ProductService PS = new ProductService();
        StockService S = new StockService();
        SaleService SaleService = new SaleService();
        SaleDetailsService Sd = new SaleDetailsService();
        private readonly MaterialSkinManager materialSkinManager;
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
        }
        private async void AdminDashBoard_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadSuppliers();
            LoadCategory();
            LoadStock();
            btn_deleteProduct.Visible = false;
            btn_EditProduct.Visible = false;
            lbl_CountOfProd.Text = PS.GetTotalCount().ToString();
            lbl_dashTotalSales.Text = SaleService.GetTotalRevenue().ToString();
            lbl_dashTotalCust.Text = SaleService.GetTotalCustomers().ToString();
            lbl_dashBestSellingProd.Text = Sd.GetBestSellingProduct().ToString();
            lbl_dashTotalOrders.Text = SaleService.GetTotalOrders().ToString();
            lbl_dashLowStock.Text = PS.GetLowStockProdCount().ToString();
            await Task.Delay(500);
            CheckLowStock();
        }
        private void dgv_dashStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_dashStock.Columns[e.ColumnIndex].Name == "Status")
            {
                if (dgv_dashStock.Rows[e.RowIndex].Cells["TotalStock"].Value != null)
                {
                    int quantity = Convert.ToInt32(dgv_dashStock.Rows[e.RowIndex].Cells["TotalStock"].Value);

                    if (quantity < 10)
                    {
                        e.Value = "Low";
                        e.CellStyle.ForeColor = Color.Red;

                    }
                    else if (quantity <= 20)
                    {
                        e.Value = "Medium";
                        e.CellStyle.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        e.Value = "High";
                        e.CellStyle.ForeColor = Color.Green;
                    }
                    e.CellStyle.Font = new Font(dgv_dashStock.Font, FontStyle.Bold);
                }
            }
        }
        #region Product Tap
        public void LoadProducts()
        {
            var Products = PS.GetAll();
            dgv_Products.DataSource = Products;
            dgv_Products.Columns["ProductId"].Visible = false;

            dgv_Products.RowTemplate.Height = 40;

            btn_deleteProduct.Visible = false;
            btn_EditProduct.Visible = false;

            dgv_dashStock.DataSource = Products;
            dgv_dashStock.Columns["ProductId"].Visible = false;
            dgv_dashStock.Columns["Price"].Visible = false;
            dgv_dashStock.Columns["CategoryName"].Visible = false;
            dgv_dashStock.Columns["SupplierName"].Visible = false;

            cmb_stockProd.DataSource = Products.Select(p => new
            {
                Id = (int)p.GetType().GetProperty("ProductId").GetValue(p),
                Name = (string)p.GetType().GetProperty("Name").GetValue(p)
            }).ToList();
            cmb_stockProd.ValueMember = "Id";
            cmb_stockProd.DisplayMember = "Name";
        }
        public void LoadSuppliers()
        {
            SupplierService S = new SupplierService();
            cmb_SupProduct.DataSource = S.GetAll();
            cmb_SupProduct.ValueMember = "Id";
            cmb_SupProduct.DisplayMember = "Name";
            cmb_SupProduct.SelectedIndex = -1;

            cmb_searchProdSupplier.DataSource = S.GetAll();
            cmb_searchProdSupplier.ValueMember = "Id";
            cmb_searchProdSupplier.DisplayMember = "Name";
            cmb_searchProdSupplier.SelectedIndex = -1;
        }
        public void LoadCategory()
        {
            CategoryService GS = new CategoryService();
            cmb_CatProducts.DataSource = GS.GetAllCategories();
            cmb_CatProducts.ValueMember = "Id";
            cmb_CatProducts.DisplayMember = "Name";
            cmb_CatProducts.SelectedIndex = -1;

            cmb_searchProdCat.DataSource = GS.GetAllCategories();
            cmb_searchProdCat.ValueMember = "Id";
            cmb_searchProdCat.DisplayMember = "Name";
            cmb_searchProdCat.SelectedIndex = -1;
        }
        private void txt_PriceProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void dgv_Products_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = dgv_Products.SelectedRows[0];
            ProductId = (int)row.Cells["ProductId"].Value;
            Product P = PS.GetById(ProductId);
            txt_NameProduct.Text = P.Name;
            txt_PriceProduct.Text = P.Price.ToString();
            cmb_CatProducts.SelectedValue = P.CategoryId;
            cmb_SupProduct.SelectedValue = P.SupplierId;
            cmb_CatProducts.Refresh();
            cmb_SupProduct.Refresh();
            btn_EditProduct.Visible = true;
            btn_deleteProduct.Visible = true;
            btn_AddProduct.Visible = false;
            btn_ResetProduct.Location = new Point(400, 227);
            lbl_quantityProd.Visible = false;
            txt_QuantityProd.Visible = false;
        }
        private void btn_ResetProduct_Click(object sender, EventArgs e)
        {
            btn_ResetProduct.Location = new Point(462, 227);
            btn_AddProduct.Visible = true;
            btn_deleteProduct.Visible = false;
            btn_EditProduct.Visible = false;
            txt_NameProduct.Clear();
            txt_PriceProduct.Clear();
            txt_PriceProduct.Clear();
            txt_QuantityProd.Clear();
            cmb_CatProducts.SelectedIndex = -1;
            cmb_SupProduct.SelectedIndex = -1;
            cmb_CatProducts.Refresh();
            cmb_SupProduct.Refresh();
            lbl_quantityProd.Visible = true;
            txt_QuantityProd.Visible = true;
        }
        private bool ValidateProductInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_NameProduct.Text) ||
                string.IsNullOrWhiteSpace(txt_PriceProduct.Text) ||
                cmb_CatProducts.SelectedIndex == -1 ||
                cmb_SupProduct.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            if (!ValidateProductInputs()) return;

            var Name = txt_NameProduct.Text;
            decimal Price = decimal.Parse(txt_PriceProduct.Text);
            int CategoryId = (int)cmb_CatProducts.SelectedValue;
            int SupplierId = (int)cmb_SupProduct.SelectedValue;
            int Quantity = int.Parse(txt_QuantityProd.Text);

            PS.Add(Name, Price, CategoryId, SupplierId, Quantity);
            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Threading.Thread.Sleep(100);
            LoadProducts();
            btn_ResetProduct_Click(sender, e);
        }
        private void btn_EditProduct_Click(object sender, EventArgs e)
        {
            if (!ValidateProductInputs()) return;

            var Name = txt_NameProduct.Text;
            decimal Price = decimal.Parse(txt_PriceProduct.Text);
            int CategoryId = (int)cmb_CatProducts.SelectedValue;
            int SupplierId = (int)cmb_SupProduct.SelectedValue;

            PS.Update(ProductId, Name, Price, CategoryId, SupplierId);
            MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadProducts();
            btn_ResetProduct_Click(sender, e);
        }
        private void btn_deleteProduct_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Are you sure you Want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (response == DialogResult.Yes)
            {
                PS.Delete(ProductId);
                MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
                btn_ResetProduct_Click(sender, e);
            }
        }
        private void btn_searchProduct_Click(object sender, EventArgs e)
        {
            string Name = txt_searchProdName.Text;
            int? CategoryId = null;
            if (cmb_searchProdCat.SelectedIndex != -1 && cmb_searchProdCat.SelectedValue != null)
            {
                CategoryId = Convert.ToInt32(cmb_searchProdCat.SelectedValue);
            }
            int? SupplierId = null;
            if (cmb_searchProdSupplier.SelectedIndex != -1 && cmb_searchProdSupplier.SelectedValue != null)
            {
                SupplierId = Convert.ToInt32(cmb_searchProdSupplier.SelectedValue);
            }
            var results = PS.Search(Name, CategoryId, SupplierId);
            dgv_Products.DataSource = results;
            dgv_Products.Refresh();
            dgv_Products.Columns["ProductId"].Visible = false;
        }
        private void btn_resetSearchProd_Click(object sender, EventArgs e)
        {
            txt_searchProdName.Clear();
            cmb_searchProdCat.SelectedIndex = -1;
            cmb_searchProdSupplier.SelectedIndex = -1;
            cmb_searchProdCat.Refresh();
            cmb_searchProdSupplier.Refresh();
            LoadProducts();
        }
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                SignForm signForm = new SignForm();
                signForm.ShowDialog();
                this.Close();
            }
        }
        #endregion
        #region Stock Tap
        public void LoadStock()
        {
            var stocks = S.GetAll();
            dgv_StockTap.DataSource = stocks;
            dgv_StockTap.Columns["ProductId"].Visible = false;
            cmb_StockType.SelectedIndex = -1;
            cmb_stockProd.SelectedIndex = -1;
        }
        private void CheckLowStock()
        {
            bool lowStockExists = false;
            foreach (DataGridViewRow row in dgv_dashStock.Rows)
            {
                if (row.Cells["TotalStock"].Value != null)
                {
                    int quantity = Convert.ToInt32(row.Cells["TotalStock"].Value);
                    if (quantity < 10)
                    {
                        lowStockExists = true;
                        break;
                    }
                }
            }
            if (lowStockExists)
            {
                MessageBox.Show("There are low stock products that need to be restocked!", "Stock alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_StockSearch_Click(object sender, EventArgs e)
        {
            int? productId = cmb_stockProd.SelectedValue as int?;
            string stocktype = cmb_StockType.SelectedItem?.ToString() ?? "";

            var results = S.SearchStocks(stocktype, productId);
            
            dgv_StockTap.DataSource = results;
        }
        private void btn_StockReset_Click(object sender, EventArgs e)
        {
            cmb_StockType.SelectedIndex = - 1;
            cmb_stockProd.SelectedIndex = -1;
            cmb_stockProd.Refresh();
            cmb_StockType.Refresh();

            dgv_StockTap.DataSource = S.GetAll();
        }
        #endregion
    }
}
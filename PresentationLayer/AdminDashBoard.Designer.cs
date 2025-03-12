namespace PresentationLayer
{
    partial class AdminDashBoard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashBoard));
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            imageList1 = new ImageList(components);
            Products = new MaterialSkin.Controls.MaterialTabControl();
            Dashboard = new TabPage();
            tabPage2 = new TabPage();
            Sales = new TabPage();
            Stock = new TabPage();
            Suppliers = new TabPage();
            btn_Reset = new MaterialSkin.Controls.MaterialButton();
            dgv_supplier = new DataGridView();
            lbl_Id = new MaterialSkin.Controls.MaterialLabel();
            lbl_address = new MaterialSkin.Controls.MaterialLabel();
            lbl_contact = new MaterialSkin.Controls.MaterialLabel();
            lbl_name = new MaterialSkin.Controls.MaterialLabel();
            txt_Address = new MaterialSkin.Controls.MaterialTextBox();
            txt_contact = new MaterialSkin.Controls.MaterialTextBox();
            txt_name = new MaterialSkin.Controls.MaterialTextBox();
            btn_Delete = new MaterialSkin.Controls.MaterialButton();
            btn_Update = new MaterialSkin.Controls.MaterialButton();
            btn_Add = new MaterialSkin.Controls.MaterialButton();
            Users = new TabPage();
            Reports = new TabPage();
            btn_downloadExcel = new MaterialSkin.Controls.MaterialButton();
            btn_DownloadPdf = new MaterialSkin.Controls.MaterialButton();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            btn_mostSold = new MaterialSkin.Controls.MaterialButton();
            btn_lowStock = new MaterialSkin.Controls.MaterialButton();
            btn_salesPerformance = new MaterialSkin.Controls.MaterialButton();
            btn_currentStock = new MaterialSkin.Controls.MaterialButton();
            Settings = new TabPage();
            Products.SuspendLayout();
            Suppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_supplier).BeginInit();
            Reports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-dashboard-layout-24.png");
            imageList1.Images.SetKeyName(1, "icons8-home-24.png");
            imageList1.Images.SetKeyName(2, "icons8-us-dollar-26.png");
            imageList1.Images.SetKeyName(3, "icons8-product-24.png");
            imageList1.Images.SetKeyName(4, "icons8-analytics-32.png");
            imageList1.Images.SetKeyName(5, "icons8-supplier-24.png");
            imageList1.Images.SetKeyName(6, "icons8-reports-32.png");
            imageList1.Images.SetKeyName(7, "icons8-users-24.png");
            imageList1.Images.SetKeyName(8, "icons8-stock-32.png");
            // 
            // Products
            // 
            Products.Controls.Add(Dashboard);
            Products.Controls.Add(tabPage2);
            Products.Controls.Add(Sales);
            Products.Controls.Add(Stock);
            Products.Controls.Add(Suppliers);
            Products.Controls.Add(Users);
            Products.Controls.Add(Reports);
            Products.Controls.Add(Settings);
            Products.Depth = 0;
            Products.Dock = DockStyle.Fill;
            Products.ImageList = imageList1;
            Products.Location = new Point(3, 58);
            Products.MouseState = MaterialSkin.MouseState.HOVER;
            Products.Multiline = true;
            Products.Name = "Products";
            Products.SelectedIndex = 0;
            Products.Size = new Size(1025, 636);
            Products.TabIndex = 0;
            // 
            // Dashboard
            // 
            Dashboard.ImageKey = "icons8-dashboard-layout-24.png";
            Dashboard.Location = new Point(4, 31);
            Dashboard.Name = "Dashboard";
            Dashboard.Padding = new Padding(3);
            Dashboard.Size = new Size(1017, 601);
            Dashboard.TabIndex = 0;
            Dashboard.Text = "Dashboard";
            Dashboard.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.ImageKey = "icons8-product-24.png";
            tabPage2.Location = new Point(4, 31);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1017, 601);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Products";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Sales
            // 
            Sales.ImageKey = "icons8-us-dollar-26.png";
            Sales.Location = new Point(4, 31);
            Sales.Name = "Sales";
            Sales.Size = new Size(1017, 601);
            Sales.TabIndex = 2;
            Sales.Text = "Sales";
            Sales.UseVisualStyleBackColor = true;
            // 
            // Stock
            // 
            Stock.ImageKey = "icons8-stock-32.png";
            Stock.Location = new Point(4, 31);
            Stock.Name = "Stock";
            Stock.Size = new Size(1017, 601);
            Stock.TabIndex = 4;
            Stock.Text = "Stock";
            Stock.UseVisualStyleBackColor = true;
            // 
            // Suppliers
            // 
            Suppliers.Controls.Add(btn_Reset);
            Suppliers.Controls.Add(dgv_supplier);
            Suppliers.Controls.Add(lbl_Id);
            Suppliers.Controls.Add(lbl_address);
            Suppliers.Controls.Add(lbl_contact);
            Suppliers.Controls.Add(lbl_name);
            Suppliers.Controls.Add(txt_Address);
            Suppliers.Controls.Add(txt_contact);
            Suppliers.Controls.Add(txt_name);
            Suppliers.Controls.Add(btn_Delete);
            Suppliers.Controls.Add(btn_Update);
            Suppliers.Controls.Add(btn_Add);
            Suppliers.ImageKey = "icons8-supplier-24.png";
            Suppliers.Location = new Point(4, 31);
            Suppliers.Name = "Suppliers";
            Suppliers.Size = new Size(1017, 601);
            Suppliers.TabIndex = 5;
            Suppliers.Text = "Suppliers";
            Suppliers.UseVisualStyleBackColor = true;
            // 
            // btn_Reset
            // 
            btn_Reset.AutoSize = false;
            btn_Reset.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Reset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_Reset.Depth = 0;
            btn_Reset.HighEmphasis = true;
            btn_Reset.Icon = null;
            btn_Reset.Location = new Point(647, 519);
            btn_Reset.Margin = new Padding(4, 6, 4, 6);
            btn_Reset.MouseState = MaterialSkin.MouseState.HOVER;
            btn_Reset.Name = "btn_Reset";
            btn_Reset.NoAccentTextColor = Color.Empty;
            btn_Reset.Size = new Size(93, 36);
            btn_Reset.TabIndex = 15;
            btn_Reset.Text = "Reset";
            btn_Reset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_Reset.UseAccentColor = false;
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // dgv_supplier
            // 
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(203, 89, 78);
            dataGridViewCellStyle13.SelectionForeColor = Color.White;
            dgv_supplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dgv_supplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_supplier.BackgroundColor = Color.FromArgb(50, 50, 50);
            dgv_supplier.BorderStyle = BorderStyle.None;
            dgv_supplier.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_supplier.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(203, 89, 78);
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dgv_supplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dgv_supplier.ColumnHeadersHeight = 40;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle15.ForeColor = Color.White;
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(203, 89, 78);
            dataGridViewCellStyle15.SelectionForeColor = Color.White;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            dgv_supplier.DefaultCellStyle = dataGridViewCellStyle15;
            dgv_supplier.GridColor = Color.FromArgb(55, 71, 79);
            dgv_supplier.ImeMode = ImeMode.NoControl;
            dgv_supplier.Location = new Point(17, 72);
            dgv_supplier.Name = "dgv_supplier";
            dgv_supplier.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_supplier.RowHeadersWidth = 51;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle16.ForeColor = Color.White;
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(203, 89, 78);
            dataGridViewCellStyle16.SelectionForeColor = Color.White;
            dgv_supplier.RowsDefaultCellStyle = dataGridViewCellStyle16;
            dgv_supplier.Size = new Size(909, 222);
            dgv_supplier.TabIndex = 0;
            dgv_supplier.CellClick += dgv_supplier_CellClick;
            // 
            // lbl_Id
            // 
            lbl_Id.AutoSize = true;
            lbl_Id.Depth = 0;
            lbl_Id.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_Id.Location = new Point(760, 261);
            lbl_Id.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_Id.Name = "lbl_Id";
            lbl_Id.Size = new Size(14, 19);
            lbl_Id.TabIndex = 14;
            lbl_Id.Text = "-1";
            lbl_Id.Visible = false;
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Depth = 0;
            lbl_address.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_address.Location = new Point(118, 530);
            lbl_address.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(58, 19);
            lbl_address.TabIndex = 13;
            lbl_address.Text = "Address";
            // 
            // lbl_contact
            // 
            lbl_contact.AutoSize = true;
            lbl_contact.Depth = 0;
            lbl_contact.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_contact.Location = new Point(118, 434);
            lbl_contact.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_contact.Name = "lbl_contact";
            lbl_contact.Size = new Size(88, 19);
            lbl_contact.TabIndex = 12;
            lbl_contact.Text = "Contact info";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Depth = 0;
            lbl_name.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_name.Location = new Point(118, 346);
            lbl_name.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(43, 19);
            lbl_name.TabIndex = 11;
            lbl_name.Text = "Name";
            // 
            // txt_Address
            // 
            txt_Address.AnimateReadOnly = false;
            txt_Address.BorderStyle = BorderStyle.None;
            txt_Address.Depth = 0;
            txt_Address.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_Address.LeadingIcon = null;
            txt_Address.Location = new Point(235, 512);
            txt_Address.MaxLength = 50;
            txt_Address.MouseState = MaterialSkin.MouseState.OUT;
            txt_Address.Multiline = false;
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(339, 50);
            txt_Address.TabIndex = 10;
            txt_Address.Text = "";
            txt_Address.TrailingIcon = null;
            // 
            // txt_contact
            // 
            txt_contact.AnimateReadOnly = false;
            txt_contact.BorderStyle = BorderStyle.None;
            txt_contact.Depth = 0;
            txt_contact.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_contact.LeadingIcon = null;
            txt_contact.Location = new Point(235, 414);
            txt_contact.MaxLength = 50;
            txt_contact.MouseState = MaterialSkin.MouseState.OUT;
            txt_contact.Multiline = false;
            txt_contact.Name = "txt_contact";
            txt_contact.Size = new Size(339, 50);
            txt_contact.TabIndex = 8;
            txt_contact.Text = "";
            txt_contact.TrailingIcon = null;
            // 
            // txt_name
            // 
            txt_name.AnimateReadOnly = false;
            txt_name.BorderStyle = BorderStyle.None;
            txt_name.Depth = 0;
            txt_name.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_name.LeadingIcon = null;
            txt_name.Location = new Point(235, 326);
            txt_name.MaxLength = 50;
            txt_name.MouseState = MaterialSkin.MouseState.OUT;
            txt_name.Multiline = false;
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(339, 50);
            txt_name.TabIndex = 6;
            txt_name.Text = "";
            txt_name.TrailingIcon = null;
            // 
            // btn_Delete
            // 
            btn_Delete.AutoSize = false;
            btn_Delete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Delete.BackColor = Color.Transparent;
            btn_Delete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_Delete.Depth = 0;
            btn_Delete.Enabled = false;
            btn_Delete.HighEmphasis = true;
            btn_Delete.Icon = null;
            btn_Delete.Location = new Point(648, 462);
            btn_Delete.Margin = new Padding(4, 6, 4, 6);
            btn_Delete.MouseState = MaterialSkin.MouseState.HOVER;
            btn_Delete.Name = "btn_Delete";
            btn_Delete.NoAccentTextColor = Color.Empty;
            btn_Delete.Size = new Size(92, 36);
            btn_Delete.TabIndex = 5;
            btn_Delete.Text = "Delete";
            btn_Delete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_Delete.UseAccentColor = false;
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Update
            // 
            btn_Update.AutoSize = false;
            btn_Update.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_Update.Depth = 0;
            btn_Update.Enabled = false;
            btn_Update.HighEmphasis = true;
            btn_Update.Icon = null;
            btn_Update.Location = new Point(648, 405);
            btn_Update.Margin = new Padding(4, 6, 4, 6);
            btn_Update.MouseState = MaterialSkin.MouseState.HOVER;
            btn_Update.Name = "btn_Update";
            btn_Update.NoAccentTextColor = Color.Empty;
            btn_Update.Size = new Size(92, 36);
            btn_Update.TabIndex = 4;
            btn_Update.Text = "Update";
            btn_Update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_Update.UseAccentColor = false;
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Add
            // 
            btn_Add.AutoSize = false;
            btn_Add.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_Add.Depth = 0;
            btn_Add.HighEmphasis = true;
            btn_Add.Icon = null;
            btn_Add.Location = new Point(648, 346);
            btn_Add.Margin = new Padding(4, 6, 4, 6);
            btn_Add.MouseState = MaterialSkin.MouseState.HOVER;
            btn_Add.Name = "btn_Add";
            btn_Add.NoAccentTextColor = Color.Empty;
            btn_Add.Size = new Size(92, 36);
            btn_Add.TabIndex = 0;
            btn_Add.Text = "Add";
            btn_Add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_Add.UseAccentColor = false;
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // Users
            // 
            Users.ImageKey = "icons8-users-24.png";
            Users.Location = new Point(4, 31);
            Users.Name = "Users";
            Users.Size = new Size(1017, 601);
            Users.TabIndex = 6;
            Users.Text = "Users";
            Users.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            Reports.Controls.Add(btn_downloadExcel);
            Reports.Controls.Add(btn_DownloadPdf);
            Reports.Controls.Add(webView21);
            Reports.Controls.Add(btn_mostSold);
            Reports.Controls.Add(btn_lowStock);
            Reports.Controls.Add(btn_salesPerformance);
            Reports.Controls.Add(btn_currentStock);
            Reports.ImageKey = "icons8-reports-32.png";
            Reports.Location = new Point(4, 31);
            Reports.Name = "Reports";
            Reports.Size = new Size(1017, 601);
            Reports.TabIndex = 7;
            Reports.Text = "Reports";
            Reports.UseVisualStyleBackColor = true;
            // 
            // btn_downloadExcel
            // 
            btn_downloadExcel.AutoSize = false;
            btn_downloadExcel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_downloadExcel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_downloadExcel.Depth = 0;
            btn_downloadExcel.HighEmphasis = true;
            btn_downloadExcel.Icon = null;
            btn_downloadExcel.Location = new Point(754, 515);
            btn_downloadExcel.Margin = new Padding(4, 6, 4, 6);
            btn_downloadExcel.MouseState = MaterialSkin.MouseState.HOVER;
            btn_downloadExcel.Name = "btn_downloadExcel";
            btn_downloadExcel.NoAccentTextColor = Color.Empty;
            btn_downloadExcel.Size = new Size(198, 45);
            btn_downloadExcel.TabIndex = 6;
            btn_downloadExcel.Text = "Download as excel";
            btn_downloadExcel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_downloadExcel.UseAccentColor = false;
            btn_downloadExcel.UseVisualStyleBackColor = true;
            btn_downloadExcel.Click += btn_downloadExcel_Click;
            // 
            // btn_DownloadPdf
            // 
            btn_DownloadPdf.AutoSize = false;
            btn_DownloadPdf.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_DownloadPdf.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_DownloadPdf.Depth = 0;
            btn_DownloadPdf.HighEmphasis = true;
            btn_DownloadPdf.Icon = null;
            btn_DownloadPdf.Location = new Point(537, 515);
            btn_DownloadPdf.Margin = new Padding(4, 6, 4, 6);
            btn_DownloadPdf.MouseState = MaterialSkin.MouseState.HOVER;
            btn_DownloadPdf.Name = "btn_DownloadPdf";
            btn_DownloadPdf.NoAccentTextColor = Color.Empty;
            btn_DownloadPdf.Size = new Size(198, 45);
            btn_DownloadPdf.TabIndex = 5;
            btn_DownloadPdf.Text = "Download as pdf";
            btn_DownloadPdf.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_DownloadPdf.UseAccentColor = false;
            btn_DownloadPdf.UseVisualStyleBackColor = true;
            btn_DownloadPdf.Click += btn_DownloadPdf_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.BackColor = Color.FromArgb(55, 55, 55);
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.FromArgb(55, 55, 55);
            webView21.Location = new Point(41, 97);
            webView21.Name = "webView21";
            webView21.Size = new Size(894, 394);
            webView21.TabIndex = 4;
            webView21.Visible = false;
            webView21.ZoomFactor = 1D;
            // 
            // btn_mostSold
            // 
            btn_mostSold.AutoSize = false;
            btn_mostSold.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_mostSold.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_mostSold.Depth = 0;
            btn_mostSold.HighEmphasis = true;
            btn_mostSold.Icon = null;
            btn_mostSold.Location = new Point(728, 19);
            btn_mostSold.Margin = new Padding(4, 6, 4, 6);
            btn_mostSold.MouseState = MaterialSkin.MouseState.HOVER;
            btn_mostSold.Name = "btn_mostSold";
            btn_mostSold.NoAccentTextColor = Color.Empty;
            btn_mostSold.Size = new Size(198, 45);
            btn_mostSold.TabIndex = 3;
            btn_mostSold.Text = "Most sold products";
            btn_mostSold.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_mostSold.UseAccentColor = false;
            btn_mostSold.UseVisualStyleBackColor = true;
            btn_mostSold.Click += btn_mostSold_Click;
            // 
            // btn_lowStock
            // 
            btn_lowStock.AutoSize = false;
            btn_lowStock.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_lowStock.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_lowStock.Depth = 0;
            btn_lowStock.HighEmphasis = true;
            btn_lowStock.Icon = null;
            btn_lowStock.Location = new Point(497, 19);
            btn_lowStock.Margin = new Padding(4, 6, 4, 6);
            btn_lowStock.MouseState = MaterialSkin.MouseState.HOVER;
            btn_lowStock.Name = "btn_lowStock";
            btn_lowStock.NoAccentTextColor = Color.Empty;
            btn_lowStock.Size = new Size(198, 45);
            btn_lowStock.TabIndex = 2;
            btn_lowStock.Text = "Low-stock products";
            btn_lowStock.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_lowStock.UseAccentColor = false;
            btn_lowStock.UseVisualStyleBackColor = true;
            btn_lowStock.Click += btn_lowStock_Click;
            // 
            // btn_salesPerformance
            // 
            btn_salesPerformance.AutoSize = false;
            btn_salesPerformance.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_salesPerformance.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_salesPerformance.Depth = 0;
            btn_salesPerformance.HighEmphasis = true;
            btn_salesPerformance.Icon = null;
            btn_salesPerformance.Location = new Point(241, 19);
            btn_salesPerformance.Margin = new Padding(4, 6, 4, 6);
            btn_salesPerformance.MouseState = MaterialSkin.MouseState.HOVER;
            btn_salesPerformance.Name = "btn_salesPerformance";
            btn_salesPerformance.NoAccentTextColor = Color.Empty;
            btn_salesPerformance.Size = new Size(227, 45);
            btn_salesPerformance.TabIndex = 1;
            btn_salesPerformance.Text = " Monthly sales performance";
            btn_salesPerformance.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_salesPerformance.UseAccentColor = false;
            btn_salesPerformance.UseVisualStyleBackColor = true;
            btn_salesPerformance.Click += btn_salesPerformance_Click;
            // 
            // btn_currentStock
            // 
            btn_currentStock.AutoSize = false;
            btn_currentStock.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_currentStock.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_currentStock.Depth = 0;
            btn_currentStock.HighEmphasis = true;
            btn_currentStock.Icon = null;
            btn_currentStock.Location = new Point(22, 19);
            btn_currentStock.Margin = new Padding(4, 6, 4, 6);
            btn_currentStock.MouseState = MaterialSkin.MouseState.HOVER;
            btn_currentStock.Name = "btn_currentStock";
            btn_currentStock.NoAccentTextColor = Color.Empty;
            btn_currentStock.Size = new Size(198, 45);
            btn_currentStock.TabIndex = 0;
            btn_currentStock.Text = "Current stock levels";
            btn_currentStock.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_currentStock.UseAccentColor = false;
            btn_currentStock.UseVisualStyleBackColor = true;
            btn_currentStock.Click += btn_currentStock_Click;
            // 
            // Settings
            // 
            Settings.Location = new Point(4, 31);
            Settings.Name = "Settings";
            Settings.Size = new Size(1017, 601);
            Settings.TabIndex = 3;
            Settings.Text = "Settings | Logout";
            Settings.UseVisualStyleBackColor = true;
            // 
            // AdminDashBoard
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 697);
            Controls.Add(Products);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = Products;
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AdminDashBoard";
            Padding = new Padding(3, 58, 3, 3);
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            Products.ResumeLayout(false);
            Suppliers.ResumeLayout(false);
            Suppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_supplier).EndInit();
            Reports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl Products;
        private TabPage Dashboard;
        private TabPage tabPage2;
        private TabPage Sales;
        private TabPage Settings;
        private TabPage Stock;
        private TabPage Suppliers;
        private TabPage Users;
        private TabPage Reports;
        private MaterialSkin.Controls.MaterialButton btn_Add;
        private MaterialSkin.Controls.MaterialTextBox txt_name;
        private MaterialSkin.Controls.MaterialButton btn_Delete;
        private MaterialSkin.Controls.MaterialButton btn_Update;
        private MaterialSkin.Controls.MaterialTextBox txt_Address;
        private MaterialSkin.Controls.MaterialTextBox txt_contact;
        private MaterialSkin.Controls.MaterialLabel lbl_name;
        private MaterialSkin.Controls.MaterialLabel lbl_contact;
        private MaterialSkin.Controls.MaterialLabel lbl_address;
        private MaterialSkin.Controls.MaterialLabel lbl_Id;
        private DataGridView dgv_supplier;
        private MaterialSkin.Controls.MaterialButton btn_Reset;
        private MaterialSkin.Controls.MaterialButton btn_mostSold;
        private MaterialSkin.Controls.MaterialButton btn_lowStock;
        private MaterialSkin.Controls.MaterialButton btn_salesPerformance;
        private MaterialSkin.Controls.MaterialButton btn_currentStock;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private MaterialSkin.Controls.MaterialButton btn_downloadExcel;
        private MaterialSkin.Controls.MaterialButton btn_DownloadPdf;
    }
}
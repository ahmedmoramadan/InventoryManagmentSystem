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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            imageList1 = new ImageList(components);
            Products = new MaterialSkin.Controls.MaterialTabControl();
            Dashboard = new TabPage();
            dataGridView1 = new DataGridView();
            materialFloatingActionButton3 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            label3 = new Label();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            label2 = new Label();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            label1 = new Label();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            tabPage2 = new TabPage();
            Sales = new TabPage();
            Stock = new TabPage();
            Suppliers = new TabPage();
            btn_Reset = new MaterialSkin.Controls.MaterialButton();
            dgv_supplier = new DataGridView();
            lbl_Id = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
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
            Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            materialCard3.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard1.SuspendLayout();
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
            Dashboard.Controls.Add(dataGridView1);
            Dashboard.Controls.Add(materialFloatingActionButton3);
            Dashboard.Controls.Add(materialCard3);
            Dashboard.Controls.Add(materialFloatingActionButton2);
            Dashboard.Controls.Add(materialCard2);
            Dashboard.Controls.Add(materialFloatingActionButton1);
            Dashboard.Controls.Add(materialCard1);
            Dashboard.ImageKey = "icons8-dashboard-layout-24.png";
            Dashboard.Location = new Point(4, 31);
            Dashboard.Name = "Dashboard";
            Dashboard.Padding = new Padding(3);
            Dashboard.Size = new Size(1017, 601);
            Dashboard.TabIndex = 0;
            Dashboard.Text = "Dashboard";
            Dashboard.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 188);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(568, 285);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // materialFloatingActionButton3
            // 
            materialFloatingActionButton3.Depth = 0;
            materialFloatingActionButton3.Icon = (Image)resources.GetObject("materialFloatingActionButton3.Icon");
            materialFloatingActionButton3.Location = new Point(890, 75);
            materialFloatingActionButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton3.Name = "materialFloatingActionButton3";
            materialFloatingActionButton3.Size = new Size(59, 71);
            materialFloatingActionButton3.TabIndex = 5;
            materialFloatingActionButton3.Text = "materialFloatingActionButton3";
            materialFloatingActionButton3.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(label3);
            materialCard3.Controls.Add(materialLabel6);
            materialCard3.Controls.Add(materialLabel3);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(669, 56);
            materialCard3.Margin = new Padding(14, 13, 14, 13);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14, 13, 14, 13);
            materialCard3.Size = new Size(250, 95);
            materialCard3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F);
            label3.Location = new Point(70, 43);
            label3.Name = "label3";
            label3.Size = new Size(110, 29);
            label3.TabIndex = 4;
            label3.Text = "$200,000";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(88, 47);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(1, 0);
            materialLabel6.TabIndex = 3;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(17, 13);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(81, 19);
            materialLabel3.TabIndex = 2;
            materialLabel3.Text = "Total Profit";
            // 
            // materialFloatingActionButton2
            // 
            materialFloatingActionButton2.Depth = 0;
            materialFloatingActionButton2.Icon = (Image)resources.GetObject("materialFloatingActionButton2.Icon");
            materialFloatingActionButton2.Location = new Point(573, 75);
            materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            materialFloatingActionButton2.Size = new Size(59, 71);
            materialFloatingActionButton2.TabIndex = 3;
            materialFloatingActionButton2.Text = "materialFloatingActionButton2";
            materialFloatingActionButton2.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(label2);
            materialCard2.Controls.Add(materialLabel2);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(353, 56);
            materialCard2.Margin = new Padding(14, 13, 14, 13);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14, 13, 14, 13);
            materialCard2.Size = new Size(250, 95);
            materialCard2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F);
            label2.Location = new Point(75, 43);
            label2.Name = "label2";
            label2.Size = new Size(110, 29);
            label2.TabIndex = 2;
            label2.Text = "$600,000";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(17, 13);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(81, 19);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "Total Sales";
            // 
            // materialFloatingActionButton1
            // 
            materialFloatingActionButton1.Depth = 0;
            materialFloatingActionButton1.ForeColor = Color.White;
            materialFloatingActionButton1.Icon = (Image)resources.GetObject("materialFloatingActionButton1.Icon");
            materialFloatingActionButton1.Location = new Point(255, 75);
            materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            materialFloatingActionButton1.Size = new Size(59, 71);
            materialFloatingActionButton1.TabIndex = 1;
            materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            materialFloatingActionButton1.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(label1);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(35, 56);
            materialCard1.Margin = new Padding(14, 13, 14, 13);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14, 13, 14, 13);
            materialCard1.Size = new Size(250, 95);
            materialCard1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 43);
            label1.Name = "label1";
            label1.Size = new Size(84, 29);
            label1.TabIndex = 1;
            label1.Text = "60,000";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(17, 13);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(105, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Total Products";
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
            Suppliers.Controls.Add(materialLabel7);
            Suppliers.Controls.Add(materialLabel5);
            Suppliers.Controls.Add(materialLabel4);
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(203, 89, 78);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dgv_supplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgv_supplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_supplier.BackgroundColor = Color.FromArgb(50, 50, 50);
            dgv_supplier.BorderStyle = BorderStyle.None;
            dgv_supplier.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_supplier.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(203, 89, 78);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dgv_supplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_supplier.ColumnHeadersHeight = 40;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(203, 89, 78);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgv_supplier.DefaultCellStyle = dataGridViewCellStyle7;
            dgv_supplier.GridColor = Color.FromArgb(55, 71, 79);
            dgv_supplier.ImeMode = ImeMode.NoControl;
            dgv_supplier.Location = new Point(17, 72);
            dgv_supplier.Name = "dgv_supplier";
            dgv_supplier.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_supplier.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(203, 89, 78);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dgv_supplier.RowsDefaultCellStyle = dataGridViewCellStyle8;
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
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(118, 530);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(58, 19);
            materialLabel7.TabIndex = 13;
            materialLabel7.Text = "Address";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(118, 434);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(88, 19);
            materialLabel5.TabIndex = 12;
            materialLabel5.Text = "Contact info";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(118, 346);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(43, 19);
            materialLabel4.TabIndex = 11;
            materialLabel4.Text = "Name";
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
            Dashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
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
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton3;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private TabPage Stock;
        private TabPage Suppliers;
        private TabPage Users;
        private TabPage Reports;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton btn_Add;
        private MaterialSkin.Controls.MaterialTextBox txt_name;
        private MaterialSkin.Controls.MaterialButton btn_Delete;
        private MaterialSkin.Controls.MaterialButton btn_Update;
        private MaterialSkin.Controls.MaterialTextBox txt_Address;
        private MaterialSkin.Controls.MaterialTextBox txt_contact;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
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
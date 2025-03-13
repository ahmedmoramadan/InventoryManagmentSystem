namespace PresentationLayer
{
    partial class ManagerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            Dashboards = new TabPage();
            materialFloatingActionButton4 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialFloatingActionButton6 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialCard6 = new MaterialSkin.Controls.MaterialCard();
            lbl_dashTotalOrders = new Label();
            materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            materialFloatingActionButton5 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialCard5 = new MaterialSkin.Controls.MaterialCard();
            lbl_dashBestSellingProd = new Label();
            materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            lbl_dashTotalCust = new Label();
            materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            dgv_dashStock = new DataGridView();
            Status = new DataGridViewTextBoxColumn();
            materialFloatingActionButton3 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            lbl_dashLowStock = new Label();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            label1 = new Label();
            lbl_dashTotalSales = new Label();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            lbl_CountOfProd = new Label();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            Products = new TabPage();
            groupBox2 = new GroupBox();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            cmb_searchProdSupplier = new MaterialSkin.Controls.MaterialComboBox();
            btn_resetSearchProd = new MaterialSkin.Controls.MaterialButton();
            btn_searchProduct = new MaterialSkin.Controls.MaterialButton();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            cmb_searchProdCat = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            txt_searchProdName = new MaterialSkin.Controls.MaterialTextBox();
            groupBox1 = new GroupBox();
            txt_QuantityProd = new MaterialSkin.Controls.MaterialTextBox();
            lbl_quantityProd = new MaterialSkin.Controls.MaterialLabel();
            btn_ResetProduct = new MaterialSkin.Controls.MaterialButton();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            btn_deleteProduct = new MaterialSkin.Controls.MaterialButton();
            cmb_SupProduct = new MaterialSkin.Controls.MaterialComboBox();
            btn_AddProduct = new MaterialSkin.Controls.MaterialButton();
            txt_PriceProduct = new MaterialSkin.Controls.MaterialTextBox();
            btn_EditProduct = new MaterialSkin.Controls.MaterialButton();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            txt_NameProduct = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            cmb_CatProducts = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            dgv_Products = new DataGridView();
            Reports = new TabPage();
            Sales = new TabPage();
            imageList1 = new ImageList(components);
            btn_LogOut = new MaterialSkin.Controls.MaterialButton();
            materialTabControl1.SuspendLayout();
            Dashboards.SuspendLayout();
            materialCard6.SuspendLayout();
            materialCard5.SuspendLayout();
            materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_dashStock).BeginInit();
            materialCard3.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard1.SuspendLayout();
            Products.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Products).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(Dashboards);
            materialTabControl1.Controls.Add(Products);
            materialTabControl1.Controls.Add(Reports);
            materialTabControl1.Controls.Add(Sales);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.Font = new Font("Microsoft Sans Serif", 9F);
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.ItemSize = new Size(115, 27);
            materialTabControl1.Location = new Point(3, 58);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1017, 722);
            materialTabControl1.TabIndex = 0;
            // 
            // Dashboards
            // 
            Dashboards.Controls.Add(materialFloatingActionButton4);
            Dashboards.Controls.Add(materialFloatingActionButton6);
            Dashboards.Controls.Add(materialCard6);
            Dashboards.Controls.Add(materialFloatingActionButton5);
            Dashboards.Controls.Add(materialCard5);
            Dashboards.Controls.Add(materialCard4);
            Dashboards.Controls.Add(dgv_dashStock);
            Dashboards.Controls.Add(materialFloatingActionButton3);
            Dashboards.Controls.Add(materialCard3);
            Dashboards.Controls.Add(materialFloatingActionButton2);
            Dashboards.Controls.Add(materialCard2);
            Dashboards.Controls.Add(materialFloatingActionButton1);
            Dashboards.Controls.Add(materialCard1);
            Dashboards.ImageKey = "icons8-dashboard-layout-24.png";
            Dashboards.Location = new Point(4, 31);
            Dashboards.Name = "Dashboards";
            Dashboards.Padding = new Padding(3);
            Dashboards.Size = new Size(1009, 687);
            Dashboards.TabIndex = 0;
            Dashboards.Text = "Dashboards";
            Dashboards.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton4
            // 
            materialFloatingActionButton4.Depth = 0;
            materialFloatingActionButton4.Icon = InventoryManagmentSystem.PL.Properties.Resources.icons8_customers_50;
            materialFloatingActionButton4.Location = new Point(881, 225);
            materialFloatingActionButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton4.Name = "materialFloatingActionButton4";
            materialFloatingActionButton4.Size = new Size(59, 71);
            materialFloatingActionButton4.TabIndex = 21;
            materialFloatingActionButton4.Text = "materialFloatingActionButton4";
            materialFloatingActionButton4.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton6
            // 
            materialFloatingActionButton6.Depth = 0;
            materialFloatingActionButton6.Icon = InventoryManagmentSystem.PL.Properties.Resources.checkout;
            materialFloatingActionButton6.Location = new Point(575, 79);
            materialFloatingActionButton6.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton6.Name = "materialFloatingActionButton6";
            materialFloatingActionButton6.Size = new Size(59, 71);
            materialFloatingActionButton6.TabIndex = 25;
            materialFloatingActionButton6.Text = "materialFloatingActionButton6";
            materialFloatingActionButton6.UseVisualStyleBackColor = true;
            // 
            // materialCard6
            // 
            materialCard6.BackColor = Color.FromArgb(255, 255, 255);
            materialCard6.Controls.Add(lbl_dashTotalOrders);
            materialCard6.Controls.Add(materialLabel17);
            materialCard6.Controls.Add(materialLabel18);
            materialCard6.Depth = 0;
            materialCard6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard6.Location = new Point(348, 61);
            materialCard6.Margin = new Padding(14, 13, 14, 13);
            materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard6.Name = "materialCard6";
            materialCard6.Padding = new Padding(14, 13, 14, 13);
            materialCard6.Size = new Size(250, 95);
            materialCard6.TabIndex = 24;
            // 
            // lbl_dashTotalOrders
            // 
            lbl_dashTotalOrders.AutoSize = true;
            lbl_dashTotalOrders.Font = new Font("Microsoft Sans Serif", 13.8F);
            lbl_dashTotalOrders.Location = new Point(102, 52);
            lbl_dashTotalOrders.Name = "lbl_dashTotalOrders";
            lbl_dashTotalOrders.Size = new Size(52, 29);
            lbl_dashTotalOrders.TabIndex = 4;
            lbl_dashTotalOrders.Text = "200";
            // 
            // materialLabel17
            // 
            materialLabel17.AutoSize = true;
            materialLabel17.Depth = 0;
            materialLabel17.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel17.Location = new Point(88, 44);
            materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel17.Name = "materialLabel17";
            materialLabel17.Size = new Size(1, 0);
            materialLabel17.TabIndex = 3;
            // 
            // materialLabel18
            // 
            materialLabel18.AutoSize = true;
            materialLabel18.Depth = 0;
            materialLabel18.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel18.Location = new Point(17, 10);
            materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel18.Name = "materialLabel18";
            materialLabel18.Size = new Size(88, 19);
            materialLabel18.TabIndex = 2;
            materialLabel18.Text = "Total Orders";
            // 
            // materialFloatingActionButton5
            // 
            materialFloatingActionButton5.Depth = 0;
            materialFloatingActionButton5.Icon = InventoryManagmentSystem.PL.Properties.Resources.icons8_best_seller_64;
            materialFloatingActionButton5.Location = new Point(256, 210);
            materialFloatingActionButton5.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton5.Name = "materialFloatingActionButton5";
            materialFloatingActionButton5.Size = new Size(59, 71);
            materialFloatingActionButton5.TabIndex = 23;
            materialFloatingActionButton5.Text = "materialFloatingActionButton5";
            materialFloatingActionButton5.UseVisualStyleBackColor = true;
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.Controls.Add(lbl_dashBestSellingProd);
            materialCard5.Controls.Add(materialLabel15);
            materialCard5.Controls.Add(materialLabel16);
            materialCard5.Depth = 0;
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(36, 206);
            materialCard5.Margin = new Padding(14, 13, 14, 13);
            materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(14, 13, 14, 13);
            materialCard5.Size = new Size(250, 95);
            materialCard5.TabIndex = 22;
            // 
            // lbl_dashBestSellingProd
            // 
            lbl_dashBestSellingProd.AutoSize = true;
            lbl_dashBestSellingProd.Font = new Font("Microsoft Sans Serif", 13.8F);
            lbl_dashBestSellingProd.Location = new Point(17, 52);
            lbl_dashBestSellingProd.Name = "lbl_dashBestSellingProd";
            lbl_dashBestSellingProd.Size = new Size(145, 29);
            lbl_dashBestSellingProd.TabIndex = 4;
            lbl_dashBestSellingProd.Text = "Asus Laptop";
            // 
            // materialLabel15
            // 
            materialLabel15.AutoSize = true;
            materialLabel15.Depth = 0;
            materialLabel15.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel15.Location = new Point(88, 44);
            materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel15.Name = "materialLabel15";
            materialLabel15.Size = new Size(1, 0);
            materialLabel15.TabIndex = 3;
            // 
            // materialLabel16
            // 
            materialLabel16.AutoSize = true;
            materialLabel16.Depth = 0;
            materialLabel16.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel16.Location = new Point(17, 10);
            materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel16.Name = "materialLabel16";
            materialLabel16.Size = new Size(143, 19);
            materialLabel16.TabIndex = 2;
            materialLabel16.Text = "Best Selling Product";
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(lbl_dashTotalCust);
            materialCard4.Controls.Add(materialLabel13);
            materialCard4.Controls.Add(materialLabel14);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(660, 206);
            materialCard4.Margin = new Padding(14, 13, 14, 13);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14, 13, 14, 13);
            materialCard4.Size = new Size(250, 95);
            materialCard4.TabIndex = 20;
            // 
            // lbl_dashTotalCust
            // 
            lbl_dashTotalCust.AutoSize = true;
            lbl_dashTotalCust.Font = new Font("Microsoft Sans Serif", 13.8F);
            lbl_dashTotalCust.Location = new Point(107, 52);
            lbl_dashTotalCust.Name = "lbl_dashTotalCust";
            lbl_dashTotalCust.Size = new Size(52, 29);
            lbl_dashTotalCust.TabIndex = 4;
            lbl_dashTotalCust.Text = "200";
            // 
            // materialLabel13
            // 
            materialLabel13.AutoSize = true;
            materialLabel13.Depth = 0;
            materialLabel13.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel13.Location = new Point(88, 45);
            materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel13.Name = "materialLabel13";
            materialLabel13.Size = new Size(1, 0);
            materialLabel13.TabIndex = 3;
            // 
            // materialLabel14
            // 
            materialLabel14.AutoSize = true;
            materialLabel14.Depth = 0;
            materialLabel14.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel14.Location = new Point(17, 11);
            materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel14.Name = "materialLabel14";
            materialLabel14.Size = new Size(118, 19);
            materialLabel14.TabIndex = 2;
            materialLabel14.Text = "Total Customers";
            // 
            // dgv_dashStock
            // 
            dgv_dashStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_dashStock.BackgroundColor = Color.FromArgb(50, 50, 50);
            dgv_dashStock.BorderStyle = BorderStyle.None;
            dgv_dashStock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(203, 89, 78);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_dashStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_dashStock.ColumnHeadersHeight = 40;
            dgv_dashStock.Columns.AddRange(new DataGridViewColumn[] { Status });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(203, 89, 78);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_dashStock.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_dashStock.EnableHeadersVisualStyles = false;
            dgv_dashStock.GridColor = Color.FromArgb(55, 71, 79);
            dgv_dashStock.Location = new Point(36, 339);
            dgv_dashStock.Name = "dgv_dashStock";
            dgv_dashStock.ReadOnly = true;
            dgv_dashStock.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.DimGray;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(203, 89, 78);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_dashStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_dashStock.RowHeadersWidth = 51;
            dgv_dashStock.RowTemplate.Height = 40;
            dgv_dashStock.Size = new Size(481, 297);
            dgv_dashStock.TabIndex = 19;
            dgv_dashStock.CellFormatting += dgv_dashStock_CellFormatting;
            // 
            // Status
            // 
            Status.FillWeight = 80F;
            Status.HeaderText = "Stock Status";
            Status.MinimumWidth = 80;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Resizable = DataGridViewTriState.False;
            Status.ToolTipText = "Status";
            // 
            // materialFloatingActionButton3
            // 
            materialFloatingActionButton3.Depth = 0;
            materialFloatingActionButton3.Icon = InventoryManagmentSystem.PL.Properties.Resources.down;
            materialFloatingActionButton3.Location = new Point(568, 225);
            materialFloatingActionButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton3.Name = "materialFloatingActionButton3";
            materialFloatingActionButton3.Size = new Size(59, 71);
            materialFloatingActionButton3.TabIndex = 18;
            materialFloatingActionButton3.Text = "materialFloatingActionButton3";
            materialFloatingActionButton3.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(lbl_dashLowStock);
            materialCard3.Controls.Add(materialLabel6);
            materialCard3.Controls.Add(materialLabel3);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(348, 206);
            materialCard3.Margin = new Padding(14, 13, 14, 13);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14, 13, 14, 13);
            materialCard3.Size = new Size(250, 95);
            materialCard3.TabIndex = 17;
            // 
            // lbl_dashLowStock
            // 
            lbl_dashLowStock.AutoSize = true;
            lbl_dashLowStock.Font = new Font("Microsoft Sans Serif", 13.8F);
            lbl_dashLowStock.Location = new Point(114, 52);
            lbl_dashLowStock.Name = "lbl_dashLowStock";
            lbl_dashLowStock.Size = new Size(26, 29);
            lbl_dashLowStock.TabIndex = 4;
            lbl_dashLowStock.Text = "2";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(88, 46);
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
            materialLabel3.Location = new Point(17, 12);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(188, 19);
            materialLabel3.TabIndex = 2;
            materialLabel3.Text = "Low Stock Products Count";
            // 
            // materialFloatingActionButton2
            // 
            materialFloatingActionButton2.Depth = 0;
            materialFloatingActionButton2.Icon = (Image)resources.GetObject("materialFloatingActionButton2.Icon");
            materialFloatingActionButton2.Location = new Point(872, 71);
            materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            materialFloatingActionButton2.Size = new Size(59, 71);
            materialFloatingActionButton2.TabIndex = 16;
            materialFloatingActionButton2.Text = "materialFloatingActionButton2";
            materialFloatingActionButton2.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(label1);
            materialCard2.Controls.Add(lbl_dashTotalSales);
            materialCard2.Controls.Add(materialLabel2);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(660, 61);
            materialCard2.Margin = new Padding(14, 13, 14, 13);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14, 13, 14, 13);
            materialCard2.Size = new Size(250, 95);
            materialCard2.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F);
            label1.Location = new Point(60, 52);
            label1.Name = "label1";
            label1.Size = new Size(26, 29);
            label1.TabIndex = 4;
            label1.Text = "$";
            // 
            // lbl_dashTotalSales
            // 
            lbl_dashTotalSales.AutoSize = true;
            lbl_dashTotalSales.Font = new Font("Microsoft Sans Serif", 13.8F);
            lbl_dashTotalSales.Location = new Point(83, 52);
            lbl_dashTotalSales.Name = "lbl_dashTotalSales";
            lbl_dashTotalSales.Size = new Size(97, 29);
            lbl_dashTotalSales.TabIndex = 2;
            lbl_dashTotalSales.Text = "600,000";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(17, 12);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(106, 19);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "Total Revenue ";
            // 
            // materialFloatingActionButton1
            // 
            materialFloatingActionButton1.Depth = 0;
            materialFloatingActionButton1.ForeColor = Color.White;
            materialFloatingActionButton1.Icon = InventoryManagmentSystem.PL.Properties.Resources.icons8_products_64;
            materialFloatingActionButton1.Location = new Point(256, 80);
            materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            materialFloatingActionButton1.Size = new Size(59, 71);
            materialFloatingActionButton1.TabIndex = 14;
            materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            materialFloatingActionButton1.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lbl_CountOfProd);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(36, 61);
            materialCard1.Margin = new Padding(14, 13, 14, 13);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14, 13, 14, 13);
            materialCard1.Size = new Size(250, 95);
            materialCard1.TabIndex = 13;
            // 
            // lbl_CountOfProd
            // 
            lbl_CountOfProd.AutoSize = true;
            lbl_CountOfProd.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CountOfProd.Location = new Point(97, 52);
            lbl_CountOfProd.Name = "lbl_CountOfProd";
            lbl_CountOfProd.Size = new Size(39, 29);
            lbl_CountOfProd.TabIndex = 1;
            lbl_CountOfProd.Text = "60";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(17, 12);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(105, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Total Products";
            // 
            // Products
            // 
            Products.Controls.Add(groupBox2);
            Products.Controls.Add(groupBox1);
            Products.Controls.Add(dgv_Products);
            Products.ImageKey = "icons8-stock-24.png";
            Products.Location = new Point(4, 31);
            Products.Name = "Products";
            Products.Padding = new Padding(3);
            Products.Size = new Size(1009, 687);
            Products.TabIndex = 1;
            Products.Text = "Products";
            Products.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(materialLabel11);
            groupBox2.Controls.Add(cmb_searchProdSupplier);
            groupBox2.Controls.Add(btn_resetSearchProd);
            groupBox2.Controls.Add(btn_searchProduct);
            groupBox2.Controls.Add(materialLabel10);
            groupBox2.Controls.Add(cmb_searchProdCat);
            groupBox2.Controls.Add(materialLabel9);
            groupBox2.Controls.Add(txt_searchProdName);
            groupBox2.Location = new Point(25, 290);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(911, 110);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search";
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel11.Location = new Point(528, 28);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(59, 19);
            materialLabel11.TabIndex = 0;
            materialLabel11.Text = "Supplier";
            // 
            // cmb_searchProdSupplier
            // 
            cmb_searchProdSupplier.AutoResize = false;
            cmb_searchProdSupplier.BackColor = Color.FromArgb(255, 255, 255);
            cmb_searchProdSupplier.Depth = 0;
            cmb_searchProdSupplier.DrawMode = DrawMode.OwnerDrawVariable;
            cmb_searchProdSupplier.DropDownHeight = 174;
            cmb_searchProdSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_searchProdSupplier.DropDownWidth = 121;
            cmb_searchProdSupplier.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmb_searchProdSupplier.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmb_searchProdSupplier.FormattingEnabled = true;
            cmb_searchProdSupplier.IntegralHeight = false;
            cmb_searchProdSupplier.ItemHeight = 43;
            cmb_searchProdSupplier.Location = new Point(528, 52);
            cmb_searchProdSupplier.MaxDropDownItems = 4;
            cmb_searchProdSupplier.MouseState = MaterialSkin.MouseState.OUT;
            cmb_searchProdSupplier.Name = "cmb_searchProdSupplier";
            cmb_searchProdSupplier.Size = new Size(205, 49);
            cmb_searchProdSupplier.StartIndex = 0;
            cmb_searchProdSupplier.TabIndex = 8;
            // 
            // btn_resetSearchProd
            // 
            btn_resetSearchProd.AutoSize = false;
            btn_resetSearchProd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_resetSearchProd.Cursor = Cursors.Hand;
            btn_resetSearchProd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_resetSearchProd.Depth = 0;
            btn_resetSearchProd.HighEmphasis = true;
            btn_resetSearchProd.Icon = null;
            btn_resetSearchProd.Location = new Point(802, 60);
            btn_resetSearchProd.Margin = new Padding(4, 6, 4, 6);
            btn_resetSearchProd.MouseState = MaterialSkin.MouseState.HOVER;
            btn_resetSearchProd.Name = "btn_resetSearchProd";
            btn_resetSearchProd.NoAccentTextColor = Color.Empty;
            btn_resetSearchProd.Size = new Size(99, 41);
            btn_resetSearchProd.TabIndex = 60;
            btn_resetSearchProd.Text = "Reset";
            btn_resetSearchProd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_resetSearchProd.UseAccentColor = false;
            btn_resetSearchProd.UseVisualStyleBackColor = true;
            btn_resetSearchProd.Click += btn_resetSearchProd_Click;
            // 
            // btn_searchProduct
            // 
            btn_searchProduct.AutoSize = false;
            btn_searchProduct.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_searchProduct.Cursor = Cursors.Hand;
            btn_searchProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_searchProduct.Depth = 0;
            btn_searchProduct.HighEmphasis = true;
            btn_searchProduct.Icon = InventoryManagmentSystem.PL.Properties.Resources.loupe1;
            btn_searchProduct.ImageKey = "(none)";
            btn_searchProduct.Location = new Point(754, 60);
            btn_searchProduct.Margin = new Padding(4, 6, 4, 6);
            btn_searchProduct.MouseState = MaterialSkin.MouseState.HOVER;
            btn_searchProduct.Name = "btn_searchProduct";
            btn_searchProduct.NoAccentTextColor = Color.Empty;
            btn_searchProduct.Size = new Size(40, 41);
            btn_searchProduct.TabIndex = 70;
            btn_searchProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_searchProduct.UseAccentColor = false;
            btn_searchProduct.UseVisualStyleBackColor = true;
            btn_searchProduct.Click += btn_searchProduct_Click;
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(287, 28);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(64, 19);
            materialLabel10.TabIndex = 0;
            materialLabel10.Text = "Category";
            // 
            // cmb_searchProdCat
            // 
            cmb_searchProdCat.AutoResize = false;
            cmb_searchProdCat.BackColor = Color.FromArgb(255, 255, 255);
            cmb_searchProdCat.Depth = 0;
            cmb_searchProdCat.DrawMode = DrawMode.OwnerDrawVariable;
            cmb_searchProdCat.DropDownHeight = 174;
            cmb_searchProdCat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_searchProdCat.DropDownWidth = 121;
            cmb_searchProdCat.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmb_searchProdCat.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmb_searchProdCat.FormattingEnabled = true;
            cmb_searchProdCat.IntegralHeight = false;
            cmb_searchProdCat.ItemHeight = 43;
            cmb_searchProdCat.Location = new Point(287, 52);
            cmb_searchProdCat.MaxDropDownItems = 4;
            cmb_searchProdCat.MouseState = MaterialSkin.MouseState.OUT;
            cmb_searchProdCat.Name = "cmb_searchProdCat";
            cmb_searchProdCat.Size = new Size(205, 49);
            cmb_searchProdCat.StartIndex = 0;
            cmb_searchProdCat.TabIndex = 7;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(11, 28);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(43, 19);
            materialLabel9.TabIndex = 0;
            materialLabel9.Text = "Name";
            // 
            // txt_searchProdName
            // 
            txt_searchProdName.AnimateReadOnly = false;
            txt_searchProdName.BorderStyle = BorderStyle.None;
            txt_searchProdName.Depth = 0;
            txt_searchProdName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_searchProdName.LeadingIcon = null;
            txt_searchProdName.Location = new Point(11, 51);
            txt_searchProdName.MaxLength = 50;
            txt_searchProdName.MouseState = MaterialSkin.MouseState.OUT;
            txt_searchProdName.Multiline = false;
            txt_searchProdName.Name = "txt_searchProdName";
            txt_searchProdName.Size = new Size(240, 50);
            txt_searchProdName.TabIndex = 6;
            txt_searchProdName.Text = "";
            txt_searchProdName.TrailingIcon = null;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_QuantityProd);
            groupBox1.Controls.Add(lbl_quantityProd);
            groupBox1.Controls.Add(btn_ResetProduct);
            groupBox1.Controls.Add(materialLabel4);
            groupBox1.Controls.Add(btn_deleteProduct);
            groupBox1.Controls.Add(cmb_SupProduct);
            groupBox1.Controls.Add(btn_AddProduct);
            groupBox1.Controls.Add(txt_PriceProduct);
            groupBox1.Controls.Add(btn_EditProduct);
            groupBox1.Controls.Add(materialLabel5);
            groupBox1.Controls.Add(txt_NameProduct);
            groupBox1.Controls.Add(materialLabel7);
            groupBox1.Controls.Add(cmb_CatProducts);
            groupBox1.Controls.Add(materialLabel8);
            groupBox1.Location = new Point(24, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(911, 282);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Manage Products";
            // 
            // txt_QuantityProd
            // 
            txt_QuantityProd.AnimateReadOnly = false;
            txt_QuantityProd.BorderStyle = BorderStyle.None;
            txt_QuantityProd.Depth = 0;
            txt_QuantityProd.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_QuantityProd.LeadingIcon = null;
            txt_QuantityProd.Location = new Point(170, 158);
            txt_QuantityProd.MaxLength = 50;
            txt_QuantityProd.MouseState = MaterialSkin.MouseState.OUT;
            txt_QuantityProd.Multiline = false;
            txt_QuantityProd.Name = "txt_QuantityProd";
            txt_QuantityProd.Size = new Size(249, 50);
            txt_QuantityProd.TabIndex = 4;
            txt_QuantityProd.Text = "";
            txt_QuantityProd.TrailingIcon = null;
            txt_QuantityProd.KeyPress += txt_PriceProduct_KeyPress;
            // 
            // lbl_quantityProd
            // 
            lbl_quantityProd.AutoSize = true;
            lbl_quantityProd.Depth = 0;
            lbl_quantityProd.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_quantityProd.Location = new Point(46, 188);
            lbl_quantityProd.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_quantityProd.Name = "lbl_quantityProd";
            lbl_quantityProd.Size = new Size(61, 19);
            lbl_quantityProd.TabIndex = 0;
            lbl_quantityProd.Text = "Quantity";
            // 
            // btn_ResetProduct
            // 
            btn_ResetProduct.AutoSize = false;
            btn_ResetProduct.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_ResetProduct.Cursor = Cursors.Hand;
            btn_ResetProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_ResetProduct.Depth = 0;
            btn_ResetProduct.HighEmphasis = true;
            btn_ResetProduct.Icon = null;
            btn_ResetProduct.Location = new Point(462, 227);
            btn_ResetProduct.Margin = new Padding(4, 6, 4, 6);
            btn_ResetProduct.MouseState = MaterialSkin.MouseState.HOVER;
            btn_ResetProduct.Name = "btn_ResetProduct";
            btn_ResetProduct.NoAccentTextColor = Color.Empty;
            btn_ResetProduct.Size = new Size(99, 41);
            btn_ResetProduct.TabIndex = 0;
            btn_ResetProduct.Text = "Reset";
            btn_ResetProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_ResetProduct.UseAccentColor = false;
            btn_ResetProduct.UseVisualStyleBackColor = true;
            btn_ResetProduct.Click += btn_ResetProduct_Click;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(46, 52);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(43, 19);
            materialLabel4.TabIndex = 0;
            materialLabel4.Text = "Name";
            // 
            // btn_deleteProduct
            // 
            btn_deleteProduct.AutoSize = false;
            btn_deleteProduct.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_deleteProduct.Cursor = Cursors.Hand;
            btn_deleteProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_deleteProduct.Depth = 0;
            btn_deleteProduct.HighEmphasis = true;
            btn_deleteProduct.Icon = null;
            btn_deleteProduct.Location = new Point(586, 227);
            btn_deleteProduct.Margin = new Padding(4, 6, 4, 6);
            btn_deleteProduct.MouseState = MaterialSkin.MouseState.HOVER;
            btn_deleteProduct.Name = "btn_deleteProduct";
            btn_deleteProduct.NoAccentTextColor = Color.Empty;
            btn_deleteProduct.Size = new Size(99, 41);
            btn_deleteProduct.TabIndex = 0;
            btn_deleteProduct.Text = "Delete";
            btn_deleteProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_deleteProduct.UseAccentColor = false;
            btn_deleteProduct.UseVisualStyleBackColor = true;
            btn_deleteProduct.Click += btn_deleteProduct_Click;
            // 
            // cmb_SupProduct
            // 
            cmb_SupProduct.AutoResize = false;
            cmb_SupProduct.BackColor = Color.FromArgb(255, 255, 255);
            cmb_SupProduct.Depth = 0;
            cmb_SupProduct.DrawMode = DrawMode.OwnerDrawVariable;
            cmb_SupProduct.DropDownHeight = 174;
            cmb_SupProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_SupProduct.DropDownWidth = 121;
            cmb_SupProduct.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmb_SupProduct.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmb_SupProduct.FormattingEnabled = true;
            cmb_SupProduct.IntegralHeight = false;
            cmb_SupProduct.ItemHeight = 43;
            cmb_SupProduct.Location = new Point(617, 90);
            cmb_SupProduct.MaxDropDownItems = 4;
            cmb_SupProduct.MouseState = MaterialSkin.MouseState.OUT;
            cmb_SupProduct.Name = "cmb_SupProduct";
            cmb_SupProduct.Size = new Size(249, 49);
            cmb_SupProduct.StartIndex = 0;
            cmb_SupProduct.TabIndex = 3;
            // 
            // btn_AddProduct
            // 
            btn_AddProduct.AutoSize = false;
            btn_AddProduct.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_AddProduct.Cursor = Cursors.Hand;
            btn_AddProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_AddProduct.Depth = 0;
            btn_AddProduct.HighEmphasis = true;
            btn_AddProduct.Icon = null;
            btn_AddProduct.Location = new Point(338, 227);
            btn_AddProduct.Margin = new Padding(4, 6, 4, 6);
            btn_AddProduct.MouseState = MaterialSkin.MouseState.HOVER;
            btn_AddProduct.Name = "btn_AddProduct";
            btn_AddProduct.NoAccentTextColor = Color.Empty;
            btn_AddProduct.Size = new Size(99, 41);
            btn_AddProduct.TabIndex = 0;
            btn_AddProduct.Text = "Add";
            btn_AddProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_AddProduct.UseAccentColor = false;
            btn_AddProduct.UseVisualStyleBackColor = true;
            btn_AddProduct.Click += btn_AddProduct_Click;
            // 
            // txt_PriceProduct
            // 
            txt_PriceProduct.AnimateReadOnly = false;
            txt_PriceProduct.BorderStyle = BorderStyle.None;
            txt_PriceProduct.Depth = 0;
            txt_PriceProduct.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_PriceProduct.LeadingIcon = null;
            txt_PriceProduct.Location = new Point(617, 21);
            txt_PriceProduct.MaxLength = 50;
            txt_PriceProduct.MouseState = MaterialSkin.MouseState.OUT;
            txt_PriceProduct.Multiline = false;
            txt_PriceProduct.Name = "txt_PriceProduct";
            txt_PriceProduct.Size = new Size(249, 50);
            txt_PriceProduct.TabIndex = 1;
            txt_PriceProduct.Text = "";
            txt_PriceProduct.TrailingIcon = null;
            txt_PriceProduct.KeyPress += txt_PriceProduct_KeyPress;
            // 
            // btn_EditProduct
            // 
            btn_EditProduct.AutoSize = false;
            btn_EditProduct.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_EditProduct.Cursor = Cursors.Hand;
            btn_EditProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_EditProduct.Depth = 0;
            btn_EditProduct.HighEmphasis = true;
            btn_EditProduct.Icon = null;
            btn_EditProduct.Location = new Point(214, 227);
            btn_EditProduct.Margin = new Padding(4, 6, 4, 6);
            btn_EditProduct.MouseState = MaterialSkin.MouseState.HOVER;
            btn_EditProduct.Name = "btn_EditProduct";
            btn_EditProduct.NoAccentTextColor = Color.Empty;
            btn_EditProduct.Size = new Size(99, 41);
            btn_EditProduct.TabIndex = 0;
            btn_EditProduct.Text = "Update";
            btn_EditProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_EditProduct.UseAccentColor = false;
            btn_EditProduct.UseVisualStyleBackColor = true;
            btn_EditProduct.Click += btn_EditProduct_Click;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(46, 120);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(64, 19);
            materialLabel5.TabIndex = 0;
            materialLabel5.Text = "Category";
            // 
            // txt_NameProduct
            // 
            txt_NameProduct.AnimateReadOnly = false;
            txt_NameProduct.BorderStyle = BorderStyle.None;
            txt_NameProduct.Depth = 0;
            txt_NameProduct.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_NameProduct.LeadingIcon = null;
            txt_NameProduct.Location = new Point(170, 21);
            txt_NameProduct.MaxLength = 50;
            txt_NameProduct.MouseState = MaterialSkin.MouseState.OUT;
            txt_NameProduct.Multiline = false;
            txt_NameProduct.Name = "txt_NameProduct";
            txt_NameProduct.Size = new Size(249, 50);
            txt_NameProduct.TabIndex = 0;
            txt_NameProduct.Text = "";
            txt_NameProduct.TrailingIcon = null;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(500, 120);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(59, 19);
            materialLabel7.TabIndex = 0;
            materialLabel7.Text = "Supplier";
            // 
            // cmb_CatProducts
            // 
            cmb_CatProducts.AutoResize = false;
            cmb_CatProducts.BackColor = Color.FromArgb(255, 255, 255);
            cmb_CatProducts.Depth = 0;
            cmb_CatProducts.DrawMode = DrawMode.OwnerDrawVariable;
            cmb_CatProducts.DropDownHeight = 174;
            cmb_CatProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_CatProducts.DropDownWidth = 121;
            cmb_CatProducts.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmb_CatProducts.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmb_CatProducts.FormattingEnabled = true;
            cmb_CatProducts.IntegralHeight = false;
            cmb_CatProducts.ItemHeight = 43;
            cmb_CatProducts.Location = new Point(170, 90);
            cmb_CatProducts.MaxDropDownItems = 4;
            cmb_CatProducts.MouseState = MaterialSkin.MouseState.OUT;
            cmb_CatProducts.Name = "cmb_CatProducts";
            cmb_CatProducts.Size = new Size(249, 49);
            cmb_CatProducts.StartIndex = 0;
            cmb_CatProducts.TabIndex = 2;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(500, 52);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(36, 19);
            materialLabel8.TabIndex = 0;
            materialLabel8.Text = "Price";
            // 
            // dgv_Products
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(203, 89, 78);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgv_Products.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Products.BackgroundColor = Color.FromArgb(50, 50, 50);
            dgv_Products.BorderStyle = BorderStyle.None;
            dgv_Products.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Products.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.DimGray;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(203, 89, 78);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgv_Products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv_Products.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(203, 89, 78);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgv_Products.DefaultCellStyle = dataGridViewCellStyle6;
            dgv_Products.EnableHeadersVisualStyles = false;
            dgv_Products.GridColor = Color.FromArgb(55, 71, 79);
            dgv_Products.Location = new Point(24, 408);
            dgv_Products.Name = "dgv_Products";
            dgv_Products.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.DimGray;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(203, 89, 78);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgv_Products.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgv_Products.RowHeadersWidth = 40;
            dgv_Products.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(203, 89, 78);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dgv_Products.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgv_Products.RowTemplate.Height = 40;
            dgv_Products.RowTemplate.ReadOnly = true;
            dgv_Products.Size = new Size(911, 278);
            dgv_Products.TabIndex = 23;
            dgv_Products.RowHeaderMouseDoubleClick += dgv_Products_RowHeaderMouseDoubleClick;
            // 
            // Reports
            // 
            Reports.ImageKey = "icons8-reports-32.png";
            Reports.Location = new Point(4, 31);
            Reports.Name = "Reports";
            Reports.Padding = new Padding(3);
            Reports.Size = new Size(1009, 687);
            Reports.TabIndex = 2;
            Reports.Text = "Reports";
            Reports.UseVisualStyleBackColor = true;
            // 
            // Sales
            // 
            Sales.ImageKey = "icons8-us-dollar-26.png";
            Sales.Location = new Point(4, 31);
            Sales.Name = "Sales";
            Sales.Size = new Size(1009, 687);
            Sales.TabIndex = 3;
            Sales.Text = "Sales";
            Sales.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-dashboard-layout-24.png");
            imageList1.Images.SetKeyName(1, "icons8-stock-24.png");
            imageList1.Images.SetKeyName(2, "icons8-reports-32.png");
            imageList1.Images.SetKeyName(3, "icons8-us-dollar-26.png");
            // 
            // btn_LogOut
            // 
            btn_LogOut.AutoSize = false;
            btn_LogOut.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_LogOut.BackColor = Color.White;
            btn_LogOut.Cursor = Cursors.Hand;
            btn_LogOut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_LogOut.Depth = 0;
            btn_LogOut.HighEmphasis = true;
            btn_LogOut.Icon = InventoryManagmentSystem.PL.Properties.Resources.icons8_logout_26;
            btn_LogOut.Location = new Point(974, 24);
            btn_LogOut.Margin = new Padding(4, 6, 4, 6);
            btn_LogOut.MouseState = MaterialSkin.MouseState.HOVER;
            btn_LogOut.Name = "btn_LogOut";
            btn_LogOut.NoAccentTextColor = Color.Empty;
            btn_LogOut.Size = new Size(46, 39);
            btn_LogOut.TabIndex = 1;
            btn_LogOut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_LogOut.UseAccentColor = false;
            btn_LogOut.UseVisualStyleBackColor = false;
            btn_LogOut.Click += btn_LogOut_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 783);
            Controls.Add(btn_LogOut);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "ManagerForm";
            Padding = new Padding(3, 58, 3, 3);
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            Load += ManagerForm_Load;
            materialTabControl1.ResumeLayout(false);
            Dashboards.ResumeLayout(false);
            materialCard6.ResumeLayout(false);
            materialCard6.PerformLayout();
            materialCard5.ResumeLayout(false);
            materialCard5.PerformLayout();
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_dashStock).EndInit();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            Products.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Products).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage Dashboards;
        private TabPage Products;
        private TabPage Reports;
        private ImageList imageList1;
        private GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialComboBox cmb_searchProdSupplier;
        private MaterialSkin.Controls.MaterialButton btn_resetSearchProd;
        private MaterialSkin.Controls.MaterialButton btn_searchProduct;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialComboBox cmb_searchProdCat;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox txt_searchProdName;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox txt_QuantityProd;
        private MaterialSkin.Controls.MaterialLabel lbl_quantityProd;
        private MaterialSkin.Controls.MaterialButton btn_ResetProduct;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton btn_deleteProduct;
        private MaterialSkin.Controls.MaterialComboBox cmb_SupProduct;
        private MaterialSkin.Controls.MaterialButton btn_AddProduct;
        private MaterialSkin.Controls.MaterialTextBox txt_PriceProduct;
        private MaterialSkin.Controls.MaterialButton btn_EditProduct;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox txt_NameProduct;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialComboBox cmb_CatProducts;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private DataGridView dgv_Products;
        private MaterialSkin.Controls.MaterialButton btn_LogOut;
        private TabPage Sales;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton6;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private Label lbl_dashTotalOrders;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton5;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private Label lbl_dashBestSellingProd;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton4;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private Label lbl_dashTotalCust;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private DataGridView dgv_dashStock;
        private DataGridViewTextBoxColumn Status;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton3;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private Label lbl_dashLowStock;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Label label1;
        private Label lbl_dashTotalSales;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label lbl_CountOfProd;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
